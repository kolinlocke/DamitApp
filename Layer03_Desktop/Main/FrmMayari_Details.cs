using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Layer02_Objects.Modules;
using Layer03_Desktop._System;
using DataObjects_Framework.Common;

namespace Layer03_Desktop.Main
{
    public partial class FrmMayari_Details : Layer03_Desktop.Base.FrmBaseDetails_Module
    {
        #region _Constructor

        public FrmMayari_Details(Int64 System_ModulesID)
        {
            InitializeComponent();

            this.Setup(new ClsMayari(Layer03_Common.CurrentUser), System_ModulesID);
        }

        #endregion

        #region _Methods

        protected override void SetupForm_Bindings()
        {
            base.SetupForm_Bindings();

            if (this.mIsNew)
            { this.Text = "Bagong May-Ari"; }
            else
            { this.Text = @"May-Ari: " + Do_Methods.Convert_String(this.mBase.pDr["CodeName"]); }
        }

        #endregion
    }
}
