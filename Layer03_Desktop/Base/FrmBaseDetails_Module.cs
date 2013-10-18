using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Layer03_Desktop._System;
using DataObjects_Framework.Common;
using Layer02_Objects.Base;

namespace Layer03_Desktop.Base
{
    public partial class FrmBaseDetails_Module : FrmBaseDetail
    {
        #region _Variables

        Layer03_Styles mStyle = new Layer03_Styles();
        protected new ClsModule mBase;

        #endregion

        #region _Constructor

        public FrmBaseDetails_Module()
        {
            InitializeComponent();
        }

        #endregion

        #region _Methods

        protected void Setup(ClsModule Base, long System_ModulesID, bool IsReadOnly = false)
        { base.Setup(Base, System_ModulesID, IsReadOnly); }

        protected override void SetupForm_Bindings()
        {
            base.SetupForm_Bindings();

            this.mBase = (ClsModule)base.mBase;

            var DateCreated = Do_Methods.Convert_DateTime(this.mBase.pDr_RowProperty["DateCreated"]);
            this.Txt_DateCreated.Text = DateCreated.HasValue ? DateCreated.Value.ToShortDateString() : "";

            var DateUpdated = Do_Methods.Convert_DateTime(this.mBase.pDr_RowProperty["DateUpdated"]);
            this.Txt_DateUpdated.Text = DateUpdated.HasValue ? DateUpdated.Value.ToShortDateString() : "";

            this.Txt_Code.Text = Do_Methods.Convert_String(this.mBase.pDr_RowProperty["Code"]);
            this.Txt_Name.Text = Do_Methods.Convert_String(this.mBase.pDr_RowProperty["Name"]);
            this.Txt_Remarks.Text = Do_Methods.Convert_String(this.mBase.pDr_RowProperty["Remarks"]);
        }

        protected override void SetupForm_Styles()
        {
            base.SetupForm_Styles();

            this.Lbl_DateCreated.pStyle = this.mStyle.Style_Field_Label;
            this.Lbl_DateUpdated.pStyle = this.mStyle.Style_Field_Label;
            this.Lbl_Code.pStyle = this.mStyle.Style_Field_Label;
            this.Lbl_Name.pStyle = this.mStyle.Style_Field_Label;
            this.Lbl_Remarks.pStyle = this.mStyle.Style_Field_Label;

            this.Txt_DateCreated.pStyle = this.mStyle.Style_Field_Textbox;
            this.Txt_DateUpdated.pStyle = this.mStyle.Style_Field_Textbox;
            this.Txt_Code.pStyle = this.mStyle.Style_Field_Textbox;
            this.Txt_Name.pStyle = this.mStyle.Style_Field_Textbox;
            this.Txt_Remarks.pStyle = this.mStyle.Style_Field_Textbox;
        }

        protected override void SaveForm()
        {
            this.mBase.pDr_RowProperty["Code"] = this.Txt_Code.Text;
            this.mBase.pDr_RowProperty["Name"] = this.Txt_Name.Text;
            this.mBase.pDr_RowProperty["Remarks"] = this.Txt_Remarks.Text;

            base.SaveForm();
        }

        #endregion
    }
}
