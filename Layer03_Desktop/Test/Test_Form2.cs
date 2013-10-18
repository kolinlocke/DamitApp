using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataObjects_Framework.Common;
using Layer01_Common.Objects;
using Layer02_Objects.Modules;

namespace Layer03_Desktop.Test
{
    public partial class Test_Form2 : Form
    {
        public Test_Form2()
        {
            InitializeComponent();
            this.Load += new EventHandler(Test_Form2_Load);
        }

        void Test_Form2_Load(object sender, EventArgs e)
        {
            Do_Globals.gSettings.pConnectionString = @"User ID=sa; Password=Administrator1; Initial Catalog=Damit; Data Source=.\SQL_2K8R2;";

            ClsBindGrid GridDef = new ClsBindGrid();
            GridDef.pColumns.Add(new ClsBindGridColumn("Name"));
            GridDef.pColumns.Add(new ClsBindGridColumn("Code"));

            ClsMayari Obj = new ClsMayari(null);

            this.ucFilter1.Setup(this.ucGrid1, GridDef, Obj.List_Empty());
            this.ucGrid1.Setup_FromBase("Test", Obj, GridDef, new List<string>() { "MayariID" }, false, true, true);

        }
    }
}
