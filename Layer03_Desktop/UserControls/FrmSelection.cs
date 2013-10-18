using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataObjects_Framework.Common;
using DataObjects_Framework.Objects;
using Layer01_Common.Objects;
using Layer03_Desktop._System;

namespace Layer03_Desktop.UserControls
{
    public partial class FrmSelection : Form
    {
        #region _Variables

        DataRow mDr_SelectionDefinition;
        String mName;
        Boolean mIsSelect;

        String mTableName;
        String mTableKey;
        String mCondition;
        List<String> mList_TableKey;

        public struct Str_SelectionResult
        {
            public DialogResult Result;
            public DataTable Dt_Selected;
        }

        #endregion

        #region _Constructor

        public FrmSelection(String Name, Boolean IsSelect)
        {
            InitializeComponent();
            this.mName = Name;
            this.mIsSelect = IsSelect;

            this.Btn_Ok.Click += new EventHandler(Btn_Ok_Click);
            this.Btn_Cancel.Click += new EventHandler(Btn_Cancel_Click);
            this.Grid_Selection.Ev_PageChanging += new UcGrid.Ds_PageChange(Grid_Selection_Ev_PageChanging);
        }

        #endregion

        #region _EventHandlers

        void Btn_Ok_Click(object sender, EventArgs e)
        {
            this.SetSelected();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        void Grid_Selection_Ev_PageChanging(UcGrid Sender)
        { this.SetSelected(); }

        #endregion

        #region _Methods

        void SetupForm()
        {
            DataTable Dt_Definition = Do_Methods_Query.GetQuery(@"uvw_System_SelectionDefinition", "", @"Name = '" + this.mName + @"'");
            if (Dt_Definition.Rows.Count == 0)
            { throw new CustomException(@"SelectionDefinition not found."); }
            this.mDr_SelectionDefinition = Dt_Definition.Rows[0];

            this.mTableName = Do_Methods.Convert_String(this.mDr_SelectionDefinition["TableName"]);
            this.mCondition = Do_Methods.Convert_String(this.mDr_SelectionDefinition["Condition"]);
            this.mTableKey = Do_Methods.Convert_String(this.mDr_SelectionDefinition["TableKey"]);

            DataTable Dt_Definition_TableKey =
                Do_Methods_Query.GetQuery(
                @"System_SelectionDefinition_TableKey"
                , @""
                , @"System_SelectionDefinitionID = " + Do_Methods.Convert_Int64(this.mDr_SelectionDefinition["System_SelectionDefinitionID"]).ToString());

            this.mList_TableKey = new List<String>();
            foreach (DataRow Dr in Dt_Definition_TableKey.Rows)
            { this.mList_TableKey.Add(Do_Methods.Convert_String(Dr["Name"])); }

            Do_Constants.Str_QuerySource QuerySource = new Do_Constants.Str_QuerySource()
            {
                ObjectName = this.mTableName,
                Condition = this.mCondition
            };

            ClsBindGrid GridDef = Layer03_Common.GetBindGrid(Do_Methods.Convert_String(this.mDr_SelectionDefinition["System_BindDefinition_Name"]));
            this.Grid_Selection.Setup_FromQuerySource(
                @"FrmSelection_" + this.mName
                , QuerySource
                , GridDef
                , this.mList_TableKey
                , this.mIsSelect
                , true
                , false
                , true);

            this.pDt_Selected = this.Grid_Selection.pDt_Source.Clone();
        }

        void SetSelected()
        {
            DataRow[] ArrDr_Source = this.Grid_Selection.pDt_Source.Select();
            foreach (DataRow Dr_Source in ArrDr_Source)
            {
                StringBuilder Sb_Condition = new StringBuilder();
                Sb_Condition.Append(@" 1 = 1 ");
                foreach (String Key in this.mList_TableKey)
                { Sb_Condition.Append(@" And " + Key + @" = " + Do_Methods.Convert_Int64(Dr_Source[Key]).ToString()); }

                if (Do_Methods.Convert_Boolean(Dr_Source["IsSelected"]))
                {
                    if (this.pDt_Selected.Select(Sb_Condition.ToString()).Count() == 0)
                    { this.pDt_Selected.Rows.Add(Dr_Source.ItemArray); }
                }
                else
                {
                    DataRow[] ArrDr_Remove = this.pDt_Selected.Select(Sb_Condition.ToString());
                    if (ArrDr_Remove.Count() > 0)
                    {
                        DataRow Dr_Remove = ArrDr_Remove[0];
                        this.pDt_Selected.Rows.Remove(Dr_Remove);
                    }
                }
            }
        }

        public static Str_SelectionResult Show(String Name, Boolean IsSelect = false)
        {
            FrmSelection Frm = new FrmSelection(Name, IsSelect);
            DialogResult Result = Frm.ShowDialog();

            DataTable Dt_Selected = Frm.pDt_Selected;

            Str_SelectionResult Rv =
                new Str_SelectionResult()
                {
                    Result = Result,
                    Dt_Selected = Dt_Selected
                };

            return Rv;
        }

        #endregion

        #region _Properties

        DataTable pDt_Selected { get; set; }

        #endregion
    }
}
