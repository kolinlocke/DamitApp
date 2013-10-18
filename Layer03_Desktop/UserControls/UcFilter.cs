using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataObjects_Framework.Common;
using Layer01_Common.Common;
using Layer01_Common.Objects;
using Layer03_Desktop._System;
using DataObjects_Framework.Objects;
using C1.Win.C1TrueDBGrid;
using Layer01_Common_C1;
using System.Collections.ObjectModel;

namespace Layer03_Desktop.UserControls
{
    public partial class UcFilter : UserControl, Interface_Style
    {
        #region _Interface_Style_Implementations

        StyleBase mStyleBase = new StyleBase();

        public StyleBase pStyleBase
        {
            get { return this.mStyleBase; }
        }

        public Layer03_Common.Str_Style? pStyle
        {
            get { return this.pStyleBase.pStyle; }
            set { this.pStyleBase.pStyle = value; }
        }

        #endregion

        #region _Constructor

        public UcFilter()
        {
            InitializeComponent();
            this.pStyleBase.Setup(this);

            //[-]

        }

        #endregion

        #region _Events

        public delegate void DsFilter(QueryCondition Qc);
        public event DsFilter EvFilter;

        #endregion     

        #region _Variables

        Interface_FilterTarget mFilterTarget;
        List<UcFilter_Field> mFilterFields;
        DataTable mDt_FilterItems;
        QueryCondition mQc = new QueryCondition();
        Dictionary<Int64, QueryCondition.Str_QueryCondition?> mConditions = new Dictionary<Int64, QueryCondition.Str_QueryCondition?>();

        #endregion

        #region _EventHandlers

        void Btn_NewFilter_Click(object sender, EventArgs e)
        {
            UcFilter_Field SelectedField = (UcFilter_Field)this.Cbo_Field.SelectedItem;
            if (SelectedField == null) { return; }

            this.ClearFilter();
            this.AddFilter(SelectedField, this.Txt_Filter.Text);
        }

        void Btn_AddFilter_Click(object sender, EventArgs e)
        {
            UcFilter_Field SelectedField = (UcFilter_Field)this.Cbo_Field.SelectedItem;
            if (SelectedField == null) { return; }

            this.AddFilter(SelectedField, this.Txt_Filter.Text);
        }

        void Btn_ClearFilter_Click(object sender, EventArgs e)
        { this.ClearFilter(); }

        void Grid_Filters_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Delete
                || e.KeyCode == System.Windows.Forms.Keys.Back)
            { this.DeleteFilter(); }
        }

        void Grid_Filters_ButtonClick(object sender, ColEventArgs e)
        { this.DeleteFilter(); }

        void UcFilter_EvFilter(QueryCondition Qc)
        {
            if (this.mFilterTarget == null)
            { return; }

            this.mFilterTarget.ApplyFilter(Qc);
        }

        void Txt_Filter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            { this.Btn_AddFilter_Click(null, null); }
        }

        #endregion

        #region _Methods

        public void Setup(Interface_FilterTarget FilterTarget, ClsBindGrid GridDef, DataTable Dt_Source)
        {
            this.mFilterTarget = FilterTarget;
            this.EvFilter += new DsFilter(UcFilter_EvFilter);
            this.Setup(GridDef, Dt_Source);
        }

        public void Setup(ClsBindGrid GridDef, DataTable Dt_Source)
        {
            List<ClsBindGridColumn> GridDef_Columns = GridDef.pColumns;

            this.mFilterFields = new List<UcFilter_Field>();

            foreach (
                ClsBindGridColumn Item_Gc
                in (from O in GridDef_Columns where O.pIsFilter == true select O))
            {
                UcFilter_Field Field = new UcFilter_Field();
                Field.FieldName = Item_Gc.pFieldName;
                Field.FieldDesc = Item_Gc.pFieldDesc;

                if (Dt_Source.Columns.Contains(Item_Gc.pFieldName))
                { Field.DataType = Dt_Source.Columns[Item_Gc.pFieldName].DataType; }

                this.mFilterFields.Add(Field);
            }

            Layer01_Methods.BindCombo(this.Cbo_Field, this.mFilterFields, "FieldDesc", "FieldName");

            //[-]

            this.mDt_FilterItems = new DataTable();
            this.mDt_FilterItems.Columns.Add("Key", typeof(Int64));
            this.mDt_FilterItems.Columns.Add("Field", typeof(String));
            this.mDt_FilterItems.Columns.Add("Field_Condition", typeof(String));
            this.mDt_FilterItems.Columns.Add("Btn_Delete", typeof(String));

            Layer01_Methods_C1.InitializeGrid(this.Grid_Filters);
            this.Grid_Filters.FilterBar = false;
            this.Grid_Filters.AllowFilter = false;
            this.Grid_Filters.DataSource = this.mDt_FilterItems;

            ClsBindGrid GridDef_FilterItems = new ClsBindGrid();
            GridDef_FilterItems.pColumns.Add(new ClsBindGridColumn("Field", "Field", 100));
            GridDef_FilterItems.pColumns.Add(new ClsBindGridColumn("Field_Condition", "Condition", 200));
            GridDef_FilterItems.pColumns.Add(new ClsBindGridColumn("Btn_Delete", "", 100, "", Layer01_Constants.eSystem_Lookup_FieldType.FieldType_Button, Layer01_Constants.eSystem_Lookup_HorizontalAlign.Grid_HorizontalAlign_Center));

            Layer01_Methods_C1.BindGrid_SetColumns(this.Grid_Filters, GridDef_FilterItems);

            this.Setup_EventHandlers();
        }

        void Setup_EventHandlers()
        {
            this.Btn_NewFilter.Click += new EventHandler(Btn_NewFilter_Click);
            this.Btn_AddFilter.Click += new EventHandler(Btn_AddFilter_Click);
            this.Btn_ClearFilter.Click += new EventHandler(Btn_ClearFilter_Click);
            this.Grid_Filters.ButtonClick += new ColEventHandler(Grid_Filters_ButtonClick);
            this.Grid_Filters.KeyDown += new KeyEventHandler(Grid_Filters_KeyDown);
            this.Txt_Filter.KeyDown += new KeyEventHandler(Txt_Filter_KeyDown);
        }

        void AddFilter(UcFilter_Field Field, String FilterText)
        {
            QueryCondition.Str_QueryCondition New_Qc = this.mQc.Add(Field.FieldName, FilterText, Field.DataType.Name);
            Int64 LastKey = 0;

            if (this.mConditions.Any())
            { LastKey = this.mConditions.Max(O => O.Key); }

            LastKey++;

            this.mConditions.Add(LastKey, New_Qc);

            Do_Methods.AddDataRow(
                ref this.mDt_FilterItems
                , new String[] { "Key", "Field", "Field_Condition", "Btn_Delete" }
                , new Object[] { LastKey, Field.FieldName, New_Qc.Operator + " " + Do_Methods.Convert_String(New_Qc.Value), "Remove" });

            if (this.EvFilter != null)
            { this.EvFilter(this.mQc); }
        }

        void ClearFilter()
        {
            this.mQc.pList.Clear();
            this.mDt_FilterItems.Rows.Clear();

            if (this.EvFilter != null)
            { this.EvFilter(this.mQc); }
        }

        void DeleteFilter()
        {
            DataRowView Drv = (this.Grid_Filters[this.Grid_Filters.Bookmark] as DataRowView);
            if (Drv != null)
            {
                DataRow Dr = Drv.Row;
                Int64 Key = Do_Methods.Convert_Int64(Dr["Key"]);
                var Qc = this.mConditions[Key].Value;
                this.mConditions.Remove(Key);
                this.mQc.pList.Remove(Qc);
                this.mDt_FilterItems.Rows.Remove(Dr);
            }

            if (this.EvFilter != null)
            { this.EvFilter(this.mQc); }
        }

        #endregion

        #region _Classes

        class UcFilter_Field
        {
            public String FieldName { get; set; }
            public String FieldDesc { get; set; }
            public Type DataType { get; set; }
        }

        class UcFilter_FilterItem 
        {
            public QueryCondition.Str_QueryCondition? Condition { get; set; }
            public String Field { get; set; }
            public String Field_Condition { get; set; }
        }

        #endregion
    }
}
