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
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using WebSpinner.Silk;

namespace Kohoutech.Jason
{
    class JasonWriter
    {
        public int objnum;
        public Dictionary<Object, int> objects;         //dict of objs for resolving obj refs during build

        public JasonWriter()
        {
        }

        public String serialize(Object obj)
        {
            objnum = 1;
            objects = new Dictionary<object, int>();

            JasonValue val = convertObject(obj);
            JasonData jd = new JasonData(val);

            String data = jd.writeData(jd);
            return data;
        }

        public JasonValue convertObject(Object obj)
        {
            if (obj == null)
            {
                return new JasonNull();
            }
            Type objType = obj.GetType();

            if (objType == typeof(string))
            {
                return new JasonString((String)obj);
            }
            if (objType == typeof(bool))
            {
                return new JasonBoolean((Boolean)obj);
            }
            if (objType == typeof(byte) || objType == typeof(sbyte) || objType == typeof(short) || objType == typeof(ushort) ||
                objType == typeof(int) || objType == typeof(uint) || objType == typeof(long) || objType == typeof(ulong) ||
                objType == typeof(float) || objType == typeof(double))
            {
                return new JasonNumber(obj.ToString());
            }

            //if (obj is IList<object> && objType.IsGenericType && objType.GetGenericTypeDefinition().IsAssignableFrom(typeof(List<>)))
            if (typeof(IList).IsAssignableFrom(objType))
            {
                IList objlist = (IList)obj;
                JasonArray jarray = new JasonArray();
                foreach(Object elem in objlist)
                {
                    JasonValue elemVal = convertObject(elem);
                    jarray.elements.Add(elemVal);
                }
                return jarray;
            }

            JasonObject jo = new JasonObject();
            jo.members["$type"] = new JasonString(objType.FullName);
            jo.members["$id"] = new JasonNumber(objnum.ToString());
            objects[obj] = objnum++;
            FieldInfo[] objMembers = objType.GetFields();
            JasonValue objVal = null;
            foreach (MemberInfo minfo in objMembers)
            {
                String name = minfo.Name;
                Object fobj = objType.GetField(name).GetValue(obj);

                //check for previous object
                if (fobj != null && objects.ContainsKey(fobj))
                {
                    name = "#" + name;
                    objVal = new JasonNumber(objects[fobj].ToString());
                }
                else
                {
                    objVal = convertObject(fobj);
                }
                jo.members[name] = objVal;            
            }
            return jo;
        }
    }
}
