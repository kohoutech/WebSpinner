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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpinnerWindow));
            this.spinnerStatus = new System.Windows.Forms.StatusStrip();
            this.spinnerMenu = new System.Windows.Forms.MenuStrip();
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
            this.spinnerToolBar = new System.Windows.Forms.ToolStrip();
            this.openFileButton = new System.Windows.Forms.ToolStripButton();
            this.saveFileButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.newPageButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.siteTree = new WebSpinner.SiteView.WebSiteTree();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.spinnerMenu.SuspendLayout();
            this.spinnerToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // spinnerStatus
            // 
            this.spinnerStatus.Location = new System.Drawing.Point(0, 428);
            this.spinnerStatus.Name = "spinnerStatus";
            this.spinnerStatus.Size = new System.Drawing.Size(800, 22);
            this.spinnerStatus.TabIndex = 0;
            this.spinnerStatus.Text = "statusStrip1";
            // 
            // spinnerMenu
            // 
            this.spinnerMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.pageMenuItem,
            this.websiteMenuItem,
            this.helpMenuItem});
            this.spinnerMenu.Location = new System.Drawing.Point(0, 0);
            this.spinnerMenu.Name = "spinnerMenu";
            this.spinnerMenu.Size = new System.Drawing.Size(800, 24);
            this.spinnerMenu.TabIndex = 1;
            this.spinnerMenu.Text = "menuStrip1";
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
            this.newFileMenuItem.Size = new System.Drawing.Size(191, 22);
            this.newFileMenuItem.Text = "&New Website";
            this.newFileMenuItem.Click += new System.EventHandler(this.newFileMenuItem_Click);
            // 
            // openFileMenuItem
            // 
            this.openFileMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.openFileMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openFileMenuItem.Image")));
            this.openFileMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openFileMenuItem.Name = "openFileMenuItem";
            this.openFileMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFileMenuItem.Size = new System.Drawing.Size(191, 22);
            this.openFileMenuItem.Text = "&Open Website";
            this.openFileMenuItem.Click += new System.EventHandler(this.openFileMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(188, 6);
            // 
            // saveFileMenuItem
            // 
            this.saveFileMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.saveFileMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveFileMenuItem.Image")));
            this.saveFileMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveFileMenuItem.Name = "saveFileMenuItem";
            this.saveFileMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveFileMenuItem.Size = new System.Drawing.Size(191, 22);
            this.saveFileMenuItem.Text = "&Save Website";
            this.saveFileMenuItem.Click += new System.EventHandler(this.saveFileMenuItem_Click);
            // 
            // saveAsFileMenuItem
            // 
            this.saveAsFileMenuItem.Name = "saveAsFileMenuItem";
            this.saveAsFileMenuItem.Size = new System.Drawing.Size(191, 22);
            this.saveAsFileMenuItem.Text = "Save Website &As";
            this.saveAsFileMenuItem.Click += new System.EventHandler(this.saveAsFileMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(188, 6);
            // 
            // exitFileMenuItem
            // 
            this.exitFileMenuItem.Name = "exitFileMenuItem";
            this.exitFileMenuItem.Size = new System.Drawing.Size(191, 22);
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
            this.newPageMenuItem.Size = new System.Drawing.Size(136, 22);
            this.newPageMenuItem.Text = "&New Page";
            this.newPageMenuItem.Click += new System.EventHandler(this.newPageMenuItem_Click);
            // 
            // editPageMenuItem
            // 
            this.editPageMenuItem.Name = "editPageMenuItem";
            this.editPageMenuItem.Size = new System.Drawing.Size(136, 22);
            this.editPageMenuItem.Text = "&Edit Page";
            this.editPageMenuItem.Click += new System.EventHandler(this.editPageMenuItem_Click);
            // 
            // deletePageMenuItem
            // 
            this.deletePageMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.deletePageMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deletePageMenuItem.Image")));
            this.deletePageMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deletePageMenuItem.Name = "deletePageMenuItem";
            this.deletePageMenuItem.Size = new System.Drawing.Size(136, 22);
            this.deletePageMenuItem.Text = "&Delete Page";
            this.deletePageMenuItem.Click += new System.EventHandler(this.deletePageMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(133, 6);
            // 
            // newFolderMenuItem
            // 
            this.newFolderMenuItem.Name = "newFolderMenuItem";
            this.newFolderMenuItem.Size = new System.Drawing.Size(136, 22);
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
            this.editWebsiteMenuItem.Size = new System.Drawing.Size(158, 22);
            this.editWebsiteMenuItem.Text = "&Edit Website";
            this.editWebsiteMenuItem.Click += new System.EventHandler(this.editWebsiteMenuItem_Click);
            // 
            // buildWebsiteMenuItem
            // 
            this.buildWebsiteMenuItem.Name = "buildWebsiteMenuItem";
            this.buildWebsiteMenuItem.Size = new System.Drawing.Size(158, 22);
            this.buildWebsiteMenuItem.Text = "&Build Website";
            this.buildWebsiteMenuItem.Click += new System.EventHandler(this.buildWebsiteMenuItem_Click);
            // 
            // publishWebsiteMenuItem
            // 
            this.publishWebsiteMenuItem.Name = "publishWebsiteMenuItem";
            this.publishWebsiteMenuItem.Size = new System.Drawing.Size(158, 22);
            this.publishWebsiteMenuItem.Text = "&Publish Website";
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
            // spinnerToolBar
            // 
            this.spinnerToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileButton,
            this.saveFileButton,
            this.toolStripSeparator6,
            this.newPageButton,
            this.toolStripSeparator7,
            this.toolStripButton1,
            this.toolStripButton2});
            this.spinnerToolBar.Location = new System.Drawing.Point(0, 24);
            this.spinnerToolBar.Name = "spinnerToolBar";
            this.spinnerToolBar.Size = new System.Drawing.Size(800, 25);
            this.spinnerToolBar.TabIndex = 2;
            this.spinnerToolBar.Text = "toolStrip1";
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
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(38, 22);
            this.toolStripButton1.Text = "Build";
            this.toolStripButton1.Click += new System.EventHandler(this.buildWebsiteMenuItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(50, 22);
            this.toolStripButton2.Text = "Publish";
            this.toolStripButton2.Click += new System.EventHandler(this.publishWebsiteMenuItem_Click);
            // 
            // siteTree
            // 
            this.siteTree.BackColor = System.Drawing.Color.WhiteSmoke;
            this.siteTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siteTree.ImageIndex = 0;
            this.siteTree.ImageList = this.imageList;
            this.siteTree.ItemHeight = 24;
            this.siteTree.Location = new System.Drawing.Point(0, 49);
            this.siteTree.Name = "siteTree";
            this.siteTree.SelectedImageIndex = 0;
            this.siteTree.ShowRootLines = false;
            this.siteTree.Size = new System.Drawing.Size(800, 379);
            this.siteTree.TabIndex = 3;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "siteicon.png");
            this.imageList.Images.SetKeyName(1, "foldericon.png");
            this.imageList.Images.SetKeyName(2, "pageicon.png");
            this.imageList.Images.SetKeyName(3, "resicon.png");
            // 
            // SpinnerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.siteTree);
            this.Controls.Add(this.spinnerToolBar);
            this.Controls.Add(this.spinnerStatus);
            this.Controls.Add(this.spinnerMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.spinnerMenu;
            this.Name = "SpinnerWindow";
            this.Text = "WebSpinner";
            this.spinnerMenu.ResumeLayout(false);
            this.spinnerMenu.PerformLayout();
            this.spinnerToolBar.ResumeLayout(false);
            this.spinnerToolBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip spinnerStatus;
        private System.Windows.Forms.MenuStrip spinnerMenu;
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
        private System.Windows.Forms.ToolStrip spinnerToolBar;
        private System.Windows.Forms.ToolStripButton newPageButton;
        private System.Windows.Forms.ToolStripButton openFileButton;
        private System.Windows.Forms.ToolStripButton saveFileButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem publishWebsiteMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        public WebSpinner.SiteView.WebSiteTree siteTree;
        private System.Windows.Forms.ImageList imageList;
    }
}

