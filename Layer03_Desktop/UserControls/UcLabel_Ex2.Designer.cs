﻿namespace Layer03_Desktop.UserControls
{
    partial class UcLabel_Ex2
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
            this.LabelControl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelControl
            // 
            this.LabelControl.AutoSize = true;
            this.LabelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelControl.Location = new System.Drawing.Point(0, 0);
            this.LabelControl.Name = "LabelControl";
            this.LabelControl.Size = new System.Drawing.Size(72, 13);
            this.LabelControl.TabIndex = 0;
            this.LabelControl.Text = "[LabelControl]";
            // 
            // UcLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.LabelControl);
            this.Name = "UcLabel";
            this.Size = new System.Drawing.Size(72, 13);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LabelControl;

    }
}
