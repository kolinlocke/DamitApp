namespace Layer03_Desktop.Main
{
    partial class FrmPinalaba_Details
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
            this.Lbl_DatePinalaba = new Layer03_Desktop.UserControls.UcLabel();
            this.Dtp_DatePinalaba = new Layer03_Desktop.UserControls.UcDateTimePicker();
            this.TabPage_Damit = new System.Windows.Forms.TabPage();
            this.Grid_Damit = new Layer03_Desktop.UserControls.UcGrid();
            this.Tsdi_Damit = new Layer03_Desktop.UserControls.UcToolStripDetailItem();
            this.TabPage_General.SuspendLayout();
            this.Panel_RowProperty.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.Panel_Main2.SuspendLayout();
            this.Panel_Main.SuspendLayout();
            this.TabPage_Damit.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txt_DateUpdated
            // 
            this.Txt_DateUpdated.Font = new System.Drawing.Font("Tahoma", 8F);
            this.Txt_DateUpdated.ForeColor = System.Drawing.Color.Black;
            this.Txt_DateUpdated.Size = new System.Drawing.Size(150, 20);
            this.Txt_DateUpdated.TabIndex = 2;
            // 
            // Lbl_DateUpdated
            // 
            this.Lbl_DateUpdated.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Lbl_DateUpdated.ForeColor = System.Drawing.Color.Black;
            this.Lbl_DateUpdated.Size = new System.Drawing.Size(85, 13);
            // 
            // Txt_DateCreated
            // 
            this.Txt_DateCreated.Font = new System.Drawing.Font("Tahoma", 8F);
            this.Txt_DateCreated.ForeColor = System.Drawing.Color.Black;
            this.Txt_DateCreated.Size = new System.Drawing.Size(150, 20);
            // 
            // Lbl_DateCreated
            // 
            this.Lbl_DateCreated.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Lbl_DateCreated.ForeColor = System.Drawing.Color.Black;
            this.Lbl_DateCreated.Size = new System.Drawing.Size(82, 13);
            // 
            // Txt_Name
            // 
            this.Txt_Name.Font = new System.Drawing.Font("Tahoma", 8F);
            this.Txt_Name.ForeColor = System.Drawing.Color.Black;
            this.Txt_Name.Size = new System.Drawing.Size(150, 20);
            this.Txt_Name.Visible = false;
            // 
            // Lbl_Name
            // 
            this.Lbl_Name.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Lbl_Name.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Name.Size = new System.Drawing.Size(39, 13);
            this.Lbl_Name.Visible = false;
            // 
            // Txt_Code
            // 
            this.Txt_Code.Font = new System.Drawing.Font("Tahoma", 8F);
            this.Txt_Code.ForeColor = System.Drawing.Color.Black;
            this.Txt_Code.Size = new System.Drawing.Size(150, 20);
            this.Txt_Code.Visible = false;
            // 
            // Lbl_Code
            // 
            this.Lbl_Code.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Lbl_Code.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Code.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Code.Visible = false;
            // 
            // Txt_Remarks
            // 
            this.Txt_Remarks.Font = new System.Drawing.Font("Tahoma", 8F);
            this.Txt_Remarks.ForeColor = System.Drawing.Color.Black;
            this.Txt_Remarks.Visible = false;
            // 
            // Lbl_Remarks
            // 
            this.Lbl_Remarks.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Lbl_Remarks.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Remarks.Size = new System.Drawing.Size(58, 13);
            this.Lbl_Remarks.Visible = false;
            // 
            // TabPage_General
            // 
            this.TabPage_General.Controls.Add(this.Dtp_DatePinalaba);
            this.TabPage_General.Controls.Add(this.Lbl_DatePinalaba);
            this.TabPage_General.Controls.SetChildIndex(this.Panel_RowProperty, 0);
            this.TabPage_General.Controls.SetChildIndex(this.Lbl_DatePinalaba, 0);
            this.TabPage_General.Controls.SetChildIndex(this.Dtp_DatePinalaba, 0);
            // 
            // Panel_RowProperty
            // 
            this.Panel_RowProperty.Size = new System.Drawing.Size(250, 55);
            this.Panel_RowProperty.TabIndex = 1;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TabPage_Damit);
            this.TabControl.Controls.SetChildIndex(this.TabPage_Damit, 0);
            this.TabControl.Controls.SetChildIndex(this.TabPage_General, 0);
            // 
            // Lbl_DatePinalaba
            // 
            this.Lbl_DatePinalaba.AutoSize = true;
            this.Lbl_DatePinalaba.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DatePinalaba.Location = new System.Drawing.Point(6, 88);
            this.Lbl_DatePinalaba.Name = "Lbl_DatePinalaba";
            this.Lbl_DatePinalaba.pStyle = null;
            this.Lbl_DatePinalaba.Size = new System.Drawing.Size(73, 13);
            this.Lbl_DatePinalaba.TabIndex = 11;
            this.Lbl_DatePinalaba.Text = "Date Pinalaba";
            // 
            // Dtp_DatePinalaba
            // 
            this.Dtp_DatePinalaba.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_DatePinalaba.Location = new System.Drawing.Point(9, 106);
            this.Dtp_DatePinalaba.Name = "Dtp_DatePinalaba";
            this.Dtp_DatePinalaba.pStyle = null;
            this.Dtp_DatePinalaba.Size = new System.Drawing.Size(244, 21);
            this.Dtp_DatePinalaba.TabIndex = 2;
            // 
            // TabPage_Damit
            // 
            this.TabPage_Damit.Controls.Add(this.Tsdi_Damit);
            this.TabPage_Damit.Controls.Add(this.Grid_Damit);
            this.TabPage_Damit.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Damit.Name = "TabPage_Damit";
            this.TabPage_Damit.Size = new System.Drawing.Size(764, 453);
            this.TabPage_Damit.TabIndex = 1;
            this.TabPage_Damit.Text = "Damit";
            this.TabPage_Damit.UseVisualStyleBackColor = true;
            // 
            // Grid_Damit
            // 
            this.Grid_Damit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid_Damit.Location = new System.Drawing.Point(3, 28);
            this.Grid_Damit.MinimumSize = new System.Drawing.Size(373, 150);
            this.Grid_Damit.Name = "Grid_Damit";
            this.Grid_Damit.pStyle = null;
            this.Grid_Damit.Size = new System.Drawing.Size(758, 422);
            this.Grid_Damit.TabIndex = 0;
            // 
            // Tsdi_Damit
            // 
            this.Tsdi_Damit.AutoSize = true;
            this.Tsdi_Damit.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tsdi_Damit.Location = new System.Drawing.Point(0, 0);
            this.Tsdi_Damit.MinimumSize = new System.Drawing.Size(117, 25);
            this.Tsdi_Damit.Name = "Tsdi_Damit";
            this.Tsdi_Damit.Size = new System.Drawing.Size(764, 25);
            this.Tsdi_Damit.TabIndex = 1;
            // 
            // FrmPinalaba_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Name = "FrmPinalaba_Details";
            this.Text = "FrmPinalaba_Details";
            this.TabPage_General.ResumeLayout(false);
            this.TabPage_General.PerformLayout();
            this.Panel_RowProperty.ResumeLayout(false);
            this.Panel_RowProperty.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.Panel_Main2.ResumeLayout(false);
            this.Panel_Main.ResumeLayout(false);
            this.TabPage_Damit.ResumeLayout(false);
            this.TabPage_Damit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.UcDateTimePicker Dtp_DatePinalaba;
        protected internal UserControls.UcLabel Lbl_DatePinalaba;
        private System.Windows.Forms.TabPage TabPage_Damit;
        private UserControls.UcGrid Grid_Damit;
        private UserControls.UcToolStripDetailItem Tsdi_Damit;
    }
}
