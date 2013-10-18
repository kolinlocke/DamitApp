using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Layer03_Desktop.UserControls
{
    public partial class UcLabel_Ex2 : Layer03_Desktop.UserControls.UcBase_Ex
    {
        public UcLabel_Ex2()
        { InitializeComponent(); }

        public Label pLabel
        {
            get { return this.LabelControl; }
        }

    }
}
