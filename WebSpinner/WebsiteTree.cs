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
using System.Windows.Forms;
using System.Drawing;

using WebSpinner.Silk;

namespace WebSpinner
{
    public class WebsiteTree : TreeView
    {
        public WebSite website;         //the model

        public WebsiteTree() : base()
        {
            website = null;
        }

        public void setWebsite(WebSite site)
        {
            TreeNode sitenode = new TreeNode(site.name);
            sitenode.Tag = site;
            //node.ForeColor = Color.Blue;
            sitenode.ImageIndex = 0;
            //    if (folderView == null)
            //    {
            Nodes.Add(sitenode);

            TreeNode rootnode = new TreeNode(site.root.name);
            rootnode.Tag = site.root;
            //    node.ForeColor = Color.Blue;
            rootnode.ImageIndex = 1;
            sitenode.Nodes.Add(rootnode);

            buildSiteView(site.root, rootnode);
        }

        public void buildSiteView(WebFolder folder, TreeNode folderView)
        {
                foreach (WebPage page in folder.pages)
                {
                    AddPage(page, folderView);
                }

                foreach (WebResource resource in folder.resources)
                {
                    AddResources(resource, folderView);
                }

                foreach (WebFolder f in folder.folders)
                {
                    AddFolder(f, folderView);                    
                }
        }

        //- tree view ---------------------------------------------------------

        public void AddFolder(WebFolder folder, TreeNode folderView)
        {
            TreeNode node = new TreeNode(folder.name);
            node.Tag = folder;
            //    node.ForeColor = Color.Blue;
            node.ImageIndex = 1;
            folderView.Nodes.Add(node);

            buildSiteView(folder, node);
        }

        public void AddPage(WebPage page, TreeNode folderView)
        {
            TreeNode node = new TreeNode(page.name);
            node.Tag = page;
            node.ImageIndex = 2;
            folderView.Nodes.Add(node);
        }

        public void AddResources(WebResource resource, TreeNode folderView)
        {
            TreeNode node = new TreeNode(resource.name);
            node.Tag = resource;
            //node.ForeColor = Color.Red;
            node.ImageIndex = 3;
            folderView.Nodes.Add(node);
        }

        //private void siteTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        //{

        //}

        //private void siteTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        //{

        //}

    }
}
