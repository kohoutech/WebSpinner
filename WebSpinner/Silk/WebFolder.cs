/* ----------------------------------------------------------------------------
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

using Kohoutech.ENAML;

namespace WebSpinner.Silk
{
    public class WebFolder
    {
        public String name;
        public WebFolder parent;
        public List<WebPage> pages;
        public List<WebResource> resources;
        public List<WebFolder> folders;

        public WebFolder() : this("none", null)
        {
        }

        public WebFolder(String _name, WebFolder _parent)
        {
            name = _name;
            parent = _parent;
            pages = new List<WebPage>();
            resources = new List<WebResource>();
            folders = new List<WebFolder>();
        }

        public override string ToString()
        {
            return name;
        }

    }
}
