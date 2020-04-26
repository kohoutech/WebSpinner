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
using System.Windows.Forms;
using WebSpinner.Silk;

namespace WebSpinner
{
    public class Spinner
    {
        public SpinnerWindow spinnerView;

        public WebSite website;

        public Spinner(SpinnerWindow _spinnerWindow)
        {
            spinnerView = _spinnerWindow;
            website = null;
        }

        public void openFile(string filename)
        {
            website = WebSite.loadSilkFile(filename);
            TreeNode rootfolderView = spinnerView.AddFolder(website.root, null);
            BuildSiteView(website.root, rootfolderView);
        }

        public void BuildSiteView(WebFolder folder, TreeNode folderView)
        {
            foreach(WebPage page in folder.pages)
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
                BuildSiteView(f, subfolderView);
            }
        }
    }
}
