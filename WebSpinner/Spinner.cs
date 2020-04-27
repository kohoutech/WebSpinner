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

//"the weaver in the web that he made"

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using WebSpinner.Silk;
using Panorama.HAML;

namespace WebSpinner
{
    public class Spinner
    {
        public SpinnerWindow spinnerView;           //the view
        public Generator generator;
        public WebSite website;                     //the model

        public Spinner(SpinnerWindow _spinnerWindow)
        {
            spinnerView = _spinnerWindow;
            generator = new Generator();
            website = null;
        }

        //- website i/o -------------------------------------------------------

        public void openFile(string filename)
        {
            website = WebSite.loadSilkFile(filename);
            TreeNode rootfolderView = spinnerView.AddFolder(website.root, null);
            buildSiteView(website.root, rootfolderView);
        }

        public void buildSiteView(WebFolder folder, TreeNode folderView)
        {
            foreach (WebPage page in folder.pages)
            {
                spinnerView.AddPage(page, folderView);
            }

            foreach (WebResource resource in folder.resources)
            {
                spinnerView.AddResources(resource, folderView);
            }

            foreach (WebFolder f in folder.folders)
            {
                TreeNode subfolderView = spinnerView.AddFolder(f, folderView);
                buildSiteView(f, subfolderView);
            }
        }

        //- website deployment ------------------------------------------------

        public void buildWebsite()
        {
            buildWebFolder(website.root, website.devroot, ".");
        }

        public void publishWebsite()
        {
            buildWebFolder(website.root, website.prodroot, ".");
        }

        public void buildWebFolder(WebFolder folder, string siteroot, string folderpath)
        {
            string destpath = siteroot + "\\" + folderpath;
            if (!Directory.Exists(destpath))
            {
                Directory.CreateDirectory(destpath);
            }
            foreach (WebPage page in folder.pages)
            {
                string pagepath = destpath + "\\" + page.name;
                if (page.template.Length > 0 && page.content.Length > 0)
                {
                    generator.generatePage(page.template, page.content, pagepath);
                }
                else
                {
                    string htmlpath = website.silkroot + "\\" + folderpath + "\\" + page.name;
                    File.Copy(htmlpath, pagepath, true);
                }
            }

            foreach (WebResource resource in folder.resources)
            {
                string srcpath = website.silkroot + "\\" + resource.filepath + "\\" + resource.filename;
                string respath = destpath + "\\" + resource.filename;
                File.Copy(srcpath, respath, true);
            }

            foreach (WebFolder subfolder in folder.folders)
            {
                buildWebFolder(subfolder, siteroot, folderpath + "\\" + subfolder.name);
            }
        }

    }
}
