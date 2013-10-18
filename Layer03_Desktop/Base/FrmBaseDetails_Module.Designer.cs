using Layer03_Desktop.UserControls;
namespace Layer03_Desktop.Base
{
    partial class FrmBaseDetails_Module
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
            this.TabControl = new Layer03_Desktop.UserControls.UcTabControl();
            this.TabPage_General = new System.Windows.Forms.TabPage();
            this.Panel_RowProperty = new System.Windows.Forms.Panel();
            this.Lbl_DateCreated = new Layer03_Desktop.UserControls.UcLabel();
            this.Txt_Remarks = new Layer03_Desktop.UserControls.UcTextbox();
            this.Txt_DateCreated = new Layer03_Desktop.UserControls.UcTextbox();
            this.Lbl_Remarks = new Layer03_Desktop.UserControls.UcLabel();
            this.Lbl_DateUpdated = new Layer03_Desktop.UserControls.UcLabel();
            this.Txt_Name = new Layer03_Desktop.UserControls.UcTextbox();
            this.Txt_DateUpdated = new Layer03_Desktop.UserControls.UcTextbox();
            this.Lbl_Name = new Layer03_Desktop.UserControls.UcLabel();
            this.Lbl_Code = new Layer03_Desktop.UserControls.UcLabel();
            this.Txt_Code = new Layer03_Desktop.UserControls.UcTextbox();
            this.Panel_Main2.SuspendLayout();
            this.Panel_Main.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.TabPage_General.SuspendLayout();
            this.Panel_RowProperty.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Main2
            // 
            this.Panel_Main2.Controls.Add(this.TabControl);
            // 
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.Controls.Add(this.TabPage_General);
            this.TabControl.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl.Location = new System.Drawing.Point(3, 3);
            this.TabControl.Name = "TabControl";
            this.TabControl.pStyle = null;
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(772, 479);
            this.TabControl.TabIndex = 0;
            // 
            // TabPage_General
            // 
            this.TabPage_General.Controls.Add(this.Panel_RowProperty);
            this.TabPage_General.Location = new System.Drawing.Point(4, 22);
            this.TabPage_General.Name = "TabPage_General";
            this.TabPage_General.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_General.Size = new System.Drawing.Size(764, 453);
            this.TabPage_General.TabIndex = 0;
            this.TabPage_General.Text = "General Information";
            this.TabPage_General.UseVisualStyleBackColor = true;
            // 
            // Panel_RowProperty
            // 
            this.Panel_RowProperty.Controls.Add(this.Lbl_DateCreated);
            this.Panel_RowProperty.Controls.Add(this.Txt_Remarks);
            this.Panel_RowProperty.Controls.Add(this.Txt_DateCreated);
            this.Panel_RowProperty.Controls.Add(this.Lbl_Remarks);
            this.Panel_RowProperty.Controls.Add(this.Lbl_DateUpdated);
            this.Panel_RowProperty.Controls.Add(this.Txt_Name);
            this.Panel_RowProperty.Controls.Add(this.Txt_DateUpdated);
            this.Panel_RowProperty.Controls.Add(this.Lbl_Name);
            this.Panel_RowProperty.Controls.Add(this.Lbl_Code);
            this.Panel_RowProperty.Controls.Add(this.Txt_Code);
            this.Panel_RowProperty.Location = new System.Drawing.Point(3, 3);
            this.Panel_RowProperty.Name = "Panel_RowProperty";
            this.Panel_RowProperty.Size = new System.Drawing.Size(250, 210);
            this.Panel_RowProperty.TabIndex = 10;
            // 
            // Lbl_DateCreated
            // 
            this.Lbl_DateCreated.AutoSize = true;
            this.Lbl_DateCreated.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DateCreated.Location = new System.Drawing.Point(3, 6);
            this.Lbl_DateCreated.Name = "Lbl_DateCreated";
            this.Lbl_DateCreated.pStyle = null;
            this.Lbl_DateCreated.Size = new System.Drawing.Size(72, 13);
            this.Lbl_DateCreated.TabIndex = 0;
            this.Lbl_DateCreated.Text = "Date Created";
            // 
            // Txt_Remarks
            // 
            this.Txt_Remarks.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Remarks.Location = new System.Drawing.Point(6, 157);
            this.Txt_Remarks.Multiline = true;
            this.Txt_Remarks.Name = "Txt_Remarks";
            this.Txt_Remarks.pStyle = null;
            this.Txt_Remarks.Size = new System.Drawing.Size(235, 50);
            this.Txt_Remarks.TabIndex = 9;
            // 
            // Txt_DateCreated
            // 
            this.Txt_DateCreated.BackColor = System.Drawing.Color.White;
            this.Txt_DateCreated.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_DateCreated.Location = new System.Drawing.Point(91, 3);
            this.Txt_DateCreated.Name = "Txt_DateCreated";
            this.Txt_DateCreated.pStyle = null;
            this.Txt_DateCreated.ReadOnly = true;
            this.Txt_DateCreated.Size = new System.Drawing.Size(150, 21);
            this.Txt_DateCreated.TabIndex = 1;
            // 
            // Lbl_Remarks
            // 
            this.Lbl_Remarks.AutoSize = true;
            this.Lbl_Remarks.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Remarks.Location = new System.Drawing.Point(3, 141);
            this.Lbl_Remarks.Name = "Lbl_Remarks";
            this.Lbl_Remarks.pStyle = null;
            this.Lbl_Remarks.Size = new System.Drawing.Size(48, 13);
            this.Lbl_Remarks.TabIndex = 8;
            this.Lbl_Remarks.Text = "Remarks";
            // 
            // Lbl_DateUpdated
            // 
            this.Lbl_DateUpdated.AutoSize = true;
            this.Lbl_DateUpdated.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DateUpdated.Location = new System.Drawing.Point(3, 33);
            this.Lbl_DateUpdated.Name = "Lbl_DateUpdated";
            this.Lbl_DateUpdated.pStyle = null;
            this.Lbl_DateUpdated.Size = new System.Drawing.Size(74, 13);
            this.Lbl_DateUpdated.TabIndex = 2;
            this.Lbl_DateUpdated.Text = "Date Updated";
            // 
            // Txt_Name
            // 
            this.Txt_Name.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Name.Location = new System.Drawing.Point(91, 111);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.pStyle = null;
            this.Txt_Name.Size = new System.Drawing.Size(150, 21);
            this.Txt_Name.TabIndex = 7;
            // 
            // Txt_DateUpdated
            // 
            this.Txt_DateUpdated.BackColor = System.Drawing.Color.White;
            this.Txt_DateUpdated.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_DateUpdated.Location = new System.Drawing.Point(91, 30);
            this.Txt_DateUpdated.Name = "Txt_DateUpdated";
            this.Txt_DateUpdated.pStyle = null;
            this.Txt_DateUpdated.ReadOnly = true;
            this.Txt_DateUpdated.Size = new System.Drawing.Size(150, 21);
            this.Txt_DateUpdated.TabIndex = 3;
            // 
            // Lbl_Name
            // 
            this.Lbl_Name.AutoSize = true;
            this.Lbl_Name.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Name.Location = new System.Drawing.Point(3, 114);
            this.Lbl_Name.Name = "Lbl_Name";
            this.Lbl_Name.pStyle = null;
            this.Lbl_Name.Size = new System.Drawing.Size(34, 13);
            this.Lbl_Name.TabIndex = 6;
            this.Lbl_Name.Text = "Name";
            // 
            // Lbl_Code
            // 
            this.Lbl_Code.AutoSize = true;
            this.Lbl_Code.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Code.Location = new System.Drawing.Point(3, 87);
            this.Lbl_Code.Name = "Lbl_Code";
            this.Lbl_Code.pStyle = null;
            this.Lbl_Code.Size = new System.Drawing.Size(32, 13);
            this.Lbl_Code.TabIndex = 4;
            this.Lbl_Code.Text = "Code";
            // 
            // Txt_Code
            // 
            this.Txt_Code.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Code.Location = new System.Drawing.Point(91, 84);
            this.Txt_Code.Name = "Txt_Code";
            this.Txt_Code.pStyle = null;
            this.Txt_Code.Size = new System.Drawing.Size(150, 21);
            this.Txt_Code.TabIndex = 5;
            // 
            // FrmBaseDetails_Module
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Name = "FrmBaseDetails_Module";
            this.Text = "FrmBaseDetail_Module";
            this.Panel_Main2.ResumeLayout(false);
            this.Panel_Main.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.TabPage_General.ResumeLayout(false);
            this.Panel_RowProperty.ResumeLayout(false);
            this.Panel_RowProperty.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal UcTextbox Txt_DateUpdated;
        protected internal UcLabel Lbl_DateUpdated;
        protected internal UcTextbox Txt_DateCreated;
        protected internal UcLabel Lbl_DateCreated;
        protected internal UcTextbox Txt_Name;
        protected internal UcLabel Lbl_Name;
        protected internal UcTextbox Txt_Code;
        protected internal UcLabel Lbl_Code;
        protected internal UcTextbox Txt_Remarks;
        protected internal UcLabel Lbl_Remarks;
        protected internal System.Windows.Forms.TabPage TabPage_General;
        protected internal System.Windows.Forms.Panel Panel_RowProperty;
        protected internal UcTabControl TabControl;
    }
}
