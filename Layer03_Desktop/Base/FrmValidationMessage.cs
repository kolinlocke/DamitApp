using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Layer03_Desktop.Base
{
    public partial class FrmValidationMessage : Form
    {
        #region _Variables

        List<FrmBaseDetail.Str_ValidationItem> mValidationItems;

        #endregion

        #region _Constructor

        public FrmValidationMessage(List<FrmBaseDetail.Str_ValidationItem> ValidationItems)
        {
            InitializeComponent();

            this.mValidationItems = ValidationItems;
            foreach (var Item in this.mValidationItems)
            { this.Lv_Message.Items.Add(Item.InvalidMsg, 0); }

            //[-]

            this.Btn_Ok.Click += new EventHandler(Btn_Ok_Click);
        }

        #endregion

        #region _EventHandlers

        void Btn_Ok_Click(object sender, EventArgs e)
        { this.Close(); }

        #endregion

        #region _Methods
        
        #endregion
    }
}
