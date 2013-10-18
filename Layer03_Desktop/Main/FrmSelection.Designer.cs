namespace Layer03_Desktop.Main
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
            this.ucGrid1 = new Layer03_Desktop.UserControls.UcGrid();
            this.SuspendLayout();
            // 
            // ucGrid1
            // 
            this.ucGrid1.Location = new System.Drawing.Point(4, 12);
            this.ucGrid1.MinimumSize = new System.Drawing.Size(200, 150);
            this.ucGrid1.Name = "ucGrid1";
            this.ucGrid1.pStyle = null;
            this.ucGrid1.Size = new System.Drawing.Size(268, 212);
            this.ucGrid1.TabIndex = 0;
            // 
            // FrmSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.ucGrid1);
            this.Name = "FrmSelection";
            this.Text = "FrmSelection";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.UcGrid ucGrid1;
    }
}