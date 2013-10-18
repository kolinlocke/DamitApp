namespace Layer03_Desktop.UserControls
{
    partial class UcFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcFilter));
            this.Panel_Grid = new System.Windows.Forms.Panel();
            this.Grid_Filters = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.Panel_Filter = new System.Windows.Forms.Panel();
            this.Btn_ClearFilter = new Layer03_Desktop.UserControls.UcButton();
            this.Btn_AddFilter = new Layer03_Desktop.UserControls.UcButton();
            this.Cbo_Field = new System.Windows.Forms.ComboBox();
            this.Txt_Filter = new System.Windows.Forms.TextBox();
            this.Btn_NewFilter = new Layer03_Desktop.UserControls.UcButton();
            this.Panel_Grid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Filters)).BeginInit();
            this.Panel_Filter.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Grid
            // 
            this.Panel_Grid.Controls.Add(this.Grid_Filters);
            this.Panel_Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Grid.Location = new System.Drawing.Point(0, 45);
            this.Panel_Grid.Name = "Panel_Grid";
            this.Panel_Grid.Size = new System.Drawing.Size(350, 75);
            this.Panel_Grid.TabIndex = 2;
            // 
            // Grid_Filters
            // 
            this.Grid_Filters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid_Filters.Location = new System.Drawing.Point(0, 0);
            this.Grid_Filters.Name = "Grid_Filters";
            this.Grid_Filters.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.Grid_Filters.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.Grid_Filters.PreviewInfo.ZoomFactor = 75D;
            this.Grid_Filters.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("Grid_Filters.PrintInfo.PageSettings")));
            this.Grid_Filters.PropBag = resources.GetString("Grid_Filters.PropBag");
            this.Grid_Filters.Size = new System.Drawing.Size(350, 75);
            this.Grid_Filters.TabIndex = 1;
            this.Grid_Filters.Text = "c1TrueDBGrid1";
            // 
            // Panel_Filter
            // 
            this.Panel_Filter.Controls.Add(this.Btn_ClearFilter);
            this.Panel_Filter.Controls.Add(this.Btn_AddFilter);
            this.Panel_Filter.Controls.Add(this.Cbo_Field);
            this.Panel_Filter.Controls.Add(this.Txt_Filter);
            this.Panel_Filter.Controls.Add(this.Btn_NewFilter);
            this.Panel_Filter.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Filter.Location = new System.Drawing.Point(0, 0);
            this.Panel_Filter.Name = "Panel_Filter";
            this.Panel_Filter.Size = new System.Drawing.Size(350, 45);
            this.Panel_Filter.TabIndex = 1;
            // 
            // Btn_ClearFilter
            // 
            this.Btn_ClearFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_ClearFilter.Location = new System.Drawing.Point(269, 22);
            this.Btn_ClearFilter.Margin = new System.Windows.Forms.Padding(1);
            this.Btn_ClearFilter.Name = "Btn_ClearFilter";
            this.Btn_ClearFilter.Size = new System.Drawing.Size(80, 21);
            this.Btn_ClearFilter.TabIndex = 5;
            this.Btn_ClearFilter.Text = "Clear Filters";
            this.Btn_ClearFilter.UseVisualStyleBackColor = true;
            // 
            // Btn_AddFilter
            // 
            this.Btn_AddFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_AddFilter.Location = new System.Drawing.Point(220, 22);
            this.Btn_AddFilter.Margin = new System.Windows.Forms.Padding(1);
            this.Btn_AddFilter.Name = "Btn_AddFilter";
            this.Btn_AddFilter.Size = new System.Drawing.Size(50, 21);
            this.Btn_AddFilter.TabIndex = 4;
            this.Btn_AddFilter.Text = "Add";
            this.Btn_AddFilter.UseVisualStyleBackColor = true;
            // 
            // Cbo_Field
            // 
            this.Cbo_Field.FormattingEnabled = true;
            this.Cbo_Field.Location = new System.Drawing.Point(3, 2);
            this.Cbo_Field.Margin = new System.Windows.Forms.Padding(1);
            this.Cbo_Field.Name = "Cbo_Field";
            this.Cbo_Field.Size = new System.Drawing.Size(120, 21);
            this.Cbo_Field.TabIndex = 1;
            // 
            // Txt_Filter
            // 
            this.Txt_Filter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Filter.Location = new System.Drawing.Point(125, 2);
            this.Txt_Filter.Margin = new System.Windows.Forms.Padding(1);
            this.Txt_Filter.Name = "Txt_Filter";
            this.Txt_Filter.Size = new System.Drawing.Size(224, 20);
            this.Txt_Filter.TabIndex = 2;
            // 
            // Btn_NewFilter
            // 
            this.Btn_NewFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_NewFilter.Location = new System.Drawing.Point(171, 22);
            this.Btn_NewFilter.Margin = new System.Windows.Forms.Padding(1);
            this.Btn_NewFilter.Name = "Btn_NewFilter";
            this.Btn_NewFilter.Size = new System.Drawing.Size(50, 21);
            this.Btn_NewFilter.TabIndex = 3;
            this.Btn_NewFilter.Text = "New";
            this.Btn_NewFilter.UseVisualStyleBackColor = true;
            // 
            // UcFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.Panel_Grid);
            this.Controls.Add(this.Panel_Filter);
            this.MinimumSize = new System.Drawing.Size(250, 120);
            this.Name = "UcFilter";
            this.Size = new System.Drawing.Size(350, 120);
            this.Panel_Grid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Filters)).EndInit();
            this.Panel_Filter.ResumeLayout(false);
            this.Panel_Filter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Grid;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid Grid_Filters;
        private UcButton Btn_ClearFilter;
        private System.Windows.Forms.Panel Panel_Filter;
        private System.Windows.Forms.ComboBox Cbo_Field;
        private UcButton Btn_NewFilter;
        private System.Windows.Forms.TextBox Txt_Filter;
        private UcButton Btn_AddFilter;
    }
}
