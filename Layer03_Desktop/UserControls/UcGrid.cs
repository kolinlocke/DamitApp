using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.C1TrueDBGrid;
using DataObjects_Framework.Common;
using DataObjects_Framework.Objects;
using Layer01_Common.Common;
using Layer01_Common.Objects;
using Layer01_Common_C1;
using Layer02_Objects.Base;
using Layer03_Desktop._System;
using System.Collections.Generic;

namespace Layer03_Desktop.UserControls
{
    public partial class UcGrid :
        UserControl
        , Interface_Style
        , Interface_FilterTarget
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

        #region _Interface_FilterTarget_Implementations

        public void ApplyFilter(QueryCondition Qc)
        { this.RebindGrid(Qc); }

        #endregion

        #region _Events

        public delegate void Ds_Generic();
        public delegate void Ds_PageChange(UcGrid Sender);

        public event Ds_Generic Ev_KeyEnter;
        public event FetchRowStyleEventHandler Ev_FetchRowStyle;
        public event Ds_PageChange Ev_PageChanging;
        public event Ds_PageChange Ev_PageChanged;

        #endregion

        #region _Variables

        UcGrid_Properties mProperties;
        QueryCondition mQc;
        String mSort;
        Int64 mMaxPage;

        EventHandlerDelayer mEd_Txt_Top;

        public enum eSourceType
        {
            Base,
            DataTable,
            Table,
            QuerySource
        }

        struct Str_DataSource
        {
            public DataTable Dt_Source;
            public Int64 SourceCount;
        }

        #endregion

        #region _Constructor

        public UcGrid()
        {
            InitializeComponent();
            this.pStyleBase.Setup(this);
        }

        #endregion

        #region _EventHandlers

        void Cbo_Page_SelectedValueChanged(object sender, EventArgs e)
        { this.RebindGrid(null, true); }

        void Txt_Top_TextChanged(object sender, EventArgs e)
        { this.mEd_Txt_Top.Delay(); }

        void Txt_Top_TextChanged_Ex(Object Sender)
        {
            if (this.InvokeRequired)
            {
                EventHandlerDelayer.Ds_EventHandler D = new EventHandlerDelayer.Ds_EventHandler(this.Txt_Top_TextChanged_Ex);
                this.Invoke(D, new Object[] { Sender });
            }
            else
            { this.RebindGrid(); }
        }

        void Btn_Previous_Click(object sender, EventArgs e)
        {
            Int64 Page = Do_Methods.Convert_Int64(this.Cbo_Page.SelectedValue, 1);

            if (Page == 1)
            { return; }

            try { this.Cbo_Page.SelectedValue = Page - 1; }
            catch { }
        }

        void Btn_Next_Click(object sender, EventArgs e)
        {
            Int64 Page = Do_Methods.Convert_Int64(this.Cbo_Page.SelectedValue, 1);
            if (Page == this.mMaxPage)
            { return; }

            try { this.Cbo_Page.SelectedValue = Page + 1; }
            catch { }
        }

        void Btn_Last_Click(object sender, EventArgs e)
        {
            try { this.Cbo_Page.SelectedValue = this.mMaxPage; }
            catch { }
        }

        void Btn_First_Click(object sender, EventArgs e)
        {
            try { this.Cbo_Page.SelectedValue = 1; }
            catch { }
        }

        void Grid_AfterSort(object sender, FilterEventArgs e)
        {
            this.mSort = e.Condition;
        }

        void Grid_FetchRowStyle(object sender, FetchRowStyleEventArgs e)
        {
            try
            {
                C1TrueDBGrid Grid = (C1TrueDBGrid)sender;
                DataTable Dt_Source = (DataTable)Grid.DataSource;

                if (Dt_Source.Rows.Count <= e.Row)
                { return; }

                DataRow Dr = (Grid[e.Row] as DataRowView).Row;

                if (Dr.RowState == DataRowState.Added)
                { e.CellStyle.BackColor = Color.LightYellow; }
                else if (Dr.RowState == DataRowState.Modified)
                { e.CellStyle.BackColor = Color.PaleGreen; }

                if (this.Ev_FetchRowStyle != null)
                { this.Ev_FetchRowStyle(sender, e); }
            }
            catch { }
        }

        void Grid_KeyDown(object sender, KeyEventArgs e)
        {
            C1TrueDBGrid Grid = (C1TrueDBGrid)sender;

            if (Grid.DataSource == null)
            { return; }

            if (Grid.FilterActive)
            {
                if (e.KeyCode == System.Windows.Forms.Keys.Tab || e.KeyCode == System.Windows.Forms.Keys.Enter)
                {
                    SendKeys.Send(@"{Right}");
                    Grid.Refresh();
                }
            }
            else
            {
                switch (e.KeyCode)
                {
                    case System.Windows.Forms.Keys.Enter:
                        {
                            if (this.Ev_KeyEnter != null) { this.Ev_KeyEnter(); }
                            e.Handled = true;
                            break;
                        }

                    default:
                        {
                            if (e.Modifiers == System.Windows.Forms.Keys.Control && e.KeyCode == System.Windows.Forms.Keys.F)
                            {
                                Grid.FilterActive = true;
                                e.Handled = true;
                            }
                            else if (e.Modifiers == System.Windows.Forms.Keys.Control && e.KeyCode == System.Windows.Forms.Keys.Up)
                            {
                                String ColumnName = Grid.Splits[Grid.SplitIndex].DisplayColumns[Grid.Col].DataColumn.DataField;
                                (Grid.DataSource as DataTable).DefaultView.Sort = @"[" + ColumnName + "] Asc";
                                Grid.Splits[Grid.SplitIndex].DisplayColumns[Grid.Col].DataColumn.SortDirection = SortDirEnum.Ascending;
                                e.Handled = true;
                            }
                            else if (e.Modifiers == System.Windows.Forms.Keys.Control && e.KeyCode == System.Windows.Forms.Keys.Down)
                            {
                                String ColumnName = Grid.Splits[Grid.SplitIndex].DisplayColumns[Grid.Col].DataColumn.DataField;
                                (Grid.DataSource as DataTable).DefaultView.Sort = @"[" + ColumnName + "] Desc";
                                Grid.Splits[Grid.SplitIndex].DisplayColumns[Grid.Col].DataColumn.SortDirection = SortDirEnum.Descending;
                                e.Handled = true;
                            }
                            else if (
                                e.Modifiers == System.Windows.Forms.Keys.Control
                                &&
                                    (
                                    e.KeyCode == System.Windows.Forms.Keys.PageUp
                                    || e.KeyCode == System.Windows.Forms.Keys.Left
                                    )
                                )
                            {
                                Grid.MoveFirst();
                                e.Handled = true;
                            }
                            else if (
                                e.Modifiers == System.Windows.Forms.Keys.Control
                                &&
                                    (
                                    e.KeyCode == System.Windows.Forms.Keys.PageDown
                                    || e.KeyCode == System.Windows.Forms.Keys.Right
                                    )
                                )
                            {
                                Grid.MoveLast();
                                e.Handled = true;
                            }
                            else if (e.Modifiers == System.Windows.Forms.Keys.Control && e.KeyCode == System.Windows.Forms.Keys.D)
                            {
                                if (MessageBox.Show(@"Set Grid Defaults?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                { this.BindGrid(true); }
                                e.Handled = true;
                            }

                            break;
                        }
                }
            }
        }

        void Grid_RowColChange(object sender, RowColChangeEventArgs e)
        {
            C1TrueDBGrid Grid = (C1TrueDBGrid)sender;
            if (Grid.FilterActive)
            {
                Grid.Refresh();
                SendKeys.Send("{F2}");
            }
        }

        void Grid_Filter(object sender, FilterEventArgs e)
        {
            try { Layer01_Methods_C1.FilterGrid((C1TrueDBGrid)sender); }
            catch { }
        }

        #endregion

        #region _Methods

        public void Setup_FromBase(
            String GridName
            , ClsBase Datasource_Base
            , ClsBindGrid GridDefinition
            , List<String> List_TableKey = null
            , Boolean IsSelection = false
            , Boolean AllowSort = false
            , Boolean AllowPaging = false
            , Boolean IsDefault = false)
        {
            this.Setup(
                GridName
                , eSourceType.Base
                , Datasource_Base
                , GridDefinition
                , IsSelection
                , List_TableKey
                , AllowSort
                , AllowPaging
                , IsDefault);
        }

        public void Setup_FromDataTable(
            String GridName
            , DataTable DataSource_DataTable
            , ClsBindGrid GridDefinition
            , List<String> List_TableKey = null
            , Boolean IsSelection = false
            , Boolean AllowSort = false
            , Boolean AllowPaging = false
            , Boolean IsDefault = false)
        {
            this.Setup(
                GridName
                , eSourceType.DataTable
                , DataSource_DataTable
                , GridDefinition
                , IsSelection
                , List_TableKey
                , AllowSort
                , AllowPaging
                , IsDefault);
        }

        public void Setup_FromTable(
            String GridName
            , String Datasource_TableName
            , ClsBindGrid GridDefinition
            , List<String> List_TableKey = null
            , Boolean IsSelection = false
            , Boolean AllowSort = false
            , Boolean AllowPaging = false
            , Boolean IsDefault = false)
        {
            this.Setup(
                GridName
                , eSourceType.Table
                , Datasource_TableName
                , GridDefinition
                , IsSelection
                , List_TableKey
                , AllowSort
                , AllowPaging
                , IsDefault);
        }

        public void Setup_FromQuerySource(
            String GridName
            , Do_Constants.Str_QuerySource DataSource_QuerySource
            , ClsBindGrid GridDefinition
            , List<String> List_TableKey = null
            , Boolean IsSelection = false
            , Boolean AllowSort = false
            , Boolean AllowPaging = false
            , Boolean IsDefault = false)
        {
            this.Setup(
                GridName
                , eSourceType.QuerySource
                , DataSource_QuerySource
                , GridDefinition
                , IsSelection
                , List_TableKey
                , AllowSort
                , AllowPaging
                , IsDefault);
        }

        void Setup(
            String GridName
            , eSourceType SourceType
            , Object Datasource
            , ClsBindGrid GridDefinition
            , Boolean IsSelection = false
            , List<String> List_TableKey = null
            , Boolean AllowSort = false
            , Boolean AllowPaging = false
            , Boolean IsDefault = false)
        {
            this.mProperties = new UcGrid_Properties();
            this.mProperties.SourceType = SourceType;

            switch (SourceType)
            {
                case eSourceType.Base:
                    this.mProperties.Datasource_Base = (ClsBase)Datasource;
                    break;
                case eSourceType.DataTable:
                    this.mProperties.Datasource_Dt = (DataTable)Datasource;
                    break;
                case eSourceType.Table:
                    this.mProperties.Datasource_TableName = (String)Datasource;
                    break;
                case eSourceType.QuerySource:
                    this.mProperties.Datasource_QuerySource = (Do_Constants.Str_QuerySource)Datasource;
                    break;
            }

            this.mProperties.GridDefinition = GridDefinition;
            this.mProperties.IsSelection = IsSelection;
            //this.mProperties.TableKey = KeyName;
            this.mProperties.List_TableKey = List_TableKey;
            this.mProperties.AllowSort = AllowSort;
            this.mProperties.AllowPaging = AllowPaging;
            this.mProperties.GridName = GridName;

            this.BindGrid(IsDefault);

            this.Setup_EventHandlers();
        }

        void Setup_EventHandlers()
        {
            this.Grid.AfterSort += new FilterEventHandler(Grid_AfterSort);
            this.Grid.FetchRowStyle += new FetchRowStyleEventHandler(Grid_FetchRowStyle);
            this.Grid.KeyDown += new KeyEventHandler(Grid_KeyDown);
            this.Grid.RowColChange += new RowColChangeEventHandler(Grid_RowColChange);
            this.Grid.Filter += new FilterEventHandler(Grid_Filter);

            this.Cbo_Page.SelectedValueChanged += new EventHandler(Cbo_Page_SelectedValueChanged);
            this.Txt_Top.TextChanged += new EventHandler(Txt_Top_TextChanged);

            this.Btn_First.Click += new EventHandler(Btn_First_Click);
            this.Btn_Last.Click += new EventHandler(Btn_Last_Click);
            this.Btn_Next.Click += new EventHandler(Btn_Next_Click);
            this.Btn_Previous.Click += new EventHandler(Btn_Previous_Click);

            EventHandlerDelayer.Ds_EventHandler D_Txt_Top = new EventHandlerDelayer.Ds_EventHandler(this.Txt_Top_TextChanged_Ex);
            this.mEd_Txt_Top = new EventHandlerDelayer(500, D_Txt_Top, new Object[] { this.Txt_Top });
        }

        //[-]

        void BindGrid(Boolean IsDefault = false, Boolean IsPageChange = false)
        {
            Int64 Top = Do_Methods.Convert_Int64(this.Txt_Top.Text, 50);
            Int32 Page = Do_Methods.Convert_Int32(this.Cbo_Page.SelectedValue, 1);

            if (Top < 50)
            {
                Top = 50;
                this.Txt_Top.Text = Top.ToString();
            }

            Str_DataSource DataSource = this.GetDataSource(Top, Page);
            DataTable Dt_Source = DataSource.Dt_Source;
            Int64 SourceCount = DataSource.SourceCount;

            Boolean IsAllowPaging = false;

            if (this.mProperties.AllowPaging && (this.mProperties.SourceType != eSourceType.DataTable))
            { IsAllowPaging = true; }

            this.Panel_Paging.Visible = IsAllowPaging;

            if (IsAllowPaging)
            {
                if (!IsPageChange) { this.Pagination_SetPaginator(Top, SourceCount); }
                this.Pagination_ItemsCount(SourceCount);
                this.Panel_Grid.Dock = DockStyle.None;
            }
            else
            { this.Panel_Grid.Dock = DockStyle.Fill; }

            Layer01_Methods_C1.BindGrid(
                this.Grid
                , this.mProperties.GridName
                , Dt_Source
                , this.mProperties.GridDefinition
                , IsDefault
                , this.mProperties.IsSelection);
        }

        public void RebindGrid(QueryCondition Qc = null, Boolean IsPageChange = false)
        {
            if (this.Ev_PageChanging != null)
            { this.Ev_PageChanging(this); }

            if (Qc != null)
            { this.mQc = Qc; }

            this.BindGrid(false, IsPageChange);

            if (this.Ev_PageChanged != null)
            { this.Ev_PageChanged(this); }
        }

        Str_DataSource GetDataSource(Int64 Top, Int32 Page)
        {
            DataTable Dt_Source = null;
            Int64 SourceCount = 0;

            String Sort = this.GetSort();

            switch (this.mProperties.SourceType)
            {
                case eSourceType.Base:
                    Dt_Source = this.mProperties.Datasource_Base.List(this.mQc, Sort, Top, Page);
                    //SourceCount = this.mProperties.Datasource_Base.List_Count(this.mQc);
                    SourceCount = this.mProperties.Datasource_Base.List_Count();
                    break;

                case eSourceType.Table:
                    Dt_Source = Do_Methods.CreateDataAccess().List(this.mProperties.Datasource_TableName, this.mQc, Sort, Top, Page);
                    //SourceCount = Do_Methods.CreateDataAccess().List_Count(this.mProperties.Datasource_TableName, this.mQc);
                    SourceCount = Do_Methods.CreateDataAccess().List_Count(this.mProperties.Datasource_TableName);
                    break;

                case eSourceType.DataTable:
                    Dt_Source = this.mProperties.Datasource_Dt;
                    SourceCount = Dt_Source.Rows.Count;

                    if (this.mQc != null)
                    {
                        try { Dt_Source.DefaultView.RowFilter = this.mQc.GetQueryCondition_String(); }
                        catch { }
                    }
                    else
                    { Dt_Source.DefaultView.RowFilter = ""; }

                    Dt_Source.DefaultView.Sort = Sort;

                    break;

                case eSourceType.QuerySource:
                    Dt_Source = Do_Methods.CreateDataAccess().GetQuery(this.mProperties.Datasource_QuerySource, "", this.mQc, Sort, Top, Page);
                    SourceCount = Dt_Source.Rows.Count;
                    break;
            }

            return new Str_DataSource() { Dt_Source = Dt_Source, SourceCount = SourceCount };
        }

        String GetSort()
        {
            String Sort = "";
            String Comma = "";
            Boolean IsStart = false;
            foreach (C1DisplayColumn Item in this.Grid.Splits[0].DisplayColumns)
            {
                if (Item.DataColumn.SortDirection != SortDirEnum.None)
                {
                    Sort = Sort + Comma + " " + Item.DataColumn.DataField + " " + (Item.DataColumn.SortDirection == SortDirEnum.Ascending ? "" : "Desc");

                    if (!IsStart)
                    {
                        IsStart = true;
                        Comma = ",";
                    }
                }
            }

            return Sort;
        }

        void Pagination_SetPaginator(Int64 Top, Int64 SourceCount)
        {
            if (Top <= 0) { Top = 50; }
            Int64 Pages = SourceCount / Top;
            if ((SourceCount % Top) > 0)
            { Pages++; }

            if (Pages == 0)
            { Pages = 1; }

            this.mMaxPage = Pages;

            DataTable Dt_Page = new DataTable();
            Dt_Page.Columns.Add("Page", typeof(Int64));
            for (Int64 Ct = 1; Ct <= Pages; Ct++)
            { Do_Methods.AddDataRow(ref Dt_Page, new String[] { "Page" }, new object[] { Ct }); }

            this.Cbo_Page.SelectedValueChanged -= this.Cbo_Page_SelectedValueChanged;
            Layer01_Methods.BindCombo(this.Cbo_Page, Dt_Page, "Page", "Page");
            this.Cbo_Page.SelectedValueChanged += this.Cbo_Page_SelectedValueChanged;
        }

        void Pagination_ItemsCount(Int64 SourceCount)
        {
            Int64 Top = Do_Methods.Convert_Int64(this.Txt_Top.Text, 50);
            Int64 Page = 1;
            if (this.Cbo_Page.SelectedValue != null)
            { Page = Do_Methods.Convert_Int64(this.Cbo_Page.SelectedValue, 1); }

            this.Txt_Top.Text = Top.ToString();
            this.Cbo_Page.SelectedValue = Page;

            Int64 Items = SourceCount;
            Int64 Items_Start = (Top * (Page - 1)) + 1;
            Int64 Items_End = Top * Page;

            String PageDesc = "";

            if (Items == 0)
            { PageDesc = "No records shown."; }
            else
            {
                if (Items_End > Items)
                { Items_End = Items; }

                PageDesc =
                    @"Showing "
                    + Items_Start.ToString("#,##0")
                    + @" - "
                    + Items_End.ToString("#,##0")
                    + @" out of " + Items.ToString("#,##0");
            }

            this.Lbl_PageDesc.Text = PageDesc;
        }

        public void SaveGridDefinition()
        {
            ClsBindGrid GridDef = Layer01_Config.pGridCfg_Get(this.mProperties.GridName);

            Int32 OrderIndex = 1;
            foreach (C1DisplayColumn Grid_Column in this.Grid.Splits[0].DisplayColumns)
            {
                var GridDef_Column = GridDef.pColumn_Get(Grid_Column.DataColumn.DataField);
                if (GridDef_Column == null)
                { continue; }

                GridDef_Column.pWidth = Grid_Column.Width;
                GridDef_Column.pOrderIndex = OrderIndex;

                OrderIndex++;
            }

            Layer01_Config.pGridCfg_Set(this.mProperties.GridName, GridDef);
        }

        public DataRow GetSelected()
        {
            if (this.pGrid.DataSource == null)
            { return null; }

            if (this.pGrid.Bookmark == -1)
            { return null; }

            return (this.pGrid[this.pGrid.Bookmark] as DataRowView).Row;
        }

        #endregion

        #region _Properties

        public C1TrueDBGrid pGrid
        {
            get { return this.Grid; }
        }

        public DataTable pDt_Source
        {
            get
            {
                if (this.Grid.DataSource != null)
                { return (DataTable)this.Grid.DataSource; }
                else
                { return null; }
            }
        }

        public UcGrid_Properties pProperties 
        {
            get { return this.mProperties; }
        }

        #endregion

        #region _Internal

        public class UcGrid_Properties
        {
            #region _Variables

            public String GridName;

            public ClsBase Datasource_Base;
            public DataTable Datasource_Dt;
            public String Datasource_TableName;
            public Do_Constants.Str_QuerySource Datasource_QuerySource;

            public ClsBindGrid GridDefinition;
            public String TableKey;
            public List<String> List_TableKey;
            public Boolean IsSelection;
            public Boolean AllowSort;
            public Boolean AllowPaging;

            public UcGrid.eSourceType SourceType;

            #endregion
        }

        #endregion
    }
}
