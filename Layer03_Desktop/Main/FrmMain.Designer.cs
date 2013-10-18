namespace Layer03_Desktop.Main
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.Tv_Modules = new System.Windows.Forms.TreeView();
            this.ImageList_Modules = new System.Windows.Forms.ImageList(this.components);
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.Lbl_Mayari = new System.Windows.Forms.ToolStripStatusLabel();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.MnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFile_Logoff = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFile_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuTest = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuTest_Test = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // SplitContainer
            // 
            this.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer.Location = new System.Drawing.Point(0, 24);
            this.SplitContainer.Name = "SplitContainer";
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.Controls.Add(this.Tv_Modules);
            this.SplitContainer.Size = new System.Drawing.Size(984, 516);
            this.SplitContainer.SplitterDistance = 385;
            this.SplitContainer.TabIndex = 7;
            // 
            // Tv_Modules
            // 
            this.Tv_Modules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tv_Modules.ImageIndex = 0;
            this.Tv_Modules.ImageList = this.ImageList_Modules;
            this.Tv_Modules.Location = new System.Drawing.Point(0, 0);
            this.Tv_Modules.Name = "Tv_Modules";
            this.Tv_Modules.SelectedImageIndex = 0;
            this.Tv_Modules.Size = new System.Drawing.Size(385, 516);
            this.Tv_Modules.TabIndex = 1;
            // 
            // ImageList_Modules
            // 
            this.ImageList_Modules.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList_Modules.ImageStream")));
            this.ImageList_Modules.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList_Modules.Images.SetKeyName(0, "cp_DefaultDocument16x16.ico");
            this.ImageList_Modules.Images.SetKeyName(1, "File-Manager.ico");
            this.ImageList_Modules.Images.SetKeyName(2, "Lock.ico");
            this.ImageList_Modules.Images.SetKeyName(3, "MDI-Text-Editor.ico");
            this.ImageList_Modules.Images.SetKeyName(4, "Employee32.gif");
            this.ImageList_Modules.Images.SetKeyName(5, "Stuffit-48x48.png");
            this.ImageList_Modules.Images.SetKeyName(6, "Invoice32.gif");
            this.ImageList_Modules.Images.SetKeyName(7, "Search.ico");
            this.ImageList_Modules.Images.SetKeyName(8, "Stickies.ico");
            this.ImageList_Modules.Images.SetKeyName(9, "Home.png");
            this.ImageList_Modules.Images.SetKeyName(10, "Task-List.ico");
            this.ImageList_Modules.Images.SetKeyName(11, "Truck.png");
            this.ImageList_Modules.Images.SetKeyName(12, "safe.png");
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Lbl_Mayari});
            this.StatusStrip.Location = new System.Drawing.Point(0, 540);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(984, 22);
            this.StatusStrip.TabIndex = 8;
            this.StatusStrip.Text = "StatusStrip1";
            // 
            // Lbl_Mayari
            // 
            this.Lbl_Mayari.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Lbl_Mayari.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Lbl_Mayari.Name = "Lbl_Mayari";
            this.Lbl_Mayari.Size = new System.Drawing.Size(201, 17);
            this.Lbl_Mayari.Text = "May-Ari: [Ilagay ang May-Ari dito]";
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuFile,
            this.MnuAbout,
            this.MnuTest});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(984, 24);
            this.MenuStrip.TabIndex = 9;
            this.MenuStrip.Text = "MenuStrip1";
            // 
            // MnuFile
            // 
            this.MnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuFile_Logoff,
            this.MnuFile_Close});
            this.MnuFile.Name = "MnuFile";
            this.MnuFile.Size = new System.Drawing.Size(37, 20);
            this.MnuFile.Text = "&File";
            // 
            // MnuFile_Logoff
            // 
            this.MnuFile_Logoff.Name = "MnuFile_Logoff";
            this.MnuFile_Logoff.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.MnuFile_Logoff.Size = new System.Drawing.Size(219, 22);
            this.MnuFile_Logoff.Text = "Palitan ang May-Ari";
            // 
            // MnuFile_Close
            // 
            this.MnuFile_Close.Name = "MnuFile_Close";
            this.MnuFile_Close.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.MnuFile_Close.Size = new System.Drawing.Size(219, 22);
            this.MnuFile_Close.Text = "Isara ang Sistema";
            // 
            // MnuAbout
            // 
            this.MnuAbout.Name = "MnuAbout";
            this.MnuAbout.Size = new System.Drawing.Size(52, 20);
            this.MnuAbout.Text = "About";
            // 
            // MnuTest
            // 
            this.MnuTest.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuTest_Test});
            this.MnuTest.Name = "MnuTest";
            this.MnuTest.Size = new System.Drawing.Size(41, 20);
            this.MnuTest.Text = "Test";
            // 
            // MnuTest_Test
            // 
            this.MnuTest_Test.Name = "MnuTest_Test";
            this.MnuTest_Test.Size = new System.Drawing.Size(152, 22);
            this.MnuTest_Test.Text = "Test";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.SplitContainer);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.StatusStrip);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Damit";
            this.SplitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.SplitContainer SplitContainer;
        internal System.Windows.Forms.TreeView Tv_Modules;
        internal System.Windows.Forms.StatusStrip StatusStrip;
        internal System.Windows.Forms.ToolStripStatusLabel Lbl_Mayari;
        internal System.Windows.Forms.ImageList ImageList_Modules;
        internal System.Windows.Forms.MenuStrip MenuStrip;
        internal System.Windows.Forms.ToolStripMenuItem MnuFile;
        internal System.Windows.Forms.ToolStripMenuItem MnuFile_Logoff;
        internal System.Windows.Forms.ToolStripMenuItem MnuFile_Close;
        internal System.Windows.Forms.ToolStripMenuItem MnuAbout;
        internal System.Windows.Forms.ToolStripMenuItem MnuTest;
        internal System.Windows.Forms.ToolStripMenuItem MnuTest_Test;
    }
}