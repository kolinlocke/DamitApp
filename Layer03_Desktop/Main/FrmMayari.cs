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
    public partial class FrmMayari : Layer03_Desktop.Base.FrmBaseList
    {
        public FrmMayari(Int64 System_ModulesID, String Args)
        {
            InitializeComponent();

            this.Setup(new ClsMayari(Layer03_Common.CurrentUser), "Mayari", System_ModulesID);
        }
    }
}
