namespace Layer03_Desktop.Base
{
    partial class FrmValidationMessage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmValidationMessage));
            this.Lv_Message = new System.Windows.Forms.ListView();
            this.Lvi_Item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Btn_Ok = new Layer03_Desktop.UserControls.UcButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ucLabel1 = new Layer03_Desktop.UserControls.UcLabel();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lv_Message
            // 
            this.Lv_Message.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Lvi_Item});
            this.Lv_Message.GridLines = true;
            this.Lv_Message.Location = new System.Drawing.Point(12, 53);
            this.Lv_Message.Name = "Lv_Message";
            this.Lv_Message.Size = new System.Drawing.Size(340, 177);
            this.Lv_Message.TabIndex = 0;
            this.Lv_Message.UseCompatibleStateImageBehavior = false;
            this.Lv_Message.View = System.Windows.Forms.View.Details;
            // 
            // Lvi_Item
            // 
            this.Lvi_Item.Text = "";
            this.Lvi_Item.Width = 330;
            // 
            // Btn_Ok
            // 
            this.Btn_Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Ok.Location = new System.Drawing.Point(277, 236);
            this.Btn_Ok.Name = "Btn_Ok";
            this.Btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.Btn_Ok.TabIndex = 1;
            this.Btn_Ok.Text = "Ok";
            this.Btn_Ok.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ucLabel1
            // 
            this.ucLabel1.AutoSize = true;
            this.ucLabel1.Location = new System.Drawing.Point(54, 13);
            this.ucLabel1.Name = "ucLabel1";
            this.ucLabel1.Size = new System.Drawing.Size(211, 13);
            this.ucLabel1.TabIndex = 3;
            this.ucLabel1.Text = "There are fields that needs to be corrected:\r\n";
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "cp_Msgbox_Warning 16x16.gif");
            // 
            // FrmValidationMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 271);
            this.Controls.Add(this.ucLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btn_Ok);
            this.Controls.Add(this.Lv_Message);
            this.Name = "FrmValidationMessage";
            this.Text = "FrmValidationMessage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Lv_Message;
        private System.Windows.Forms.ColumnHeader Lvi_Item;
        private UserControls.UcButton Btn_Ok;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UserControls.UcLabel ucLabel1;
        private System.Windows.Forms.ImageList ImageList;

    }
}