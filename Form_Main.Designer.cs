namespace Interpret_Interface
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.Main_Status = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Button_NewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.Button_OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.Open_FromFile = new System.Windows.Forms.ToolStripMenuItem();
            this.Open_FromDevice = new System.Windows.Forms.ToolStripMenuItem();
            this.Button_SaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.Save_ToFile = new System.Windows.Forms.ToolStripMenuItem();
            this.Save_ToDevice = new System.Windows.Forms.ToolStripMenuItem();
            this.Button_CloseFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Button_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Main_MenuStrip = new System.Windows.Forms.MenuStrip();
            this.Main_Status.SuspendLayout();
            this.Main_MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_Status
            // 
            this.Main_Status.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Main_Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.Main_Status.Location = new System.Drawing.Point(0, 665);
            this.Main_Status.Name = "Main_Status";
            this.Main_Status.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.Main_Status.Size = new System.Drawing.Size(948, 32);
            this.Main_Status.TabIndex = 2;
            this.Main_Status.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(60, 25);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Button_NewFile,
            this.Button_OpenFile,
            this.Button_SaveFile,
            this.Button_CloseFile,
            this.toolStripSeparator3,
            this.Button_Exit});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(54, 29);
            this.fileMenu.Text = "&File";
            // 
            // Button_NewFile
            // 
            this.Button_NewFile.Image = ((System.Drawing.Image)(resources.GetObject("Button_NewFile.Image")));
            this.Button_NewFile.ImageTransparentColor = System.Drawing.Color.Black;
            this.Button_NewFile.Name = "Button_NewFile";
            this.Button_NewFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.Button_NewFile.Size = new System.Drawing.Size(270, 34);
            this.Button_NewFile.Text = "&New";
            this.Button_NewFile.Click += new System.EventHandler(this.NewFile_Click);
            // 
            // Button_OpenFile
            // 
            this.Button_OpenFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Open_FromFile,
            this.Open_FromDevice});
            this.Button_OpenFile.Image = ((System.Drawing.Image)(resources.GetObject("Button_OpenFile.Image")));
            this.Button_OpenFile.ImageTransparentColor = System.Drawing.Color.Black;
            this.Button_OpenFile.Name = "Button_OpenFile";
            this.Button_OpenFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.Button_OpenFile.Size = new System.Drawing.Size(270, 34);
            this.Button_OpenFile.Text = "&Open";
            // 
            // Open_FromFile
            // 
            this.Open_FromFile.Name = "Open_FromFile";
            this.Open_FromFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.Open_FromFile.Size = new System.Drawing.Size(270, 34);
            this.Open_FromFile.Text = "From File...";
            this.Open_FromFile.Click += new System.EventHandler(this.Open_FromFile_Click);
            // 
            // Open_FromDevice
            // 
            this.Open_FromDevice.Name = "Open_FromDevice";
            this.Open_FromDevice.Size = new System.Drawing.Size(225, 34);
            this.Open_FromDevice.Text = "From Device...";
            // 
            // Button_SaveFile
            // 
            this.Button_SaveFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Save_ToFile,
            this.Save_ToDevice});
            this.Button_SaveFile.Image = ((System.Drawing.Image)(resources.GetObject("Button_SaveFile.Image")));
            this.Button_SaveFile.ImageTransparentColor = System.Drawing.Color.Black;
            this.Button_SaveFile.Name = "Button_SaveFile";
            this.Button_SaveFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.Button_SaveFile.Size = new System.Drawing.Size(270, 34);
            this.Button_SaveFile.Text = "&Save";
            // 
            // Save_ToFile
            // 
            this.Save_ToFile.Name = "Save_ToFile";
            this.Save_ToFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.Save_ToFile.Size = new System.Drawing.Size(270, 34);
            this.Save_ToFile.Text = "To File...";
            this.Save_ToFile.Click += new System.EventHandler(this.Save_ToFile_Click);
            // 
            // Save_ToDevice
            // 
            this.Save_ToDevice.Name = "Save_ToDevice";
            this.Save_ToDevice.Size = new System.Drawing.Size(201, 34);
            this.Save_ToDevice.Text = "To Device...";
            // 
            // Button_CloseFile
            // 
            this.Button_CloseFile.Name = "Button_CloseFile";
            this.Button_CloseFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.Button_CloseFile.Size = new System.Drawing.Size(225, 34);
            this.Button_CloseFile.Text = "Close";
            this.Button_CloseFile.Click += new System.EventHandler(this.CloseFile_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(222, 6);
            // 
            // Button_Exit
            // 
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(225, 34);
            this.Button_Exit.Text = "E&xit";
            this.Button_Exit.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator7,
            this.selectAllToolStripMenuItem});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(58, 29);
            this.editMenu.Text = "&Edit";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.cutToolStripMenuItem.Text = "Cu&t";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.copyToolStripMenuItem.Text = "&Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.pasteToolStripMenuItem.Text = "&Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(267, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // viewMenu
            // 
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(65, 29);
            this.viewMenu.Text = "&View";
            // 
            // toolsMenu
            // 
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(69, 29);
            this.toolsMenu.Text = "&Tools";
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWindowToolStripMenuItem,
            this.cascadeToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.closeAllToolStripMenuItem,
            this.arrangeIconsToolStripMenuItem});
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(102, 29);
            this.windowsMenu.Text = "&Windows";
            // 
            // newWindowToolStripMenuItem
            // 
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(227, 34);
            this.newWindowToolStripMenuItem.Text = "&New Window";
            this.newWindowToolStripMenuItem.Click += new System.EventHandler(this.NewFile_Click);
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(227, 34);
            this.cascadeToolStripMenuItem.Text = "&Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(227, 34);
            this.tileVerticalToolStripMenuItem.Text = "Tile &Vertical";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.TileVerticalToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(227, 34);
            this.tileHorizontalToolStripMenuItem.Text = "Tile &Horizontal";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(227, 34);
            this.closeAllToolStripMenuItem.Text = "C&lose All";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // arrangeIconsToolStripMenuItem
            // 
            this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            this.arrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(227, 34);
            this.arrangeIconsToolStripMenuItem.Text = "&Arrange Icons";
            this.arrangeIconsToolStripMenuItem.Click += new System.EventHandler(this.ArrangeIconsToolStripMenuItem_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(65, 29);
            this.helpMenu.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(198, 34);
            this.aboutToolStripMenuItem.Text = "&About ... ...";
            // 
            // Main_MenuStrip
            // 
            this.Main_MenuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.Main_MenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Main_MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.viewMenu,
            this.toolsMenu,
            this.windowsMenu,
            this.helpMenu});
            this.Main_MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.Main_MenuStrip.MdiWindowListItem = this.windowsMenu;
            this.Main_MenuStrip.Name = "Main_MenuStrip";
            this.Main_MenuStrip.Size = new System.Drawing.Size(948, 33);
            this.Main_MenuStrip.TabIndex = 0;
            this.Main_MenuStrip.Text = "MenuStrip";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 697);
            this.Controls.Add(this.Main_Status);
            this.Controls.Add(this.Main_MenuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.Main_MenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_Main";
            this.Text = "inReach Interpret";
            this.Main_Status.ResumeLayout(false);
            this.Main_Status.PerformLayout();
            this.Main_MenuStrip.ResumeLayout(false);
            this.Main_MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.StatusStrip Main_Status;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem Button_NewFile;
        private System.Windows.Forms.ToolStripMenuItem Button_OpenFile;
        private System.Windows.Forms.ToolStripMenuItem Button_SaveFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem Button_Exit;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip Main_MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem Button_CloseFile;
        private System.Windows.Forms.ToolStripMenuItem Open_FromFile;
        private System.Windows.Forms.ToolStripMenuItem Open_FromDevice;
        private System.Windows.Forms.ToolStripMenuItem Save_ToFile;
        private System.Windows.Forms.ToolStripMenuItem Save_ToDevice;
    }
}



