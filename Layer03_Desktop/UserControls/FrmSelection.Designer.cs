namespace Layer03_Desktop.UserControls
{
    partial class FrmSelection
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
            this.Grid_Selection = new Layer03_Desktop.UserControls.UcGrid();
            this.Btn_Cancel = new Layer03_Desktop.UserControls.UcButton();
            this.Btn_Ok = new Layer03_Desktop.UserControls.UcButton();
            this.SuspendLayout();
            // 
            // Grid_Selection
            // 
            this.Grid_Selection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid_Selection.Location = new System.Drawing.Point(12, 12);
            this.Grid_Selection.Name = "Grid_Selection";
            this.Grid_Selection.pStyle = null;
            this.Grid_Selection.Size = new System.Drawing.Size(310, 309);
            this.Grid_Selection.TabIndex = 0;
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(247, 327);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.pStyle = null;
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancel.TabIndex = 2;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // Btn_Ok
            // 
            this.Btn_Ok.Location = new System.Drawing.Point(166, 327);
            this.Btn_Ok.Name = "Btn_Ok";
            this.Btn_Ok.pStyle = null;
            this.Btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.Btn_Ok.TabIndex = 1;
            this.Btn_Ok.Text = "Ok";
            this.Btn_Ok.UseVisualStyleBackColor = true;
            // 
            // FrmSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 362);
            this.Controls.Add(this.Btn_Ok);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Grid_Selection);
            this.Name = "FrmSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSelection";
            this.ResumeLayout(false);

        }

        #endregion

        private UcGrid Grid_Selection;
        private UcButton Btn_Cancel;
        private UcButton Btn_Ok;
    }
}