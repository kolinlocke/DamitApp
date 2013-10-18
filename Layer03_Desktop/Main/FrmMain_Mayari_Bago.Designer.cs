namespace Layer03_Desktop.Main
{
    partial class FrmMain_Mayari_Bago
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
            this.Txt_Pangalan = new Layer03_Desktop.UserControls.UcTextbox();
            this.Lbl_Pangalan = new Layer03_Desktop.UserControls.UcLabel();
            this.Btn_Ikansela = new Layer03_Desktop.UserControls.UcButton();
            this.Btn_Tanggapin = new Layer03_Desktop.UserControls.UcButton();
            this.SuspendLayout();
            // 
            // Txt_Pangalan
            // 
            this.Txt_Pangalan.Location = new System.Drawing.Point(82, 12);
            this.Txt_Pangalan.Name = "Txt_Pangalan";
            this.Txt_Pangalan.Size = new System.Drawing.Size(200, 20);
            this.Txt_Pangalan.TabIndex = 0;
            // 
            // Lbl_Pangalan
            // 
            this.Lbl_Pangalan.AutoSize = true;
            this.Lbl_Pangalan.Location = new System.Drawing.Point(12, 15);
            this.Lbl_Pangalan.Name = "Lbl_Pangalan";
            this.Lbl_Pangalan.Size = new System.Drawing.Size(52, 13);
            this.Lbl_Pangalan.TabIndex = 1;
            this.Lbl_Pangalan.Text = "Pangalan";
            // 
            // Btn_Ikansela
            // 
            this.Btn_Ikansela.Location = new System.Drawing.Point(207, 37);
            this.Btn_Ikansela.Name = "Btn_Ikansela";
            this.Btn_Ikansela.Size = new System.Drawing.Size(75, 23);
            this.Btn_Ikansela.TabIndex = 4;
            this.Btn_Ikansela.Text = "Ikansela";
            this.Btn_Ikansela.UseVisualStyleBackColor = true;
            // 
            // Btn_Tanggapin
            // 
            this.Btn_Tanggapin.Location = new System.Drawing.Point(126, 37);
            this.Btn_Tanggapin.Name = "Btn_Tanggapin";
            this.Btn_Tanggapin.Size = new System.Drawing.Size(75, 23);
            this.Btn_Tanggapin.TabIndex = 3;
            this.Btn_Tanggapin.Text = "Tanggapin";
            this.Btn_Tanggapin.UseVisualStyleBackColor = true;
            // 
            // FrmMain_Mayari_Bago
            // 
            this.AcceptButton = this.Btn_Tanggapin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Btn_Ikansela;
            this.ClientSize = new System.Drawing.Size(294, 72);
            this.Controls.Add(this.Btn_Ikansela);
            this.Controls.Add(this.Btn_Tanggapin);
            this.Controls.Add(this.Lbl_Pangalan);
            this.Controls.Add(this.Txt_Pangalan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain_Mayari_Bago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bagong May-Ari";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.UcTextbox Txt_Pangalan;
        private UserControls.UcLabel Lbl_Pangalan;
        private UserControls.UcButton Btn_Ikansela;
        private UserControls.UcButton Btn_Tanggapin;
    }
}