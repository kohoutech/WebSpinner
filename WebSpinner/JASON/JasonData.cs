/* ----------------------------------------------------------------------------
Kohoutech JSON Library
Copyright (C) 2012-2020  George E Greaney

This program is free software; you can redistribute it and/or
modify it under the terms of the GNU General Public License
as published by the Free Software Foundation; either version 2
of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program; if not, write to the Free Software
Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
----------------------------------------------------------------------------*/

//JSON syntax : https://www.json.org/json-en.html
//              https://www.ietf.org/rfc/rfc4627.txt

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Kohoutech.Jason
{
    public class JasonData
    {
        public JasonValue root;
        public static JasonData curData;                //static field to point to jason data we're currently building
        public Dictionary<int, Object> objects;         //dict of objs for resolving obj refs during build

        public JasonData(JasonValue _root)
        {
            root = _root;
            curData = this;
            objects = new Dictionary<int, object>();
        }

        public Object buildObjectGraph()
        {
            Object obj = root.build();
            return obj;
        }

        public String writeData(JasonData jd)
        {
            StringBuilder outText = new StringBuilder();
            String indent = "";
            jd.root.write(outText, indent);

            return outText.ToString();
        }
    }

    //base class
    public class JasonValue
    {
        public virtual Object build()
        {
            return null;
        }

        public virtual void write(StringBuilder outText, String indent)
        {
        }
    }

    public class JasonObject : JasonValue
    {
        public Dictionary<String, JasonValue> members;

        public JasonObject()
        {
            members = new Dictionary<string, JasonValue>();
        }

        public override Object build()
        {
            //create object from type name
            JasonValue typeval = members["$type"];
            String typestr = ((JasonString)typeval).str;
            Type objType = Type.GetType(typestr);
            Object obj = Activator.CreateInstance(objType);

            //store object in objects dict by id num
            JasonValue idval = members["$id"];
            int idnum = (int)((JasonNumber)idval).build();
            JasonData.curData.objects[idnum] = obj;

            //iterate through field list and set values
            foreach (String fieldname in members.Keys)
            {
                //skip meta fields
                if (fieldname.StartsWith("$"))
                    continue;

                //get field value
                JasonValue val = members[fieldname];
                dynamic fieldval = val.build();

                //if field name starts with # then it is an object reference
                //retrieve object from objects dict by id num
                if (fieldname.StartsWith("#"))
                {
                    String fname = fieldname.Substring(1);
                    int fieldid = (int)fieldval;
                    Object fieldobj = JasonData.curData.objects[fieldid];
                    obj.GetType().GetField(fname).SetValue(obj, fieldobj);
                }
                else
                {
                    if (val is JasonArray)
                    {
                        //get the actual list that the object's field refers to
                        FieldInfo fi = obj.GetType().GetField(fieldname);
                        dynamic fldVal = fi.GetValue(obj);

                        //add to list field one item as time
                        List<Object> listvals = (List<Object>)fieldval;
                        foreach (dynamic listval in listvals)
                        {
                            fldVal.Add(listval);
                        }
                    }
                    else
                    {
                        obj.GetType().GetField(fieldname).SetValue(obj, fieldval);
                    }
                }
            }

            return obj;
        }

        public override void write(StringBuilder outText, String indent)
        {
            String indent2 = indent + "  ";
            outText.Append("{\r\n" + indent2);
            List<String> fields = new List<String>(members.Keys);
            int idx = 1;
            foreach (String fieldname in fields)
            {
                outText.Append("\"" + fieldname + "\": ");
                JasonValue val = members[fieldname];
                val.write(outText, indent2);
                if (idx < fields.Count)
                {
                    outText.Append(",\r\n" + indent2);
                    idx++;
                }
            }
            outText.Append("\r\n" + indent + "}");
        }
    }

    public class JasonArray : JasonValue
    {
        public List<JasonValue> elements;

        public JasonArray()
        {
            elements = new List<JasonValue>();
        }

        public override Object build()
        {
            List<Object> vals = new List<object>();
            foreach (JasonValue elem in elements)
            {
                Object val = elem.build();
                vals.Add(val);
            }
            return vals;
        }

        public override void write(StringBuilder outText, String indent)
        {
            if (elements.Count == 0)
            {
                outText.Append("[]");
            }
            else
            {
                String indent2 = indent + "  ";
                outText.Append("[\r\n" + indent2);
                int idx = 1;
                foreach (JasonValue elem in elements)
                {
                    elem.write(outText, indent2);
                    if (idx < elements.Count)
                    {
                        outText.Append(",\r\n" + indent2);
                        idx++;
                    }
                }
                outText.Append("\r\n" + indent + "]");
            }
        }
    }

    public class JasonString : JasonValue
    {
        public String str;

        public JasonString(String _str)
        {
            str = _str;
        }

        public override Object build()
        {
            return str;
        }

        public override void write(StringBuilder outText, String indent)
        {
            outText.Append("\"");
            foreach (char c in str)
            {
                switch(c)
                {
                    case '\\' : outText.Append("\\\\"); break;
                    
                    default:
                        outText.Append(c);
                        break;
                }
            }
            outText.Append("\"");
        }
    }

    public class JasonNumber : JasonValue
    {
        public String num;

        public JasonNumber(String _num)
        {
            num = _num;
        }

        public override Object build()
        {
            if (num.Contains("."))
            {
                double d = double.Parse(num);
                return d;
            }
            else
            {
                int i = Int32.Parse(num);
                return i;
            }
        }

        public override void write(StringBuilder outText, String indent)
        {
            outText.Append(num);
        }
    }

    public class JasonBoolean : JasonValue
    {
        public Boolean val;

        public JasonBoolean(bool _val)
        {
            val = _val;
        }

        public override Object build()
        {
            return val;
        }

        public override void write(StringBuilder outText, String indent)
        {
            outText.Append(val ? "true" : "false");
        }
    }

    public class JasonNull : JasonValue
    {
        public JasonNull()
        {
        }

        //don't need to override build method

        public override void write(StringBuilder outText, String indent)
        {
            outText.Append("null");
        }
    }
}
