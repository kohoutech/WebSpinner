/* ----------------------------------------------------------------------------
WebSpinner : a website manager
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

using Origami.ENAML;

namespace WebSpinner.Silk
{
    public class WebSite
    {
        public String version;
        public String silkroot;
        public String devroot;
        public String prodroot;
        public WebFolder root;

        public WebSite()
        {
            version = "1.0.0";
            silkroot = "";
            devroot = "";
            prodroot = "";
            root = null;
        }

        public static WebSite loadSilkFile(string filename)
        {
            WebSite site = new WebSite();

            site.silkroot = Path.GetDirectoryName(filename);
            EnamlData silk = EnamlData.loadFromFile(filename);

            site.version = silk.getStringValue("Silk.version", "");
            site.devroot = silk.getStringValue("Silk.devroot", "");
            site.prodroot = silk.getStringValue("Silk.prodroot", "");

            site.root = WebFolder.loadFolder(silk, "", "root", null);

            return site;
        }

    }
}
