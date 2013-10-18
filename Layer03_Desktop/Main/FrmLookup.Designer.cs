namespace Layer03_Desktop.Main
{
    partial class FrmLookup
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
            this.Grid_List = new Layer03_Desktop.UserControls.UcGrid();
            this.Panel_Main2.SuspendLayout();
            this.Panel_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Main2
            // 
            this.Panel_Main2.Controls.Add(this.Grid_List);
            this.Panel_Main2.Size = new System.Drawing.Size(778, 485);
            // 
            // Grid_List
            // 
            this.Grid_List.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid_List.Location = new System.Drawing.Point(3, 3);
            this.Grid_List.MinimumSize = new System.Drawing.Size(320, 150);
            this.Grid_List.Name = "Grid_List";
            this.Grid_List.Size = new System.Drawing.Size(772, 479);
            this.Grid_List.TabIndex = 0;
            // 
            // FrmLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Name = "FrmLookup";
            this.Panel_Main2.ResumeLayout(false);
            this.Panel_Main.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.UcGrid Grid_List;
    }
}
