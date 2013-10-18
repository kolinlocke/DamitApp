namespace Layer03_Desktop.UserControls
{
    partial class UcToolStripDetailItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcToolStripDetailItem));
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.Btn_Add = new System.Windows.Forms.ToolStripButton();
            this.Btn_Import = new System.Windows.Forms.ToolStripButton();
            this.Btn_ExcelImport = new System.Windows.Forms.ToolStripButton();
            this.Btn_ExcelExport = new System.Windows.Forms.ToolStripButton();
            this.ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStrip
            // 
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_Add,
            this.Btn_Import,
            this.Btn_ExcelImport,
            this.Btn_ExcelExport});
            this.ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(500, 25);
            this.ToolStrip.TabIndex = 0;
            this.ToolStrip.Text = "toolStrip1";
            // 
            // Btn_Add
            // 
            this.Btn_Add.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Add.Image")));
            this.Btn_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(49, 22);
            this.Btn_Add.Text = "Add";
            // 
            // Btn_Import
            // 
            this.Btn_Import.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Import.Image")));
            this.Btn_Import.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Import.Name = "Btn_Import";
            this.Btn_Import.Size = new System.Drawing.Size(137, 22);
            this.Btn_Import.Text = "Import from Records";
            // 
            // Btn_ExcelImport
            // 
            this.Btn_ExcelImport.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ExcelImport.Image")));
            this.Btn_ExcelImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_ExcelImport.Name = "Btn_ExcelImport";
            this.Btn_ExcelImport.Size = new System.Drawing.Size(121, 22);
            this.Btn_ExcelImport.Text = "Import from Excel";
            // 
            // Btn_ExcelExport
            // 
            this.Btn_ExcelExport.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ExcelExport.Image")));
            this.Btn_ExcelExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_ExcelExport.Name = "Btn_ExcelExport";
            this.Btn_ExcelExport.Size = new System.Drawing.Size(103, 22);
            this.Btn_ExcelExport.Text = "Export to Excel";
            // 
            // UcToolStripDetailItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.ToolStrip);
            this.MinimumSize = new System.Drawing.Size(100, 25);
            this.Name = "UcToolStripDetailItem";
            this.Size = new System.Drawing.Size(500, 25);
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ToolStrip;
        public System.Windows.Forms.ToolStripButton Btn_Add;
        public System.Windows.Forms.ToolStripButton Btn_Import;
        public System.Windows.Forms.ToolStripButton Btn_ExcelImport;
        public System.Windows.Forms.ToolStripButton Btn_ExcelExport;
    }
}
