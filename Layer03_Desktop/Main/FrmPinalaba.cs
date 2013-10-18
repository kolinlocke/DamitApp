using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Layer02_Objects.Modules;
using Layer03_Desktop._System;

namespace Layer03_Desktop.Main
{
    public partial class FrmPinalaba : Layer03_Desktop.Base.FrmBaseList
    {
        public FrmPinalaba(Int64 System_ModulesID, String Args)
        {
            InitializeComponent();

            this.Setup(new ClsPinalaba(Layer03_Common.CurrentUser), "Pinalaba", System_ModulesID);
        }
    }
}
