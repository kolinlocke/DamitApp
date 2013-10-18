namespace Layer03_Desktop.Main
{
    partial class FrmDamit_Details
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
            this.Lbl_Category = new Layer03_Desktop.UserControls.UcLabel();
            this.Cbo_Category = new Layer03_Desktop.UserControls.UcCombobox();
            this.Cbo_Brand = new Layer03_Desktop.UserControls.UcCombobox();
            this.Lbl_Brand = new Layer03_Desktop.UserControls.UcLabel();
            this.Cbo_Color = new Layer03_Desktop.UserControls.UcCombobox();
            this.Lbl_Color = new Layer03_Desktop.UserControls.UcLabel();
            this.TabPage_General.SuspendLayout();
            this.Panel_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txt_DateUpdated
            // 
            this.Txt_DateUpdated.Font = new System.Drawing.Font("Tahoma", 8F);
            this.Txt_DateUpdated.ForeColor = System.Drawing.Color.Black;
            this.Txt_DateUpdated.Size = new System.Drawing.Size(150, 20);
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
            // 
            // Lbl_Name
            // 
            this.Lbl_Name.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Lbl_Name.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Name.Size = new System.Drawing.Size(76, 13);
            this.Lbl_Name.Text = "Damit Name";
            // 
            // Txt_Code
            // 
            this.Txt_Code.Font = new System.Drawing.Font("Tahoma", 8F);
            this.Txt_Code.ForeColor = System.Drawing.Color.Black;
            this.Txt_Code.Size = new System.Drawing.Size(150, 20);
            // 
            // Lbl_Code
            // 
            this.Lbl_Code.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Lbl_Code.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Code.Size = new System.Drawing.Size(72, 13);
            this.Lbl_Code.Text = "Damit Code";
            // 
            // Txt_Remarks
            // 
            this.Txt_Remarks.Font = new System.Drawing.Font("Tahoma", 8F);
            this.Txt_Remarks.ForeColor = System.Drawing.Color.Black;
            // 
            // Lbl_Remarks
            // 
            this.Lbl_Remarks.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Lbl_Remarks.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Remarks.Size = new System.Drawing.Size(58, 13);
            // 
            // TabPage_General
            // 
            this.TabPage_General.Controls.Add(this.Cbo_Color);
            this.TabPage_General.Controls.Add(this.Lbl_Color);
            this.TabPage_General.Controls.Add(this.Cbo_Brand);
            this.TabPage_General.Controls.Add(this.Lbl_Brand);
            this.TabPage_General.Controls.Add(this.Cbo_Category);
            this.TabPage_General.Controls.Add(this.Lbl_Category);
            this.TabPage_General.Controls.SetChildIndex(this.Lbl_Category, 0);
            this.TabPage_General.Controls.SetChildIndex(this.Cbo_Category, 0);
            this.TabPage_General.Controls.SetChildIndex(this.Lbl_Brand, 0);
            this.TabPage_General.Controls.SetChildIndex(this.Cbo_Brand, 0);
            this.TabPage_General.Controls.SetChildIndex(this.Lbl_Color, 0);
            this.TabPage_General.Controls.SetChildIndex(this.Cbo_Color, 0);
            // 
            // Lbl_Category
            // 
            this.Lbl_Category.AutoSize = true;
            this.Lbl_Category.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Category.Location = new System.Drawing.Point(6, 246);
            this.Lbl_Category.Name = "Lbl_Category";
            this.Lbl_Category.pStyle = null;
            this.Lbl_Category.Size = new System.Drawing.Size(52, 13);
            this.Lbl_Category.TabIndex = 11;
            this.Lbl_Category.Text = "Category";
            // 
            // Cbo_Category
            // 
            this.Cbo_Category.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Category.FormattingEnabled = true;
            this.Cbo_Category.Location = new System.Drawing.Point(94, 243);
            this.Cbo_Category.Name = "Cbo_Category";
            this.Cbo_Category.pStyle = null;
            this.Cbo_Category.Size = new System.Drawing.Size(150, 21);
            this.Cbo_Category.TabIndex = 13;
            // 
            // Cbo_Brand
            // 
            this.Cbo_Brand.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Brand.FormattingEnabled = true;
            this.Cbo_Brand.Location = new System.Drawing.Point(94, 270);
            this.Cbo_Brand.Name = "Cbo_Brand";
            this.Cbo_Brand.pStyle = null;
            this.Cbo_Brand.Size = new System.Drawing.Size(150, 21);
            this.Cbo_Brand.TabIndex = 15;
            // 
            // Lbl_Brand
            // 
            this.Lbl_Brand.AutoSize = true;
            this.Lbl_Brand.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Brand.Location = new System.Drawing.Point(6, 273);
            this.Lbl_Brand.Name = "Lbl_Brand";
            this.Lbl_Brand.pStyle = null;
            this.Lbl_Brand.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Brand.TabIndex = 14;
            this.Lbl_Brand.Text = "Brand";
            // 
            // Cbo_Color
            // 
            this.Cbo_Color.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Color.FormattingEnabled = true;
            this.Cbo_Color.Location = new System.Drawing.Point(94, 297);
            this.Cbo_Color.Name = "Cbo_Color";
            this.Cbo_Color.pStyle = null;
            this.Cbo_Color.Size = new System.Drawing.Size(150, 21);
            this.Cbo_Color.TabIndex = 17;
            // 
            // Lbl_Color
            // 
            this.Lbl_Color.AutoSize = true;
            this.Lbl_Color.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Color.Location = new System.Drawing.Point(6, 300);
            this.Lbl_Color.Name = "Lbl_Color";
            this.Lbl_Color.pStyle = null;
            this.Lbl_Color.Size = new System.Drawing.Size(32, 13);
            this.Lbl_Color.TabIndex = 16;
            this.Lbl_Color.Text = "Color";
            // 
            // FrmDamit_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Name = "FrmDamit_Details";
            this.Text = "FrmDamit_Details";
            this.TabPage_General.ResumeLayout(false);
            this.TabPage_General.PerformLayout();
            this.Panel_Main.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.UcCombobox Cbo_Color;
        protected internal UserControls.UcLabel Lbl_Color;
        private UserControls.UcCombobox Cbo_Brand;
        protected internal UserControls.UcLabel Lbl_Brand;
        private UserControls.UcCombobox Cbo_Category;
        protected internal UserControls.UcLabel Lbl_Category;
    }
}
