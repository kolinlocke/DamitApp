namespace Layer03_Desktop.Test
{
    partial class Test_Form2
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
            this.ucFilter1 = new Layer03_Desktop.UserControls.UcFilter();
            this.ucGrid1 = new Layer03_Desktop.UserControls.UcGrid();
            this.SuspendLayout();
            // 
            // ucFilter1
            // 
            this.ucFilter1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucFilter1.AutoSize = true;
            this.ucFilter1.Location = new System.Drawing.Point(12, 12);
            this.ucFilter1.MinimumSize = new System.Drawing.Size(350, 120);
            this.ucFilter1.Name = "ucFilter1";
            this.ucFilter1.Size = new System.Drawing.Size(578, 171);
            this.ucFilter1.TabIndex = 0;
            // 
            // ucGrid1
            // 
            this.ucGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucGrid1.Location = new System.Drawing.Point(12, 189);
            this.ucGrid1.MinimumSize = new System.Drawing.Size(320, 150);
            this.ucGrid1.Name = "ucGrid1";
            this.ucGrid1.Size = new System.Drawing.Size(578, 303);
            this.ucGrid1.TabIndex = 1;
            // 
            // Test_Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 504);
            this.Controls.Add(this.ucGrid1);
            this.Controls.Add(this.ucFilter1);
            this.Name = "Test_Form2";
            this.Text = "Test_Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.UcFilter ucFilter1;
        private UserControls.UcGrid ucGrid1;
    }
}