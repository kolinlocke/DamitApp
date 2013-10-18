using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using C1.Win.C1TrueDBGrid;
using DataObjects_Framework.Common;
using Layer01_Common.Common;
using Layer01_Common.Objects;

namespace Layer01_Common_C1
{
    public class Layer01_Methods_C1
    {
        public static void InitializeGrid(C1TrueDBGrid Grid)
        {
            Grid.GroupByAreaVisible = false;
            Grid.DataView = DataViewEnum.GroupBy;

            Grid.AllowFilter = false;
            Grid.FilterBar = true;
            Grid.AllowSort = true;

            Grid.ExtendRightColumn = false;
            Grid.MaintainRowCurrency = false;

            Grid.AllowHorizontalSplit = true;
            Grid.AllowVerticalSplit = true;

            Grid.MarqueeStyle = MarqueeEnum.HighlightCell;
            Grid.DirectionAfterEnter = DirectionAfterEnterEnum.MoveNone;
            Grid.TabAction = TabActionEnum.ControlNavigation;

            Grid.HighLightRowStyle.BackColor = Color.DarkGray;
            Grid.HighLightRowStyle.ForeColor = Color.White;

            Grid.AlternatingRows = true;
            //Grid.EvenRowStyle.BackColor = Color.White;
            //Grid.OddRowStyle.BackColor = Color.LightGray;
            
            Grid.EvenRowStyle.BackColor = Color.White;
            Grid.OddRowStyle.BackColor = Color.LightGray;

            Grid.AllowUpdate = false;
            Grid.AllowUpdateOnBlur = true;
            Grid.AllowDelete = false;
            Grid.AllowAddNew = false;

            Grid.ColumnFooters = false;
        }

        public static void SetGridColumnArrangement(C1TrueDBGrid Grid, List<String> List_ColumnName)
        {
            Int32 Ct = 0;
            foreach (String ColumnName in List_ColumnName)
            {
                C1DisplayColumn Dc = null;
                foreach (C1DisplayColumn Inner_Dc in Grid.Splits[0].DisplayColumns)
                {
                    if (ColumnName == Inner_Dc.DataColumn.DataField)
                    { 
                        Dc = Inner_Dc;
                        break;
                    }
                }

                if (Dc != null)
                {
                    foreach (Split S in Grid.Splits)
                    {
                        S.DisplayColumns.RemoveAt(S.DisplayColumns.IndexOf(Dc));
                        S.DisplayColumns.Insert(Ct, Dc);
                    }
                }
                Ct++;
            }
        }

        public static void BindGrid(
            C1TrueDBGrid Grid
            , String GridName
            , DataTable Dt_Source
            , ClsBindGrid GridDef
            , Boolean IsDefault = false
            , Boolean IsSelect = false)
        {
            ClsBindGrid GridDef_Cfg = Layer01_Config.pGridCfg_Get(GridName);
            
            if (((GridDef.pColumns.Count != GridDef_Cfg.pColumns.Count) || IsDefault))
            { 
                GridDef_Cfg.pColumns = GridDef.pColumns;
                Layer01_Config.pGridCfg_Set(GridName, GridDef_Cfg);
            }
            
            if (IsSelect)
            {
                if (!Dt_Source.Columns.Contains("IsSelect"))
                { Dt_Source.Columns.Add("IsSelect", typeof(Boolean)); }

                foreach (DataRow Dr in Dt_Source.Rows)
                { Dr["IsSelect"] = false; }

                foreach (var Item in GridDef_Cfg.pColumns)
                { Item.pOrderIndex++; }
                
                ClsBindGridColumn Gc_New = new ClsBindGridColumn();
                GridDef_Cfg.pColumns.Add(Gc_New);
                
                Gc_New.pFieldName = "IsSelect";
                Gc_New.pFieldDesc = "Is Select?";
                Gc_New.pWidth = 80;
                Gc_New.pHorizontalAlign = Layer01_Constants.eSystem_Lookup_HorizontalAlign.Grid_HorizontalAlign_Center;
                Gc_New.pOrderIndex = 0;
            }
            
            InitializeGrid(Grid);

            Grid.DataSource = Dt_Source;
            Grid.Splits[0].CaptionHeight = 45;

            BindGrid_SetColumns(Grid, GridDef_Cfg);
        }

        public static void BindGrid_SetColumns(
            C1TrueDBGrid Grid
            , ClsBindGrid GridDef)
        {
            List<ClsBindGridColumn> GridDef_Columns = GridDef.pColumns;
            List<String> List_Columns = (from O in GridDef_Columns orderby O.pOrderIndex select O.pFieldName).ToList();
            SetGridColumnArrangement(Grid, List_Columns);

            foreach (Split Sp in Grid.Splits)
            {
                foreach (C1DisplayColumn Dc in Sp.DisplayColumns)
                {
                    var Inner_ItemColumn = GridDef_Columns.FirstOrDefault(O => O.pFieldName == Dc.DataColumn.DataField);
                    if (Inner_ItemColumn != null)
                    {
                        Dc.Width = Inner_ItemColumn.pWidth;
                        Dc.DataColumn.Caption = Inner_ItemColumn.pFieldDesc;
                        Dc.Locked = !Inner_ItemColumn.pIsEnabled;
                        Dc.FetchStyle = true;

                        switch (Inner_ItemColumn.pHorizontalAlign)
                        {
                            case Layer01_Constants.eSystem_Lookup_HorizontalAlign.Grid_HorizontalAlign_Center:
                                Dc.Style.HorizontalAlignment = AlignHorzEnum.Center;
                                break;
                            case Layer01_Constants.eSystem_Lookup_HorizontalAlign.Grid_HorizontalAlign_Far:
                                Dc.Style.HorizontalAlignment = AlignHorzEnum.Far;
                                break;
                            case Layer01_Constants.eSystem_Lookup_HorizontalAlign.Grid_HorizontalAlign_General:
                                Dc.Style.HorizontalAlignment = AlignHorzEnum.General;
                                break;
                            case Layer01_Constants.eSystem_Lookup_HorizontalAlign.Grid_HorizontalAlign_Justify:
                                Dc.Style.HorizontalAlignment = AlignHorzEnum.Justify;
                                break;
                            case Layer01_Constants.eSystem_Lookup_HorizontalAlign.Grid_HorizontalAlign_Near:
                                Dc.Style.HorizontalAlignment = AlignHorzEnum.Near;
                                break;
                            default:
                                Dc.Style.HorizontalAlignment = AlignHorzEnum.Justify;
                                break;
                        }

                        switch (Inner_ItemColumn.pFieldType)
                        { 
                            case Layer01_Constants.eSystem_Lookup_FieldType.FieldType_Button:
                                Dc.ButtonAlways = true;
                                Dc.ButtonText = true;                                
                                Dc.Locked = true;
                                Dc.Frozen = true;
                                
                                break;
                        }
                    }
                    else
                    {
                        Dc.Visible = false;
                        Dc.AllowSizing = false;
                    }

                    Dc.HeadingStyle.HorizontalAlignment = AlignHorzEnum.Justify;
                }
            }
        }

        public static void FilterGrid(C1TrueDBGrid Grid)
        {
            try 
            {
                StringBuilder Filter = new StringBuilder();
                Filter.Append(@"1 = 1");

                foreach (C1DataColumn Col in Grid.Columns)
                {
                    if (Col.FilterText.Trim() != "")
                    {
                        Type DataType = (Grid.DataSource as DataTable).Columns[Col.DataField].DataType;
                        if (DataType.Name == typeof(String).Name)
                        { Filter.Append(@" And [" + Col.DataField + @"] Like '" + Col.FilterText + @"%'"); }
                        else
                        {
                            String TmpFilter = Col.FilterText;
                            if (Do_Methods.ParseFilterText(ref TmpFilter, DataType))
                            { Filter.Append(@" And [" + Col.DataField + @"] " + TmpFilter + @""); }
                        }
                    }
                }

                (Grid.DataSource as DataTable).DefaultView.RowFilter = Filter.ToString();
            }
            catch { }
        }
    }
}
