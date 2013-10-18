using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Layer02_Objects.Modules;
using Layer03_Desktop._System;
using Layer03_Desktop.Base;
using Layer01_Common.Common;
using Layer02_Objects._System;
using DataObjects_Framework.Common;

namespace Layer03_Desktop.Main
{
    public partial class FrmDamit_Details : FrmBaseDetails_Module
    {
        #region _Variables

        new ClsDamit mBase;

        #endregion

        #region _Constructor

        public FrmDamit_Details(Int64 System_ModulesID)
        {
            InitializeComponent();

            this.Setup(new ClsDamit(Layer03_Common.CurrentUser), System_ModulesID);
        }

        #endregion

        #region _Methods

        protected override void SetupForm_Bindings()
        {
            base.SetupForm_Bindings();
            this.SetupForm_ComboBox();

            this.mBase = (ClsDamit)base.mBase;

            if (this.mIsNew)
            { this.Text = "Bagong Damit"; }
            else
            { this.Text = @"Damit: " + Do_Methods.Convert_String(this.mBase.pDr["CodeName"]); }

            this.Cbo_Brand.SelectedValue = Do_Methods.Convert_Int64(this.mBase.pDr["LookupID_Brand"]);
            this.Cbo_Category.SelectedValue = Do_Methods.Convert_Int64(this.mBase.pDr["LookupID_Category"]);
            this.Cbo_Color.SelectedValue = Do_Methods.Convert_Int64(this.mBase.pDr["LookupID_Color"]);
        }

        void SetupForm_ComboBox()
        {
            Layer03_Common.BindCombo_Lookup(this.Cbo_Category, "Category");
            Layer03_Common.BindCombo_Lookup(this.Cbo_Brand, "Brand");
            Layer03_Common.BindCombo_Lookup(this.Cbo_Color, "Color");            
        }

        protected override void SaveForm()
        {
            this.mBase.pDr["LookupID_Brand"] = Do_Methods.Convert_Int64(this.Cbo_Brand.SelectedValue);
            this.mBase.pDr["LookupID_Category"] = Do_Methods.Convert_Int64(this.Cbo_Category.SelectedValue);
            this.mBase.pDr["LookupID_Color"] = Do_Methods.Convert_Int64(this.Cbo_Color.SelectedValue);

            base.SaveForm();
        }

        #endregion
    }
}
