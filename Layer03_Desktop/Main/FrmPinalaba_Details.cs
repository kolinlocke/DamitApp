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
using Layer01_Common.Objects;

namespace Layer03_Desktop.Main
{
    public partial class FrmPinalaba_Details : Layer03_Desktop.Base.FrmBaseDetails_Module
    {
        #region _Variables

        Layer03_Styles mStyle = new Layer03_Styles();
        new ClsPinalaba mBase;

        #endregion

        #region _Constructor

        public FrmPinalaba_Details(Int64 System_ModulesID)
        {
            InitializeComponent();

            this.Setup(new ClsPinalaba(Layer03_Common.CurrentUser), System_ModulesID);
        }

        #endregion

        #region _EventHandlers

        #endregion

        #region _Methods

        protected override void SetupForm()
        {
            base.SetupForm();
        }

        protected override void SetupForm_Bindings()
        {
            base.SetupForm_Bindings();
            this.mBase = (ClsPinalaba)base.mBase;

            this.Dtp_DatePinalaba.Value = Do_Methods.Convert_DateTime(this.mBase.pDr["DatePinalaba"], DateTime.Now).Value;
            this.SetupForm_Bindings_Grid();
        }

        protected override void SetupForm_Styles()
        {
            base.SetupForm_Styles();

            this.Lbl_DatePinalaba.pStyle = this.mStyle.Style_Field_Label;
        }

        void SetupForm_Bindings_Grid()
        {
            ClsBindGrid GridDef = Layer03_Common.GetBindGrid("Pinalaba_Damit");
            this.Grid_Damit.Setup_FromDataTable(this.GetType().Name + "_Pinalaba_Damit_Grid", this.mBase.pDt_Damit, GridDef);
        }

        #endregion
    }
}
