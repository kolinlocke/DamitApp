namespace Layer03_Desktop.UserControls
{
    partial class UcGrid
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcGrid));
            this.Panel_Grid = new System.Windows.Forms.Panel();
            this.Grid = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.Panel_Paging = new System.Windows.Forms.Panel();
            this.Lbl_PageDesc = new System.Windows.Forms.Label();
            this.Lbl_Top = new System.Windows.Forms.Label();
            this.Txt_Top = new System.Windows.Forms.TextBox();
            this.Lbl_Page = new System.Windows.Forms.Label();
            this.Btn_Last = new Layer03_Desktop.UserControls.UcButton();
            this.Btn_Next = new Layer03_Desktop.UserControls.UcButton();
            this.Cbo_Page = new Layer03_Desktop.UserControls.UcCombobox();
            this.Btn_First = new Layer03_Desktop.UserControls.UcButton();
            this.Btn_Previous = new Layer03_Desktop.UserControls.UcButton();
            this.Panel_Grid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.Panel_Paging.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Grid
            // 
            this.Panel_Grid.Controls.Add(this.Grid);
            this.Panel_Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Grid.Location = new System.Drawing.Point(0, 0);
            this.Panel_Grid.Margin = new System.Windows.Forms.Padding(1);
            this.Panel_Grid.Name = "Panel_Grid";
            this.Panel_Grid.Size = new System.Drawing.Size(320, 150);
            this.Panel_Grid.TabIndex = 0;
            // 
            // Grid
            // 
            this.Grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid.Location = new System.Drawing.Point(0, 0);
            this.Grid.Name = "Grid";
            this.Grid.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.Grid.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.Grid.PreviewInfo.ZoomFactor = 75D;
            this.Grid.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("Grid.PrintInfo.PageSettings")));
            this.Grid.PropBag = resources.GetString("Grid.PropBag");
            this.Grid.Size = new System.Drawing.Size(320, 150);
            this.Grid.TabIndex = 1;
            this.Grid.Text = "c1TrueDBGrid1";
            // 
            // Panel_Paging
            // 
            this.Panel_Paging.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Paging.Controls.Add(this.Lbl_PageDesc);
            this.Panel_Paging.Controls.Add(this.Lbl_Top);
            this.Panel_Paging.Controls.Add(this.Txt_Top);
            this.Panel_Paging.Controls.Add(this.Lbl_Page);
            this.Panel_Paging.Controls.Add(this.Btn_Last);
            this.Panel_Paging.Controls.Add(this.Btn_Next);
            this.Panel_Paging.Controls.Add(this.Cbo_Page);
            this.Panel_Paging.Controls.Add(this.Btn_First);
            this.Panel_Paging.Controls.Add(this.Btn_Previous);
            this.Panel_Paging.Location = new System.Drawing.Point(0, 100);
            this.Panel_Paging.Margin = new System.Windows.Forms.Padding(1);
            this.Panel_Paging.Name = "Panel_Paging";
            this.Panel_Paging.Size = new System.Drawing.Size(320, 50);
            this.Panel_Paging.TabIndex = 1;
            // 
            // Lbl_PageDesc
            // 
            this.Lbl_PageDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_PageDesc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Lbl_PageDesc.Location = new System.Drawing.Point(147, 3);
            this.Lbl_PageDesc.Name = "Lbl_PageDesc";
            this.Lbl_PageDesc.Size = new System.Drawing.Size(170, 22);
            this.Lbl_PageDesc.TabIndex = 8;
            this.Lbl_PageDesc.Text = "[Lbl_PageDesc]";
            this.Lbl_PageDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lbl_Top
            // 
            this.Lbl_Top.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_Top.AutoSize = true;
            this.Lbl_Top.Location = new System.Drawing.Point(3, 6);
            this.Lbl_Top.Name = "Lbl_Top";
            this.Lbl_Top.Size = new System.Drawing.Size(26, 13);
            this.Lbl_Top.TabIndex = 7;
            this.Lbl_Top.Text = "Top";
            // 
            // Txt_Top
            // 
            this.Txt_Top.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Txt_Top.Location = new System.Drawing.Point(41, 3);
            this.Txt_Top.Name = "Txt_Top";
            this.Txt_Top.Size = new System.Drawing.Size(100, 20);
            this.Txt_Top.TabIndex = 1;
            // 
            // Lbl_Page
            // 
            this.Lbl_Page.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_Page.AutoSize = true;
            this.Lbl_Page.Location = new System.Drawing.Point(3, 29);
            this.Lbl_Page.Name = "Lbl_Page";
            this.Lbl_Page.Size = new System.Drawing.Size(32, 13);
            this.Lbl_Page.TabIndex = 5;
            this.Lbl_Page.Text = "Page";
            // 
            // Btn_Last
            // 
            this.Btn_Last.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Last.Location = new System.Drawing.Point(277, 26);
            this.Btn_Last.Margin = new System.Windows.Forms.Padding(1);
            this.Btn_Last.Name = "Btn_Last";
            this.Btn_Last.Size = new System.Drawing.Size(40, 21);
            this.Btn_Last.TabIndex = 6;
            this.Btn_Last.Text = ">>";
            this.Btn_Last.UseVisualStyleBackColor = true;
            // 
            // Btn_Next
            // 
            this.Btn_Next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Next.Location = new System.Drawing.Point(238, 26);
            this.Btn_Next.Margin = new System.Windows.Forms.Padding(1);
            this.Btn_Next.Name = "Btn_Next";
            this.Btn_Next.Size = new System.Drawing.Size(40, 21);
            this.Btn_Next.TabIndex = 5;
            this.Btn_Next.Text = ">";
            this.Btn_Next.UseVisualStyleBackColor = true;
            // 
            // Cbo_Page
            // 
            this.Cbo_Page.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Cbo_Page.FormattingEnabled = true;
            this.Cbo_Page.Location = new System.Drawing.Point(41, 26);
            this.Cbo_Page.Name = "Cbo_Page";
            this.Cbo_Page.Size = new System.Drawing.Size(100, 21);
            this.Cbo_Page.TabIndex = 2;
            // 
            // Btn_First
            // 
            this.Btn_First.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_First.Location = new System.Drawing.Point(160, 26);
            this.Btn_First.Margin = new System.Windows.Forms.Padding(1);
            this.Btn_First.Name = "Btn_First";
            this.Btn_First.Size = new System.Drawing.Size(40, 21);
            this.Btn_First.TabIndex = 3;
            this.Btn_First.Text = "<<";
            this.Btn_First.UseVisualStyleBackColor = true;
            // 
            // Btn_Previous
            // 
            this.Btn_Previous.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Previous.Location = new System.Drawing.Point(199, 26);
            this.Btn_Previous.Margin = new System.Windows.Forms.Padding(1);
            this.Btn_Previous.Name = "Btn_Previous";
            this.Btn_Previous.Size = new System.Drawing.Size(40, 21);
            this.Btn_Previous.TabIndex = 4;
            this.Btn_Previous.Text = "<";
            this.Btn_Previous.UseVisualStyleBackColor = true;
            // 
            // UcGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel_Grid);
            this.Controls.Add(this.Panel_Paging);
            this.MinimumSize = new System.Drawing.Size(320, 150);
            this.Name = "UcGrid";
            this.Size = new System.Drawing.Size(320, 150);
            this.Panel_Grid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.Panel_Paging.ResumeLayout(false);
            this.Panel_Paging.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Grid;
        private System.Windows.Forms.Panel Panel_Paging;
        private UcButton Btn_Last;
        private UcButton Btn_Next;
        private UcCombobox Cbo_Page;
        private UcButton Btn_First;
        private UcButton Btn_Previous;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid Grid;
        private System.Windows.Forms.Label Lbl_Top;
        private System.Windows.Forms.TextBox Txt_Top;
        private System.Windows.Forms.Label Lbl_Page;
        private System.Windows.Forms.Label Lbl_PageDesc;
    }
}
