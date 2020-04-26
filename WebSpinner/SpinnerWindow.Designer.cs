namespace WebSpinner
{
    partial class SpinnerWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpinnerWindow));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.newFolderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.websiteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editWebsiteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildWebsiteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publishWebsiteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutHelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.openFileButton = new System.Windows.Forms.ToolStripButton();
            this.saveFileButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.newPageButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.siteTreeView = new System.Windows.Forms.TreeView();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.pageMenuItem,
            this.websiteMenuItem,
            this.helpMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileMenuItem,
            this.openFileMenuItem,
            this.toolStripSeparator,
            this.saveFileMenuItem,
            this.saveAsFileMenuItem,
            this.toolStripSeparator1,
            this.exitFileMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileMenuItem.Text = "&File";
            // 
            // newFileMenuItem
            // 
            this.newFileMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.newFileMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newFileMenuItem.Image")));
            this.newFileMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newFileMenuItem.Name = "newFileMenuItem";
            this.newFileMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newFileMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newFileMenuItem.Text = "&New";
            this.newFileMenuItem.Click += new System.EventHandler(this.newFileMenuItem_Click);
            // 
            // openFileMenuItem
            // 
            this.openFileMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.openFileMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openFileMenuItem.Image")));
            this.openFileMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openFileMenuItem.Name = "openFileMenuItem";
            this.openFileMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFileMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openFileMenuItem.Text = "&Open";
            this.openFileMenuItem.Click += new System.EventHandler(this.openFileMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // saveFileMenuItem
            // 
            this.saveFileMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.saveFileMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveFileMenuItem.Image")));
            this.saveFileMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveFileMenuItem.Name = "saveFileMenuItem";
            this.saveFileMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveFileMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveFileMenuItem.Text = "&Save";
            this.saveFileMenuItem.Click += new System.EventHandler(this.saveFileMenuItem_Click);
            // 
            // saveAsFileMenuItem
            // 
            this.saveAsFileMenuItem.Name = "saveAsFileMenuItem";
            this.saveAsFileMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsFileMenuItem.Text = "Save &As";
            this.saveAsFileMenuItem.Click += new System.EventHandler(this.saveAsFileMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // exitFileMenuItem
            // 
            this.exitFileMenuItem.Name = "exitFileMenuItem";
            this.exitFileMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitFileMenuItem.Text = "E&xit";
            this.exitFileMenuItem.Click += new System.EventHandler(this.exitFileMenuItem_Click);
            // 
            // pageMenuItem
            // 
            this.pageMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.pageMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPageMenuItem,
            this.editPageMenuItem,
            this.deletePageMenuItem,
            this.toolStripSeparator4,
            this.newFolderMenuItem});
            this.pageMenuItem.Name = "pageMenuItem";
            this.pageMenuItem.Size = new System.Drawing.Size(45, 20);
            this.pageMenuItem.Text = "&Page";
            // 
            // newPageMenuItem
            // 
            this.newPageMenuItem.Name = "newPageMenuItem";
            this.newPageMenuItem.Size = new System.Drawing.Size(134, 22);
            this.newPageMenuItem.Text = "&New";
            this.newPageMenuItem.Click += new System.EventHandler(this.newPageMenuItem_Click);
            // 
            // editPageMenuItem
            // 
            this.editPageMenuItem.Name = "editPageMenuItem";
            this.editPageMenuItem.Size = new System.Drawing.Size(134, 22);
            this.editPageMenuItem.Text = "&Edit";
            this.editPageMenuItem.Click += new System.EventHandler(this.editPageMenuItem_Click);
            // 
            // deletePageMenuItem
            // 
            this.deletePageMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.deletePageMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deletePageMenuItem.Image")));
            this.deletePageMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deletePageMenuItem.Name = "deletePageMenuItem";
            this.deletePageMenuItem.Size = new System.Drawing.Size(134, 22);
            this.deletePageMenuItem.Text = "&Delete";
            this.deletePageMenuItem.Click += new System.EventHandler(this.deletePageMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(131, 6);
            // 
            // newFolderMenuItem
            // 
            this.newFolderMenuItem.Name = "newFolderMenuItem";
            this.newFolderMenuItem.Size = new System.Drawing.Size(134, 22);
            this.newFolderMenuItem.Text = "New &Folder";
            this.newFolderMenuItem.Click += new System.EventHandler(this.newFolderMenuItem_Click);
            // 
            // websiteMenuItem
            // 
            this.websiteMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editWebsiteMenuItem,
            this.buildWebsiteMenuItem,
            this.publishWebsiteMenuItem});
            this.websiteMenuItem.Name = "websiteMenuItem";
            this.websiteMenuItem.Size = new System.Drawing.Size(61, 20);
            this.websiteMenuItem.Text = "&Website";
            // 
            // editWebsiteMenuItem
            // 
            this.editWebsiteMenuItem.Name = "editWebsiteMenuItem";
            this.editWebsiteMenuItem.Size = new System.Drawing.Size(113, 22);
            this.editWebsiteMenuItem.Text = "&Edit";
            this.editWebsiteMenuItem.Click += new System.EventHandler(this.editWebsiteMenuItem_Click);
            // 
            // buildWebsiteMenuItem
            // 
            this.buildWebsiteMenuItem.Name = "buildWebsiteMenuItem";
            this.buildWebsiteMenuItem.Size = new System.Drawing.Size(113, 22);
            this.buildWebsiteMenuItem.Text = "&Build";
            this.buildWebsiteMenuItem.Click += new System.EventHandler(this.buildWebsiteMenuItem_Click);
            // 
            // publishWebsiteMenuItem
            // 
            this.publishWebsiteMenuItem.Name = "publishWebsiteMenuItem";
            this.publishWebsiteMenuItem.Size = new System.Drawing.Size(113, 22);
            this.publishWebsiteMenuItem.Text = "&Publish";
            this.publishWebsiteMenuItem.Click += new System.EventHandler(this.publishWebsiteMenuItem_Click);
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutHelpMenuItem});
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpMenuItem.Text = "&Help";
            // 
            // aboutHelpMenuItem
            // 
            this.aboutHelpMenuItem.Name = "aboutHelpMenuItem";
            this.aboutHelpMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutHelpMenuItem.Text = "&About...";
            this.aboutHelpMenuItem.Click += new System.EventHandler(this.aboutHelpMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileButton,
            this.saveFileButton,
            this.toolStripSeparator6,
            this.newPageButton,
            this.toolStripSeparator7});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // openFileButton
            // 
            this.openFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openFileButton.Image = ((System.Drawing.Image)(resources.GetObject("openFileButton.Image")));
            this.openFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(23, 22);
            this.openFileButton.Text = "&Open";
            this.openFileButton.ToolTipText = "Open File";
            this.openFileButton.Click += new System.EventHandler(this.openFileMenuItem_Click);
            // 
            // saveFileButton
            // 
            this.saveFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveFileButton.Image = ((System.Drawing.Image)(resources.GetObject("saveFileButton.Image")));
            this.saveFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(23, 22);
            this.saveFileButton.Text = "&Save";
            this.saveFileButton.ToolTipText = "Save File";
            this.saveFileButton.Click += new System.EventHandler(this.saveFileMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // newPageButton
            // 
            this.newPageButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newPageButton.Image = ((System.Drawing.Image)(resources.GetObject("newPageButton.Image")));
            this.newPageButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newPageButton.Name = "newPageButton";
            this.newPageButton.Size = new System.Drawing.Size(23, 22);
            this.newPageButton.Text = "&New";
            this.newPageButton.ToolTipText = "New Page";
            this.newPageButton.Click += new System.EventHandler(this.newPageMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // siteTreeView
            // 
            this.siteTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siteTreeView.Location = new System.Drawing.Point(0, 49);
            this.siteTreeView.Name = "siteTreeView";
            this.siteTreeView.Size = new System.Drawing.Size(800, 379);
            this.siteTreeView.TabIndex = 3;
            this.siteTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.siteTreeView_NodeMouseClick);
            this.siteTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.siteTreeView_NodeMouseDoubleClick);
            // 
            // SpinnerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.siteTreeView);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SpinnerWindow";
            this.Text = "WebSpinner";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsFileMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pageMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPageMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPageMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletePageMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem newFolderMenuItem;
        private System.Windows.Forms.ToolStripMenuItem websiteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editWebsiteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildWebsiteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutHelpMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newPageButton;
        private System.Windows.Forms.ToolStripButton openFileButton;
        private System.Windows.Forms.ToolStripButton saveFileButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.TreeView siteTreeView;
        private System.Windows.Forms.ToolStripMenuItem publishWebsiteMenuItem;
    }
}

