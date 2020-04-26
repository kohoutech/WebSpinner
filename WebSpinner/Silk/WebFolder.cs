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

using Origami.ENAML;

namespace WebSpinner.Silk
{
    public class WebFolder
    {
        public String name;
        public WebFolder parent;
        public List<WebPage> pages;
        public List<WebResource> resources;
        public List<WebFolder> folders;

        public WebFolder(String _name, WebFolder _parent)
        {
            name = _name;
            parent = _parent;
            pages = new List<WebPage>();
            resources = new List<WebResource>();
            folders = new List<WebFolder>();
        }

        public static WebFolder loadFolder(EnamlData silk, string path, string name, WebFolder parent)
        {
            WebFolder folder = new WebFolder(name, parent);

            string fullpath = (path.Length > 0) ? path + "." + name + "." : "";

            List<String> pagenames = silk.getPathKeys(fullpath + "pages");
            foreach (String pagename in pagenames)
            {
                WebPage page = WebPage.loadPage(silk, fullpath + "pages", pagename, folder);
                folder.pages.Add(page);
            }

            List<String> resourcenames = silk.getPathKeys(fullpath + "resources");
            foreach (String resname in resourcenames)
            {
                WebResource resource = WebResource.loadResource(silk, fullpath + "resources", resname, folder);
                folder.resources.Add(resource);
            }

            List<String> foldernames = silk.getPathKeys(fullpath + "folders");
            foreach (String foldername in foldernames)
            {
                WebFolder subfolder = WebFolder.loadFolder(silk, fullpath + "folders", foldername, folder);
                folder.folders.Add(subfolder);
            }

            return folder;
        }

        public override string ToString()
        {
            return name;
        }

    }
}
