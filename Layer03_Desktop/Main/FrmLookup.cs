using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DataObjects_Framework.Common;
using Layer02_Objects.Base;
using Layer02_Objects.Modules;
using Layer03_Desktop._System;
using Layer03_Desktop.Base;
using C1.Win.C1TrueDBGrid;

namespace Layer03_Desktop.Main
{
    public partial class FrmLookup : FrmBaseDetail
    {
        #region _Variables

        new ClsLookup mBase;
        String mViewName;
        String mTableName;
        String mLookupName;
        Int64 mLookupID;

        #endregion

        #region _Constructor

        public FrmLookup(Int64 System_ModulesID, String Args)
        {
            InitializeComponent();

            String[] Arr_Arg = Args.Split(',');

            try
            {
                foreach (String Item_Arg in Arr_Arg)
                {
                    String[] iArr_Arg = Item_Arg.Split('=');
                    switch (iArr_Arg[0].ToUpper())
                    {
                        case "VN":
                            this.mViewName = iArr_Arg[1];
                            break;
                        case "TN":
                            this.mTableName = iArr_Arg[1];
                            break;
                        case "LN":
                            this.mLookupName = @"Lookup: " + iArr_Arg[1];
                            break;
                        case "LID":
                            this.mLookupID = Do_Methods.Convert_Int64(iArr_Arg[1]);
                            break;
                    }
                }
            }
            catch { }

            ClsLookup Obj_Lookup = new ClsLookup(Layer03_Common.CurrentUser, this.mTableName, this.mViewName, this.mLookupID);
            base.Setup(Obj_Lookup, System_ModulesID);
        }

        #endregion

        #region _EventHandlers

        protected override void Frm_Load(object sender, EventArgs e)
        {
            base.Frm_Load(sender, e);
            this.SetupForm_Bindings();
        }

        void Frm_FormClosing(object sender, FormClosingEventArgs e)
        { this.Grid_List.SaveGridDefinition(); }

        void pGrid_FetchRowStyle(object sender, C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs e)
        {
            try
            {
                C1TrueDBGrid Grid = (C1TrueDBGrid)sender;

                DataRow Dr = (Grid[e.Row] as DataRowView).Row;

                if (Do_Methods.Convert_Boolean(Dr["IsDuplicate"]))
                { e.CellStyle.BackColor = Color.Tomato; }
            }
            catch { }
        }

        #endregion

        #region _Methods

        protected override void SetupForm_Bindings()
        {
            base.SetupForm_Bindings();

            this.Text = this.mLookupName;

            this.mBase = (ClsLookup)base.mBase;
            this.mBase.Load((DataObjects_Framework.Objects.Keys)null);

            this.SetupForm_Grid();
            this.SetupForm_EventHandlers();
        }

        void SetupForm_EventHandlers()
        {
            this.FormClosing += new FormClosingEventHandler(Frm_FormClosing);
            this.Grid_List.Ev_FetchRowStyle += new C1.Win.C1TrueDBGrid.FetchRowStyleEventHandler(pGrid_FetchRowStyle); 
        }

        void SetupForm_Grid(Boolean IsDefault = false)
        {
            var GridDef = Layer03_Common.GetBindGrid(this.mTableName);
            this.Grid_List.Setup_FromDataTable(
                this.GetType().Name + this.mTableName + @"_Grid"
                , this.mBase.pDt_List
                , GridDef
                , null
                , false
                , true
                , false
                , IsDefault);

            this.Grid_List.pGrid.AllowAddNew = this.mAllowNew;
            this.Grid_List.pGrid.AllowUpdate = this.mAllowNew || this.mAllowEdit;
            this.Grid_List.pGrid.AllowDelete = this.mAllowEdit;

            this.Grid_List.pGrid.FilterBar = true;
            this.Grid_List.pGrid.AllowFilter = true;

            this.Grid_List.pGrid.FetchRowStyles = true;
        }

        //[-]

        public override void LoadForm(DataObjects_Framework.Objects.Keys Keys = null)
        { throw new NotImplementedException(); }

        protected override Str_SaveMessage SaveForm_BeforeSaveMessage()
        {
            Str_SaveMessage Sm = new Str_SaveMessage()
            {
                Message = @"Do you want to save the changes?",
                Caption = @"Save " + this.mLookupName
            };

            return Sm;
        }

        protected override Str_SaveMessage SaveForm_AfterSaveMessage()
        {
            Str_SaveMessage Sm = new Str_SaveMessage()
            {
                Message = this.mLookupName + @" Saved.",
                Caption = @"Save " + this.mLookupName
            };

            return Sm;
        }

        protected override void SaveForm()
        {
            this.Grid_List.pGrid.UpdateData();
            base.SaveForm();
        }

        protected override bool SaveForm_Validation(ref List<FrmBaseDetail.Str_ValidationItem> ValidationItems)
        {
            FrmBaseDetail.ValidateField(
                ref ValidationItems
                , ""
                , null
                , null
                , this.mBase.CheckList()
                , "There are entries that has duplicates.");

            return base.SaveForm_Validation(ref ValidationItems);
        }

        #endregion
    }
}
