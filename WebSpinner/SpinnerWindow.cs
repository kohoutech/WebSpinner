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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using WebSpinner.Silk;

namespace WebSpinner
{
    public partial class SpinnerWindow : Form
    {
        public Spinner spinner;

        public SpinnerWindow()
        {
            InitializeComponent();

            spinner = new Spinner(this);
        }

        //- file menu ---------------------------------------------------------

        private void newFileMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openFileMenuItem_Click(object sender, EventArgs e)
        {
            string[] silkLocation = File.ReadAllLines("test.txt");
            String filename = silkLocation[0];
            spinner.loadSilk(filename);
            this.Text = "WebSpinner [" + filename + "]";
        }

        private void saveFileMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveAsFileMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitFileMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //- page menu ---------------------------------------------------------

        private void newPageMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editPageMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deletePageMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newFolderMenuItem_Click(object sender, EventArgs e)
        {

        }

        //- website -----------------------------------------------------------

        private void editWebsiteMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buildWebsiteMenuItem_Click(object sender, EventArgs e)
        {
            spinner.buildWebsite();
        }

        private void publishWebsiteMenuItem_Click(object sender, EventArgs e)
        {
            spinner.publishWebsite();
        }

        //- help menu ---------------------------------------------------------

        private void aboutHelpMenuItem_Click(object sender, EventArgs e)
        {
            String msg = "WebSpinner\nversion 1.1.0\n" + "\xA9 Panorama Software 2005-2020\n" + "http://panorama.kohoutech.com";
            MessageBox.Show(msg, "About");
        }

        //- tree view ---------------------------------------------------------

        public TreeNode AddFolder(WebFolder folder, TreeNode folderView)
        {
            TreeNode node = new TreeNode(folder.name);
            node.Tag = folder;
            node.ForeColor = Color.Blue;
            if (folderView == null)
            {
                siteTreeView.Nodes.Add(node);
            }
            else
            {
                folderView.Nodes.Add(node);
            }
            return node;
        }

        public void AddPage(WebPage page, TreeNode folderView)
        {
            TreeNode node = new TreeNode(page.name);
            node.Tag = page;
            folderView.Nodes.Add(node);
        }

        public void AddResources(WebResource resource, TreeNode folderView)
        {
            TreeNode node = new TreeNode(resource.filename);
            node.Tag = resource;
            node.ForeColor = Color.Red;
            folderView.Nodes.Add(node);
        }

        private void siteTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

        }

        private void siteTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {

        }
    }

}
