using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DataObjects_Framework.Common;
using Layer01_Common.Common;
using Layer01_Common.Objects;
using Layer02_Objects._System;
using Layer03_Desktop.UserControls;

namespace Layer03_Desktop._System
{
    public class Layer03_Common
    {
        #region _Variables

        public static DataTable Dt_System_Modules;
        public static DataTable Dt_System_Modules_Access;
        public static ClsCurrentUser CurrentUser;

        public struct Str_Style
        {
            public Font Font;
            public Color Color;
            public BorderStyle BorderStyle;
            public FlatStyle FlatStyle;
        }

        #endregion

        #region _Methods

        public static void SetupApp(ClsCurrentUser CurrentUser)
        {
            Layer03_Common.Dt_System_Modules = Do_Methods_Query.GetQuery(
                "System_Modules"
                , ""
                , "IsNull(IsHidden,0) <> 1"
                , "Parent_System_ModulesID, OrderIndex");

            Layer03_Common.Dt_System_Modules_Access = Do_Methods_Query.GetQuery("uvw_System_Modules_AccessLib");

            Layer03_Common.CurrentUser = CurrentUser;
        }

        //[-]
        
        public static void ApplyStyle(Control C, Layer03_Common.Str_Style? Style)
        {
            if (Style == null) { return; }

            if (C.Controls.Count > 0)
            {
                foreach (Control Inner_C in C.Controls)
                { Layer03_Common.ApplyStyle(Inner_C, Style); }
            }

            Layer03_Common.ApplyStyle_Ex(C, Style);
        }

        public static void ApplyStyle(Control C)
        {
            if (C.Controls.Count > 0)
            {
                foreach (Control Inner_C in C.Controls)
                { Layer03_Common.ApplyStyle(Inner_C); }
            }

            if (!(C is Interface_Style)) { return; }

            Interface_Style Style_C = (Interface_Style)C;
            Layer03_Common.ApplyStyle_Ex(Style_C.pStyleBase.pBaseControl, Style_C.pStyleBase.pStyle);            
        }

        public static void ApplyStyle_Ex(Control C, Layer03_Common.Str_Style? Style)
        {
            if (Style == null) { return; }

            Layer03_Common.Str_Style Inner_Style = Style.Value;

            C.Font = Inner_Style.Font;
            C.ForeColor = Inner_Style.Color;
            
            if (C is Label)
            {
                Label Inner_C = (C as Label);
                //Inner_C.BorderStyle = Inner_Style.BorderStyle.HasValue ? Inner_Style.BorderStyle.Value : BorderStyle.None;
                Inner_C.BorderStyle = Inner_Style.BorderStyle;
            }
            else if (C is TextBox)
            {
                TextBox Inner_C = (C as TextBox);
            }
            else if (C is Button)
            {
                Button Inner_C = (C as Button);                
            }
            else if (C is ComboBox)
            {
                ComboBox Inner_C = (C as ComboBox);
                //Inner_C.FlatStyle = Inner_Style.FlatStyle.HasValue ? Inner_Style.FlatStyle.Value : FlatStyle.Popup;
                Inner_C.FlatStyle = Inner_Style.FlatStyle;
            }
        }

        //[-]

        public static ClsBindGrid GetBindGrid(String Name)
        {
            ClsBindGrid GridDef = new ClsBindGrid() { pName = Name };

            DataTable Dt_Def = Do_Methods_Query.GetQuery(@"System_BindDefinition", "", "Name = '" + Name + "'");
            if (Dt_Def.Rows.Count == 0)
            { throw new Exception("Specified BindDefinition not found."); }

            DataRow Dr_Def = Dt_Def.Rows[0];

            //GridDef.pTableName = Do_Methods.Convert_String(Dr_Def["TableName"]);
            //GridDef.pTableKey = Do_Methods.Convert_String(Dr_Def["TableKey"]);
            //GridDef.pDesc = Do_Methods.Convert_String(Dr_Def["Desc"]);
            //GridDef.pCondition = Do_Methods.Convert_String(Dr_Def["Condition"]);
            //GridDef.pSort = Do_Methods.Convert_String(Dr_Def["Sort"]);

            DataTable Dt_DefColumns = Do_Methods_Query.GetQuery(@"udf_System_BindDefinition('" + Name + @"')", "", "", "OrderIndex");
            foreach (DataRow Dr in Dt_DefColumns.Rows)
            {
                GridDef.pColumns.Add(new ClsBindGridColumn(
                    Do_Methods.Convert_String(Dr["Name"])
                    , Do_Methods.Convert_String(Dr["Desc"])
                    , Do_Methods.Convert_Int32(Dr["Width"])
                    , Do_Methods.Convert_String(Dr["NumberFormat"])
                    , Do_Methods.ParseEnum<Layer01_Constants.eSystem_Lookup_FieldType>(Do_Methods.Convert_String(Dr["System_LookupID_FieldType"]))
                    , Do_Methods.ParseEnum<Layer01_Constants.eSystem_Lookup_HorizontalAlign>(Do_Methods.Convert_String(Dr["System_LookupID_HorizontalAlign"]))
                    , !Do_Methods.Convert_Boolean(Dr["IsHidden"])
                    , !Do_Methods.Convert_Boolean(Dr["IsReadOnly"])
                    , Do_Methods.Convert_Boolean(Dr["IsFilter"])));
            }

            return GridDef;
        }

        public static void BindCombo_Lookup(ComboBox Cbo, String LookupName)
        {
            DataTable Dt_Lookup = Layer02_Common.GetLookup(LookupName);
            Layer01_Methods.BindCombo(Cbo, Dt_Lookup, "Desc", "LookupID");
        }

        #endregion
    }
}
