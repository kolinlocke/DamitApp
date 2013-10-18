namespace Layer03_Desktop.Test
{
    partial class Test_Form1
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
            this.ucGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucGrid1.Location = new System.Drawing.Point(12, 3);
            this.ucGrid1.MinimumSize = new System.Drawing.Size(500, 300);
            this.ucGrid1.Name = "ucGrid1";
            this.ucGrid1.Size = new System.Drawing.Size(567, 447);
            this.ucGrid1.TabIndex = 0;
            // 
            // Test_Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.ucGrid1);
            this.Name = "Test_Form1";
            this.Text = "Test_Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.UcGrid ucGrid1;
    }
}