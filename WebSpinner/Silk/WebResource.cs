﻿/* ----------------------------------------------------------------------------
WebSpinner : a website builder
Copyright (C) 2005-2020  George E Greaney

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using Kohoutech.ENAML;

namespace WebSpinner.Silk
{
    public class WebResource
    {
        public WebFolder folder;
        public string filename;
        public String filepath;

        public WebResource() : this("none", null, "")
        {
        }

        public WebResource(String _name, WebFolder _folder, String _path)
        {
            filename = _name;
            filepath = _path;
            folder = _folder;
        }

        //public static WebResource loadResource(EnamlData silk, string path, string name, WebFolder folder)
        //{
        //    String respath = silk.getStringValue(path + "." + name + ".path", "");
        //    String resname = Path.GetFileName(respath);
        //    respath = Path.GetDirectoryName(respath);
        //    WebResource resource = new WebResource(resname, respath, folder);
        //    return resource;
        //}

        public override string ToString()
        {
            return filename;
        }
    }
}
