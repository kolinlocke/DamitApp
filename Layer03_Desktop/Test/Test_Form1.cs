using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Layer02_Objects.Modules;
using Layer01_Common.Objects;
using DataObjects_Framework.Common;

namespace Layer03_Desktop.Test
{
    public partial class Test_Form1 : Form
    {
        public Test_Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Test_Form1_Load);
        }

        void Test_Form1_Load(object sender, EventArgs e)
        {
            Do_Globals.gSettings.pConnectionString = @"User ID=sa; Password=Administrator1; Initial Catalog=Damit; Data Source=.\SQL_2K8R2;";

            ClsBindGrid GridDef = new ClsBindGrid();

            List<ClsBindGridColumn> BindDef = new List<ClsBindGridColumn>();
            BindDef.Add(new ClsBindGridColumn("Name"));
            BindDef.Add(new ClsBindGridColumn("Code"));

            GridDef.pColumns = BindDef;

            this.ucGrid1.Setup_FromBase("TestGrid", new ClsMayari(null), GridDef, new List<string>() { "MayariID" }, false, true, true);
        }
    }
}
