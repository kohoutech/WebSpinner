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

namespace Kohoutech.Jason
{
    public class JasonReader
    {
        public JasonReader()
        {
        }

        public Object readFrom(String jasonData)
        {
            JasonData jd = parseData(jasonData);

            Object result = jd.buildObjectGraph();
            return result;
        }

        //- parser ------------------------------------------------------------

        String jasonStr;
        int pos;

        public JasonData parseData(string _jasonStr)
        {
            jasonStr = _jasonStr;
            pos = 0;
            JasonValue root = parseValue();
            return new JasonData(root);
        }

        public void skipWhiteSpace()
        {
            while (pos < jasonStr.Length &&
                (jasonStr[pos] == ' ' || jasonStr[pos] == '\r' || jasonStr[pos] == '\n' || jasonStr[pos] == '\t'))
                pos++;
        }

        public JasonValue parseValue()
        {
            JasonValue val = null;
            skipWhiteSpace();
            switch (jasonStr[pos])
            {
                case '{':
                    val = parseObject();
                    break;

                case '[':
                    val = parseArray();
                    break;

                case '\"':
                    val = parseStringValue();
                    break;

                case '-':
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    val = parseNumber();
                    break;

                default:
                    throw new JasonReadException("illegal value starting char " + jasonStr[pos]);
                    break;
            }
            skipWhiteSpace();
            return val;
        }

        public JasonObject parseObject()
        {
            JasonObject obj = new JasonObject();
            pos++;                                      //skip opening delim
            skipWhiteSpace();

            bool done = (jasonStr[pos] == '}');
            while (!done)
            {
                String str = parseString();                
                skipWhiteSpace();
                if (jasonStr[pos++] != ':')             
                    throw new JasonReadException("missing : separator");
                JasonValue val = parseValue();

                obj.members[str] = val;

                if (jasonStr[pos] != ','  && jasonStr[pos] != '}')
                    throw new JasonReadException("missing , or } delimiter");
                done = (jasonStr[pos] == '}') ;
                if (!done)
                {
                    pos++;                  //skip ',' separator
                    skipWhiteSpace();
                }
            }
            pos++;                  //skip closing delim
            return obj;
        }

        public JasonArray parseArray()
        {
            JasonArray arr = new JasonArray();
            pos++;                                  //skip opening delim
            skipWhiteSpace();
            bool done = (jasonStr[pos] == ']');
            while (!done)
            {
                JasonValue elem = parseValue();
                arr.elements.Add(elem);

                done = (jasonStr[pos] == ']');
                if (!done)
                {
                    pos++;          //skip ',' separator
                }
            } 
            pos++;                  //skip closing delim
            return arr;
        }

        public JasonValue parseStringValue()
        {
            String str = parseString();
            if ("true".Equals(str))
            {
                return new JasonBoolean(true);
            }
            if ("false".Equals(str))
            {
                return new JasonBoolean(false);
            }
            if ("null".Equals(str))
            {
                return new JasonNull();
            }
            return new JasonString(str);
        }

        public JasonNumber parseNumber()
        {
            StringBuilder numstr = new StringBuilder();
            char ch = jasonStr[pos];
            if (ch == '-')
            {
                numstr.Append(ch);
                ch = jasonStr[++pos];
            }

            if (ch == '0')
            {
                numstr.Append(ch);
                ch = jasonStr[++pos];
            }
            else if (ch >= '1' && ch <= '9')
            {
                while (ch >= '0' && ch <= '9') 
                {
                    numstr.Append(ch);
                    ch = jasonStr[++pos];
                } 
            }

            if (ch == '.')
            {
                numstr.Append(ch);
                ch = jasonStr[++pos];
                while (ch >= '0' && ch <= '9')
                {
                    numstr.Append(ch);
                    ch = jasonStr[++pos];
                }
            }

            if (ch == 'e' || ch == 'E')
            {
                numstr.Append(ch);
                ch = jasonStr[++pos];
                if (ch == '+' || ch == '-')
                {
                    numstr.Append(ch);
                    ch = jasonStr[++pos];
                }
                while (ch >= '0' && ch <= '9')
                {
                    numstr.Append(ch);
                    ch = jasonStr[++pos];
                }
            }

            return new JasonNumber(numstr.ToString());
        }

        public String parseString()
        {
            StringBuilder str = new StringBuilder();
            pos++;                                      //skip opening quote
            while (jasonStr[pos] != '\"')
            {
                char ch = jasonStr[pos++];
                if (ch == '\\')
                {
                    char ch2 = jasonStr[pos++];
                    switch (ch2)
                    {
                        case '\"': ch = '\"'; break;
                        case '\\': ch = '\\'; break;
                        case '/': ch = '/'; break;
                        case 'b': ch = '\b'; break;
                        case 'f': ch = '\f'; break;
                        case 'n': ch = '\n'; break;
                        case 'r': ch = '\r'; break;
                        case 't': ch = '\t'; break;
                        case 'u':
                            {
                                int sum = 0;
                                for (int i = 0; i < 4; i++)
                                {
                                    int val = 0;
                                    char hex = ch2 = jasonStr[pos++];
                                    if (hex >= '0' && hex <= '9')
                                        val = hex - '0';
                                    else if (hex >= 'A' && hex <= 'F')
                                        val = hex - 'A';
                                    else if (hex >= 'a' && hex <= 'f')
                                        val = hex - 'a';
                                    else
                                        throw new JasonReadException("illegal char " + hex + " in hexadecimal string constant");
                                    sum = sum * 10 + val;
                                }
                                ch = (char)sum;
                            }
                            break;
                        default:
                            throw new JasonReadException("illegal escape char " + ch2 + " in string constant");
                            break;
                    };
                }
                str.Append(ch);
            }
            pos++;                                      //skip closing quote

            return str.ToString();
        }
    }

    //- error handling --------------------------------------------------------

    public class JasonReadException : Exception
    {
        public JasonReadException(String reason) : base(reason)
        {
        }
    }
}
