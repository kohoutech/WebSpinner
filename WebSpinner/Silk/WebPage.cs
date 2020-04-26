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

using Origami.ENAML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebSpinner.Silk
{
    public class WebPage
    {
        public String name;
        public WebFolder folder;

        public String template;
        public String content;

        public WebPage(String _html, WebFolder _folder, String _template, String _content)
        {
            name = _html;
            folder = _folder;
            template = _template;
            content = _content;
        }

        public static WebPage loadPage(EnamlData silk, string path, string name, WebFolder folder)
        {
            String fullpath = path + "." + name;
            String html = silk.getStringValue(fullpath + ".html", "");
            String template = silk.getStringValue(fullpath + ".template", "");
            String content = silk.getStringValue(fullpath + ".content", "");

            WebPage page = new WebPage(html, folder, template, content);
            return page;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
