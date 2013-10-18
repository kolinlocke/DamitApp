namespace Layer03_Desktop.Base
{
    partial class FrmBaseList
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
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.Btn_New = new System.Windows.Forms.ToolStripButton();
            this.Btn_Open = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Btn_Tools = new System.Windows.Forms.ToolStripDropDownButton();
            this.Btn_Print = new System.Windows.Forms.ToolStripButton();
            this.Btn_Refresh = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Btn_Close = new System.Windows.Forms.ToolStripButton();
            this.MenuStrip_Shortcuts = new System.Windows.Forms.MenuStrip();
            this.MnuMain = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuMain_New = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuMain_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuMain_Print = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuMain_Refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuMain_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.Panel_Main = new System.Windows.Forms.Panel();
            this.Panel_Main2 = new System.Windows.Forms.Panel();
            this.SplitContainer_Main = new System.Windows.Forms.SplitContainer();
            this.Label_Filler = new System.Windows.Forms.Label();
            this.Lbl_Filter = new Layer03_Desktop.UserControls.UcLabel();
            this.Filter_List = new Layer03_Desktop.UserControls.UcFilter();
            this.Lbl_List = new Layer03_Desktop.UserControls.UcLabel();
            this.Grid_List = new Layer03_Desktop.UserControls.UcGrid();
            this.ToolStrip.SuspendLayout();
            this.MenuStrip_Shortcuts.SuspendLayout();
            this.Panel_Main.SuspendLayout();
            this.Panel_Main2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer_Main)).BeginInit();
            this.SplitContainer_Main.Panel1.SuspendLayout();
            this.SplitContainer_Main.Panel2.SuspendLayout();
            this.SplitContainer_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStrip
            // 
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_New,
            this.Btn_Open,
            this.ToolStripSeparator3,
            this.Btn_Tools,
            this.Btn_Print,
            this.Btn_Refresh,
            this.ToolStripSeparator2,
            this.Btn_Close});
            this.ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(784, 25);
            this.ToolStrip.TabIndex = 212;
            this.ToolStrip.Text = "ToolStrip1";
            // 
            // Btn_New
            // 
            this.Btn_New.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_New.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_New.Name = "Btn_New";
            this.Btn_New.Size = new System.Drawing.Size(35, 22);
            this.Btn_New.Text = "New";
            this.Btn_New.ToolTipText = "New (Ctrl+N)";
            // 
            // Btn_Open
            // 
            this.Btn_Open.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Open.Name = "Btn_Open";
            this.Btn_Open.Size = new System.Drawing.Size(40, 22);
            this.Btn_Open.Text = "Open";
            this.Btn_Open.ToolTipText = "Open (Ctrl+O)";
            // 
            // ToolStripSeparator3
            // 
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // Btn_Tools
            // 
            this.Btn_Tools.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Tools.Name = "Btn_Tools";
            this.Btn_Tools.Size = new System.Drawing.Size(49, 22);
            this.Btn_Tools.Text = "Tools";
            this.Btn_Tools.Visible = false;
            // 
            // Btn_Print
            // 
            this.Btn_Print.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Print.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Print.Name = "Btn_Print";
            this.Btn_Print.Size = new System.Drawing.Size(36, 22);
            this.Btn_Print.Text = "Print";
            this.Btn_Print.ToolTipText = "Print (Ctrl+P)";
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(50, 22);
            this.Btn_Refresh.Text = "Refresh";
            this.Btn_Refresh.ToolTipText = "Refresh (F5)";
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // Btn_Close
            // 
            this.Btn_Close.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(40, 22);
            this.Btn_Close.Text = "Close";
            this.Btn_Close.ToolTipText = "Close (Alt F4)";
            // 
            // MenuStrip_Shortcuts
            // 
            this.MenuStrip_Shortcuts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuMain});
            this.MenuStrip_Shortcuts.Location = new System.Drawing.Point(0, 25);
            this.MenuStrip_Shortcuts.Name = "MenuStrip_Shortcuts";
            this.MenuStrip_Shortcuts.Size = new System.Drawing.Size(784, 24);
            this.MenuStrip_Shortcuts.TabIndex = 215;
            this.MenuStrip_Shortcuts.Text = "MenuStrip1";
            this.MenuStrip_Shortcuts.Visible = false;
            // 
            // MnuMain
            // 
            this.MnuMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuMain_New,
            this.MnuMain_Open,
            this.MnuMain_Print,
            this.MnuMain_Refresh,
            this.ToolStripSeparator1,
            this.MnuMain_Close});
            this.MnuMain.Name = "MnuMain";
            this.MnuMain.Size = new System.Drawing.Size(46, 20);
            this.MnuMain.Text = "Main";
            // 
            // MnuMain_New
            // 
            this.MnuMain_New.Name = "MnuMain_New";
            this.MnuMain_New.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.MnuMain_New.Size = new System.Drawing.Size(146, 22);
            this.MnuMain_New.Text = "New";
            // 
            // MnuMain_Open
            // 
            this.MnuMain_Open.Name = "MnuMain_Open";
            this.MnuMain_Open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MnuMain_Open.Size = new System.Drawing.Size(146, 22);
            this.MnuMain_Open.Text = "Open";
            // 
            // MnuMain_Print
            // 
            this.MnuMain_Print.Name = "MnuMain_Print";
            this.MnuMain_Print.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.MnuMain_Print.Size = new System.Drawing.Size(146, 22);
            this.MnuMain_Print.Text = "Print";
            // 
            // MnuMain_Refresh
            // 
            this.MnuMain_Refresh.Name = "MnuMain_Refresh";
            this.MnuMain_Refresh.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.MnuMain_Refresh.Size = new System.Drawing.Size(146, 22);
            this.MnuMain_Refresh.Text = "Refresh";
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // MnuMain_Close
            // 
            this.MnuMain_Close.Name = "MnuMain_Close";
            this.MnuMain_Close.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.MnuMain_Close.Size = new System.Drawing.Size(146, 22);
            this.MnuMain_Close.Text = "Close";
            // 
            // StatusStrip
            // 
            this.StatusStrip.Location = new System.Drawing.Point(0, 540);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(784, 22);
            this.StatusStrip.TabIndex = 214;
            // 
            // Panel_Main
            // 
            this.Panel_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Main.AutoScroll = true;
            this.Panel_Main.Controls.Add(this.Panel_Main2);
            this.Panel_Main.Controls.Add(this.Label_Filler);
            this.Panel_Main.Location = new System.Drawing.Point(0, 28);
            this.Panel_Main.Name = "Panel_Main";
            this.Panel_Main.Size = new System.Drawing.Size(784, 509);
            this.Panel_Main.TabIndex = 216;
            // 
            // Panel_Main2
            // 
            this.Panel_Main2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Main2.AutoScroll = true;
            this.Panel_Main2.Controls.Add(this.SplitContainer_Main);
            this.Panel_Main2.Location = new System.Drawing.Point(0, 0);
            this.Panel_Main2.MinimumSize = new System.Drawing.Size(400, 509);
            this.Panel_Main2.Name = "Panel_Main2";
            this.Panel_Main2.Size = new System.Drawing.Size(784, 509);
            this.Panel_Main2.TabIndex = 3;
            // 
            // SplitContainer_Main
            // 
            this.SplitContainer_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.SplitContainer_Main.Location = new System.Drawing.Point(3, 3);
            this.SplitContainer_Main.Name = "SplitContainer_Main";
            this.SplitContainer_Main.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitContainer_Main.Panel1
            // 
            this.SplitContainer_Main.Panel1.Controls.Add(this.Lbl_Filter);
            this.SplitContainer_Main.Panel1.Controls.Add(this.Filter_List);
            // 
            // SplitContainer_Main.Panel2
            // 
            this.SplitContainer_Main.Panel2.Controls.Add(this.Lbl_List);
            this.SplitContainer_Main.Panel2.Controls.Add(this.Grid_List);
            this.SplitContainer_Main.Size = new System.Drawing.Size(778, 503);
            this.SplitContainer_Main.SplitterDistance = 150;
            this.SplitContainer_Main.TabIndex = 5;
            // 
            // Label_Filler
            // 
            this.Label_Filler.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label_Filler.Location = new System.Drawing.Point(0, 0);
            this.Label_Filler.Name = "Label_Filler";
            this.Label_Filler.Size = new System.Drawing.Size(400, 509);
            this.Label_Filler.TabIndex = 3;
            this.Label_Filler.Text = "Label Filler";
            // 
            // Lbl_Filter
            // 
            this.Lbl_Filter.AutoSize = true;
            this.Lbl_Filter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Filter.Location = new System.Drawing.Point(9, 5);
            this.Lbl_Filter.Name = "Lbl_Filter";
            this.Lbl_Filter.pStyle = null;
            this.Lbl_Filter.Size = new System.Drawing.Size(42, 13);
            this.Lbl_Filter.TabIndex = 1;
            this.Lbl_Filter.Text = "Filters";
            // 
            // Filter_List
            // 
            this.Filter_List.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Filter_List.AutoSize = true;
            this.Filter_List.Location = new System.Drawing.Point(3, 21);
            this.Filter_List.MinimumSize = new System.Drawing.Size(250, 120);
            this.Filter_List.Name = "Filter_List";
            this.Filter_List.pStyle = null;
            this.Filter_List.Size = new System.Drawing.Size(772, 126);
            this.Filter_List.TabIndex = 0;
            // 
            // Lbl_List
            // 
            this.Lbl_List.AutoSize = true;
            this.Lbl_List.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_List.Location = new System.Drawing.Point(9, 5);
            this.Lbl_List.Name = "Lbl_List";
            this.Lbl_List.pStyle = null;
            this.Lbl_List.Size = new System.Drawing.Size(27, 13);
            this.Lbl_List.TabIndex = 3;
            this.Lbl_List.Text = "List";
            // 
            // Grid_List
            // 
            this.Grid_List.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid_List.Location = new System.Drawing.Point(3, 21);
            this.Grid_List.MinimumSize = new System.Drawing.Size(320, 150);
            this.Grid_List.Name = "Grid_List";
            this.Grid_List.pStyle = null;
            this.Grid_List.Size = new System.Drawing.Size(772, 325);
            this.Grid_List.TabIndex = 2;
            // 
            // FrmBaseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.MenuStrip_Shortcuts);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.ToolStrip);
            this.Controls.Add(this.Panel_Main);
            this.Name = "FrmBaseList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBaseList";
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.MenuStrip_Shortcuts.ResumeLayout(false);
            this.MenuStrip_Shortcuts.PerformLayout();
            this.Panel_Main.ResumeLayout(false);
            this.Panel_Main2.ResumeLayout(false);
            this.SplitContainer_Main.Panel1.ResumeLayout(false);
            this.SplitContainer_Main.Panel1.PerformLayout();
            this.SplitContainer_Main.Panel2.ResumeLayout(false);
            this.SplitContainer_Main.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer_Main)).EndInit();
            this.SplitContainer_Main.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal System.Windows.Forms.ToolStrip ToolStrip;
        protected internal System.Windows.Forms.ToolStripButton Btn_New;
        protected internal System.Windows.Forms.ToolStripButton Btn_Open;
        protected internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator3;
        internal System.Windows.Forms.ToolStripDropDownButton Btn_Tools;
        protected internal System.Windows.Forms.ToolStripButton Btn_Print;
        protected internal System.Windows.Forms.ToolStripButton Btn_Refresh;
        protected internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        protected internal System.Windows.Forms.ToolStripButton Btn_Close;
        protected internal System.Windows.Forms.MenuStrip MenuStrip_Shortcuts;
        protected internal System.Windows.Forms.ToolStripMenuItem MnuMain;
        protected internal System.Windows.Forms.ToolStripMenuItem MnuMain_New;
        protected internal System.Windows.Forms.ToolStripMenuItem MnuMain_Open;
        protected internal System.Windows.Forms.ToolStripMenuItem MnuMain_Print;
        protected internal System.Windows.Forms.ToolStripMenuItem MnuMain_Refresh;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        protected internal System.Windows.Forms.ToolStripMenuItem MnuMain_Close;
        protected internal System.Windows.Forms.StatusStrip StatusStrip;
        protected internal System.Windows.Forms.Panel Panel_Main;
        protected internal System.Windows.Forms.Panel Panel_Main2;
        protected internal System.Windows.Forms.Label Label_Filler;
        private UserControls.UcGrid Grid_List;
        private System.Windows.Forms.SplitContainer SplitContainer_Main;
        private UserControls.UcFilter Filter_List;
        private UserControls.UcLabel Lbl_Filter;
        private UserControls.UcLabel Lbl_List;
    }
}