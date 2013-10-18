namespace Layer03_Desktop.Main
{
    partial class FrmMain_Mayari
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
            this.Cbo_Mayari = new Layer03_Desktop.UserControls.UcCombobox();
            this.Lbl_Mayari = new Layer03_Desktop.UserControls.UcLabel();
            this.Panel = new Layer03_Desktop.UserControls.UcPanel();
            this.Btn_Bago = new Layer03_Desktop.UserControls.UcButton();
            this.Btn_Piliin = new Layer03_Desktop.UserControls.UcButton();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cbo_Mayari
            // 
            this.Cbo_Mayari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Mayari.FormattingEnabled = true;
            this.Cbo_Mayari.Location = new System.Drawing.Point(82, 12);
            this.Cbo_Mayari.Name = "Cbo_Mayari";
            this.Cbo_Mayari.Size = new System.Drawing.Size(250, 21);
            this.Cbo_Mayari.TabIndex = 0;
            // 
            // Lbl_Mayari
            // 
            this.Lbl_Mayari.AutoSize = true;
            this.Lbl_Mayari.Location = new System.Drawing.Point(3, 15);
            this.Lbl_Mayari.Name = "Lbl_Mayari";
            this.Lbl_Mayari.Size = new System.Drawing.Size(42, 13);
            this.Lbl_Mayari.TabIndex = 5;
            this.Lbl_Mayari.Text = "May Ari";
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.Btn_Bago);
            this.Panel.Controls.Add(this.Btn_Piliin);
            this.Panel.Controls.Add(this.Lbl_Mayari);
            this.Panel.Controls.Add(this.Cbo_Mayari);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(344, 72);
            this.Panel.TabIndex = 6;
            // 
            // Btn_Bago
            // 
            this.Btn_Bago.Location = new System.Drawing.Point(257, 39);
            this.Btn_Bago.Name = "Btn_Bago";
            this.Btn_Bago.Size = new System.Drawing.Size(75, 23);
            this.Btn_Bago.TabIndex = 2;
            this.Btn_Bago.Text = "Bago";
            this.Btn_Bago.UseVisualStyleBackColor = true;
            // 
            // Btn_Piliin
            // 
            this.Btn_Piliin.Location = new System.Drawing.Point(176, 39);
            this.Btn_Piliin.Name = "Btn_Piliin";
            this.Btn_Piliin.Size = new System.Drawing.Size(75, 23);
            this.Btn_Piliin.TabIndex = 1;
            this.Btn_Piliin.Text = "Piliin";
            this.Btn_Piliin.UseVisualStyleBackColor = true;
            // 
            // FrmMain_Mayari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 72);
            this.Controls.Add(this.Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain_Mayari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pumili ng May-Ari";
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.UcCombobox Cbo_Mayari;
        private UserControls.UcLabel Lbl_Mayari;
        private UserControls.UcPanel Panel;
        private UserControls.UcButton Btn_Bago;
        private UserControls.UcButton Btn_Piliin;
    }
}