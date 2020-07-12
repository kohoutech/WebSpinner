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

//"the weaver in the web that he made"

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using WebSpinner.Silk;
using VDG;
using Kohoutech.Jason;

namespace WebSpinner
{
    public class Spinner
    {
        public SpinnerWindow spinnerWindow;
        public WebsiteTree siteTree;           //the view
        public WebSite website;                //the model
        public Vander generator;

        public Spinner(SpinnerWindow _spinnerWindow)
        {
            spinnerWindow = _spinnerWindow;
            siteTree = spinnerWindow.siteTree;
            generator = new Vander();
            //website = null;
            website = new WebSite();

            JasonWriter jason = new JasonWriter();
            String s = jason.Write(website);
        }

        //- website i/o -------------------------------------------------------

        public void loadSilk(string filename)
        {
            String jasonData = File.ReadAllText(filename);
            JasonReader reader = new JasonReader();
            website = (WebSite)reader.readFrom(jasonData);
            siteTree.setWebsite(website);
        }

        //- website deployment ------------------------------------------------

        public void buildWebsite()
        {
            buildWebFolder(website.root, website.buildPath, ".");
        }

        public void publishWebsite()
        {
            buildWebFolder(website.root, website.publishPath, ".");
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
                    generator.generatePage();
                }
                else
                {
                    string htmlpath = "\\" + folderpath + "\\" + page.name;
                    File.Copy(htmlpath, pagepath, true);
                }
            }

            foreach (WebResource resource in folder.resources)
            {
                string srcpath = resource.sourcePath + "\\" + resource.name;
                string respath = destpath + "\\" + resource.name;
                File.Copy(srcpath, respath, true);
            }

            foreach (WebFolder subfolder in folder.folders)
            {
                buildWebFolder(subfolder, siteroot, folderpath + "\\" + subfolder.name);
            }
        }

    }
}
