using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataObjects_Framework.BaseObjects;
using Layer01_Common.Common;
using Layer02_Objects.Base;
using Layer03_Desktop._System;

namespace Layer03_Desktop.Base
{
    public partial class FrmBaseDetail : Form
    {
        #region _Variables

        protected DataObjects_Framework.BaseObjects.Base mBase;
        protected Int64 mSystem_ModulesID;
        protected Boolean mIsReadOnly;
        protected Boolean mIsNew;
        protected Boolean mAllowNew;
        protected Boolean mAllowEdit;

        public struct Str_ValidationItem
        {
            public String Name;
            public String Desc;
            public Layer03_Common.Str_Style? Style;
            public Boolean IsValid;
            public String InvalidMsg;
        }

        public struct Str_SaveMessage
        {
            public String Message;
            public String Caption;
        }

        #endregion

        #region _Events

        public delegate void Ds_ObjectSaved(DataObjects_Framework.Objects.Keys Keys);
        public delegate void Ds_Generic();
        public event Ds_ObjectSaved Ev_FormSaved;
        public event Ds_Generic Ev_NewForm;

        #endregion

        #region _Constructor

        public FrmBaseDetail()
        {
            InitializeComponent();

            this.Load += new EventHandler(Frm_Load);

            this.Btn_New.Click += new EventHandler(Btn_New_Click);
            this.Btn_Save.Click += new EventHandler(Btn_Save_Click);
            this.Btn_Close.Click += new EventHandler(Btn_Close_Click);

            this.MnuMain_New.Click += new EventHandler(Btn_New_Click);
            this.MnuMain_Save.Click += new EventHandler(Btn_Save_Click);
            this.MnuMain_Close.Click += new EventHandler(Btn_Close_Click);
        }

        #endregion

        #region _EventHandlers

        protected virtual void Frm_Load(object sender, EventArgs e)
        {
            try
            {
                this.SetupForm();
                this.Focus();
            }
            catch (Exception Ex)
            { Layer01_Methods.ErrorHandler(Ex, this.GetType().Name); }
        }

        void Btn_New_Click(object sender, EventArgs e)
        {
            if (this.Ev_NewForm != null)
            { this.Ev_NewForm(); }

            this.Close();
        }

        void Btn_Save_Click(object sender, EventArgs e)
        {
            try
            { this.SaveForm_Begin(); }
            catch (Exception Ex)
            { Layer01_Methods.ErrorHandler(Ex, this.GetType().Name); }
        }

        void Btn_Close_Click(object sender, EventArgs e)
        { this.Close(); }

        #endregion

        #region _Methods

        protected virtual void Setup(
            DataObjects_Framework.BaseObjects.Base Base
            , Int64 System_ModulesID
            , Boolean IsReadOnly = false)
        {
            this.mBase = Base;
            this.mSystem_ModulesID = System_ModulesID;
            this.mIsReadOnly = IsReadOnly;
        }

        protected virtual void SetupForm()
        {
            this.mAllowNew = false;
            this.mAllowEdit = false;

            if (!this.mIsReadOnly)
            {
                this.mAllowNew = true;
                this.mAllowEdit = true;
            }

            this.Btn_New.Enabled = this.mAllowNew;
            this.Btn_Save.Enabled = this.mAllowEdit;

            this.MnuMain_New.Enabled = this.Btn_New.Enabled;
            this.MnuMain_Save.Enabled = this.Btn_Save.Enabled;

            this.SetupForm_ControlState();
            this.SetupForm_Styles_Begin();
        }

        void SetupForm_ControlState()
        { this.SetupForm_ControlState(this.Panel_Main2); }

        void SetupForm_ControlState(Control C)
        {
            String Control = C.GetType().Name;
            if (C is TextBox)
            {
                if (!(C as TextBox).ReadOnly)
                { (C as TextBox).ReadOnly = this.mIsReadOnly; }
            }
            else if (
                C is CheckBox
                || C is Button
                || C is ComboBox
                || C is DateTimePicker)
            { C.Enabled = !this.mIsReadOnly; }
            else
            {
                foreach (Control Ic in C.Controls)
                { this.SetupForm_ControlState(Ic); }
            }
        }

        protected virtual void SetupForm_Styles() { }

        void SetupForm_Styles_Begin()
        {
            this.SetupForm_Styles();
            this.SetupForm_Styles_End();
        }

        void SetupForm_Styles_End()
        { Layer03_Common.ApplyStyle(this.Panel_Main2); }

        protected virtual void SetupForm_Bindings() { }

        public virtual void LoadForm(DataObjects_Framework.Objects.Keys Keys = null)
        {
            this.mIsNew = (Keys == null);
            this.mBase.Load(Keys);
            this.SetupForm_Bindings();
        }

        protected virtual void SaveForm() { }

        protected virtual Str_SaveMessage SaveForm_BeforeSaveMessage()
        {
            Str_SaveMessage Rv = new Str_SaveMessage()
            {
                Message = @"Do you want to save the current record?",
                Caption = "Save Record"
            };

            return Rv;
        }

        protected virtual Str_SaveMessage SaveForm_AfterSaveMessage()
        {
            Str_SaveMessage Rv = new Str_SaveMessage()
            {
                Message = @"Record Saved.",
                Caption = @"Save Record"
            };

            return Rv;
        }

        protected virtual Boolean SaveForm_Validation(ref List<Str_ValidationItem> ValidationItems)
        {
            Boolean IsValid = !ValidationItems.Any(O => !O.IsValid);
            this.SaveForm_Validation_ApplyStyles(ref ValidationItems);
            return IsValid;
        }

        void SaveForm_Validation_ApplyStyles(ref List<Str_ValidationItem> ValidationItems)
        {
            List<Str_ValidationItem?> ValidationItems_Ex = new List<Str_ValidationItem?>(ValidationItems.Select(O => new Str_ValidationItem?(O)));
            foreach (var Item in this.Panel_Main2.Controls)
            {
                if (!(Item is Control)) { continue; }
                var Item_Control = (Control)Item;
                var Item_Vi = ValidationItems_Ex.FirstOrDefault(O => O.Value.Name == Item_Control.Name);
                if (Item_Vi != null)
                { Layer03_Common.ApplyStyle(Item_Control, Item_Vi.Value.Style); }
            }
        }

        void SaveForm_Begin()
        {
            Str_SaveMessage Sm = this.SaveForm_BeforeSaveMessage();
            if (MessageBox.Show(Sm.Message, Sm.Caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            { return; }

            this.SaveForm();

            List<Str_ValidationItem> ValidationItems = new List<Str_ValidationItem>();

            if (this.SaveForm_Validation(ref ValidationItems))
            { this.SaveForm_End(); }
            else
            {
                var Frm = new FrmValidationMessage(ValidationItems);
                Frm.ShowDialog(this);
            }
        }

        void SaveForm_End()
        {
            this.mBase.Save();
            this.mIsNew = false;
            this.SetupForm_Bindings();

            if (this.Ev_FormSaved != null)
            { this.Ev_FormSaved(this.mBase.GetKeys()); }

            Str_SaveMessage Sm = this.SaveForm_AfterSaveMessage();
            MessageBox.Show(Sm.Message, Sm.Caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static Boolean ValidateField(
            ref List<Str_ValidationItem> ValidationItems
            , String Name
            , Layer03_Common.Str_Style? Style_Normal
            , Layer03_Common.Str_Style? Style_Invalid
            , Boolean IsValid
            , String InvalidMsg)
        {
            Str_ValidationItem Vi = new Str_ValidationItem();
            Vi.Name = Name;
            Vi.IsValid = IsValid;

            if (IsValid)
            { Vi.Style = Style_Normal; }
            else
            {
                Vi.Style = Style_Invalid;
                Vi.InvalidMsg = InvalidMsg;
            }

            ValidationItems.Add(Vi);

            return IsValid;
        }

        #endregion
    }
}
