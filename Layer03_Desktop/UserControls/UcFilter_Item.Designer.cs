namespace Layer03_Desktop.UserControls
{
    partial class UcFilter_Item
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Panel_Desc = new System.Windows.Forms.Panel();
            this.Lbl_Desc = new System.Windows.Forms.Label();
            this.Panel_Control = new System.Windows.Forms.Panel();
            this.Panel_Main = new System.Windows.Forms.Panel();
            this.Panel_Conjunction = new System.Windows.Forms.Panel();
            this.Btn_Conjunction = new System.Windows.Forms.Button();
            this.Lbl_Filler = new System.Windows.Forms.Label();
            this.Panel_Condition = new System.Windows.Forms.Panel();
            this.Cmb_Condition = new System.Windows.Forms.ComboBox();
            this.Panel_Desc.SuspendLayout();
            this.Panel_Main.SuspendLayout();
            this.Panel_Conjunction.SuspendLayout();
            this.Panel_Condition.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Desc
            // 
            this.Panel_Desc.Controls.Add(this.Lbl_Desc);
            this.Panel_Desc.Location = new System.Drawing.Point(0, 0);
            this.Panel_Desc.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Desc.MinimumSize = new System.Drawing.Size(100, 30);
            this.Panel_Desc.Name = "Panel_Desc";
            this.Panel_Desc.Size = new System.Drawing.Size(100, 30);
            this.Panel_Desc.TabIndex = 0;
            // 
            // Lbl_Desc
            // 
            this.Lbl_Desc.AutoSize = true;
            this.Lbl_Desc.Location = new System.Drawing.Point(3, 8);
            this.Lbl_Desc.Name = "Lbl_Desc";
            this.Lbl_Desc.Size = new System.Drawing.Size(88, 13);
            this.Lbl_Desc.TabIndex = 0;
            this.Lbl_Desc.Text = "[FilterDescription]";
            // 
            // Panel_Control
            // 
            this.Panel_Control.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Control.Location = new System.Drawing.Point(200, 0);
            this.Panel_Control.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Control.MinimumSize = new System.Drawing.Size(150, 30);
            this.Panel_Control.Name = "Panel_Control";
            this.Panel_Control.Size = new System.Drawing.Size(150, 30);
            this.Panel_Control.TabIndex = 1;
            // 
            // Panel_Main
            // 
            this.Panel_Main.Controls.Add(this.Panel_Desc);
            this.Panel_Main.Controls.Add(this.Panel_Conjunction);
            this.Panel_Main.Controls.Add(this.Panel_Condition);
            this.Panel_Main.Controls.Add(this.Panel_Control);
            this.Panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Main.Location = new System.Drawing.Point(0, 0);
            this.Panel_Main.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Main.MinimumSize = new System.Drawing.Size(300, 30);
            this.Panel_Main.Name = "Panel_Main";
            this.Panel_Main.Size = new System.Drawing.Size(350, 139);
            this.Panel_Main.TabIndex = 2;
            // 
            // Panel_Conjunction
            // 
            this.Panel_Conjunction.Controls.Add(this.Btn_Conjunction);
            this.Panel_Conjunction.Location = new System.Drawing.Point(100, 0);
            this.Panel_Conjunction.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Conjunction.MinimumSize = new System.Drawing.Size(40, 30);
            this.Panel_Conjunction.Name = "Panel_Conjunction";
            this.Panel_Conjunction.Size = new System.Drawing.Size(40, 30);
            this.Panel_Conjunction.TabIndex = 2;
            // 
            // Btn_Conjunction
            // 
            this.Btn_Conjunction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Conjunction.Location = new System.Drawing.Point(0, 0);
            this.Btn_Conjunction.Name = "Btn_Conjunction";
            this.Btn_Conjunction.Size = new System.Drawing.Size(40, 30);
            this.Btn_Conjunction.TabIndex = 0;
            this.Btn_Conjunction.Text = "[Cnj]";
            this.Btn_Conjunction.UseVisualStyleBackColor = true;
            // 
            // Lbl_Filler
            // 
            this.Lbl_Filler.Location = new System.Drawing.Point(0, 0);
            this.Lbl_Filler.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_Filler.Name = "Lbl_Filler";
            this.Lbl_Filler.Size = new System.Drawing.Size(350, 30);
            this.Lbl_Filler.TabIndex = 1;
            this.Lbl_Filler.Text = "[Filler]";
            // 
            // Panel_Condition
            // 
            this.Panel_Condition.Controls.Add(this.Cmb_Condition);
            this.Panel_Condition.Location = new System.Drawing.Point(140, 0);
            this.Panel_Condition.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Condition.MinimumSize = new System.Drawing.Size(60, 30);
            this.Panel_Condition.Name = "Panel_Condition";
            this.Panel_Condition.Size = new System.Drawing.Size(60, 30);
            this.Panel_Condition.TabIndex = 3;
            // 
            // Cmb_Condition
            // 
            this.Cmb_Condition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Cmb_Condition.FormattingEnabled = true;
            this.Cmb_Condition.Location = new System.Drawing.Point(3, 5);
            this.Cmb_Condition.Name = "Cmb_Condition";
            this.Cmb_Condition.Size = new System.Drawing.Size(54, 21);
            this.Cmb_Condition.TabIndex = 0;
            // 
            // UcFilter_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.Panel_Main);
            this.Controls.Add(this.Lbl_Filler);
            this.Name = "UcFilter_Item";
            this.Size = new System.Drawing.Size(350, 139);
            this.Panel_Desc.ResumeLayout(false);
            this.Panel_Desc.PerformLayout();
            this.Panel_Main.ResumeLayout(false);
            this.Panel_Conjunction.ResumeLayout(false);
            this.Panel_Condition.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel Panel_Desc;
        protected internal System.Windows.Forms.Panel Panel_Control;
        private System.Windows.Forms.Label Lbl_Desc;
        private System.Windows.Forms.Panel Panel_Main;
        private System.Windows.Forms.Label Lbl_Filler;
        private System.Windows.Forms.Button Btn_Conjunction;
        private System.Windows.Forms.Panel Panel_Condition;
        private System.Windows.Forms.ComboBox Cmb_Condition;
        private System.Windows.Forms.Panel Panel_Conjunction;

    }
}
