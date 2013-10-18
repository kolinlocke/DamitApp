using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using DataObjects_Framework.Common;
using Layer01_Common.Objects;

namespace Layer01_Common.Common
{
    public class Layer01_Config
    {
        public static void pGridCfg_Set(String GridName, ClsBindGrid Value)
        {
            List<ClsBindGrid> List_Grid = (List<ClsBindGrid>)Do_Methods.DeserializeObjectFromFile_Json(typeof(List<ClsBindGrid>), Layer01_Constants.CnsPathGridCfg);
            if (List_Grid == null)
            { List_Grid = new List<ClsBindGrid>(); }

            ClsBindGrid Grid = List_Grid.FirstOrDefault(O => O.pName == GridName);

            if (Grid == null)
            { List_Grid.Add(Value); }
            else
            { Grid.pColumns = Value.pColumns; }

            Do_Methods.SerializeObjectToFile_Json(List_Grid, Layer01_Constants.CnsPathGridCfg);
        }

        public static ClsBindGrid pGridCfg_Get(String GridName)
        {
            List<ClsBindGrid> List_Grid = Do_Methods.DeserializeObjectFromFile_Json<List<ClsBindGrid>>(Layer01_Constants.CnsPathGridCfg);
            if (List_Grid == null)
            { List_Grid = new List<ClsBindGrid>(); }

            ClsBindGrid Grid = List_Grid.FirstOrDefault(O => O.pName == GridName);

            if (Grid == null)
            { Grid = new ClsBindGrid() { pName = GridName }; }

            return Grid;
        }

        #region _Unused

        //public static void pGridCfg_Set(String GridName, DataTable Value)
        //{
        //    DataSet Ds = new DataSet("GridCfg");
        //    DataTable Dt = new DataTable(GridName);

        //    try
        //    {
        //        Ds.ReadXmlSchema(Layer01_Constants.CnsPathGridCfgSchema);
        //        Ds.ReadXml(Layer01_Constants.CnsPathGridCfg);
        //    }
        //    catch
        //    {
        //        Ds = new DataSet("GridCfg");

        //        FileInfo Fi_GridSchema = new FileInfo(Layer01_Constants.CnsPathGridCfgSchema);
        //        if (!Fi_GridSchema.Directory.Exists)
        //        { Fi_GridSchema.Directory.Create(); }

        //        FileInfo Fi_Grid = new FileInfo(Layer01_Constants.CnsPathGridCfg);
        //        if (!Fi_Grid.Directory.Exists)
        //        { Fi_Grid.Directory.Create(); }

        //        Ds.WriteXmlSchema(Layer01_Constants.CnsPathGridCfgSchema);
        //        Ds.WriteXml(Layer01_Constants.CnsPathGridCfg);
        //    }

        //    Dt = Ds.Tables[GridName];
        //    if (Dt == null)
        //    {
        //        Dt = new DataTable(GridName);
        //        Ds.Tables.Add(Dt);

        //        Dt.Columns.Add("FieldName", typeof(String));
        //        Dt.Columns.Add("FieldName_Desc", typeof(String));
        //        Dt.Columns.Add("Width", typeof(Int32));
        //        Dt.Columns.Add("NumberFormat", typeof(String));
        //        Dt.Columns.Add("System_LookupID_HorizontalAlign", typeof(Int32));
        //        Dt.Columns.Add("IsLocked", typeof(Boolean));
        //        Dt.Columns.Add("OrderIndex", typeof(Int32));
        //    }

        //    Boolean IsValid = true;
        //    foreach (DataColumn Dc in Dt.Columns)
        //    {
        //        if (!Value.Columns.Contains(Dc.ColumnName))
        //        {
        //            IsValid = false;
        //            break;
        //        }
        //    }

        //    if (!IsValid)
        //    { Value = Dt.Copy(); }

        //    Ds.Tables.Remove(Dt);
        //    Dt = Value.Copy();
        //    Ds.Tables.Add(Dt);
        //    Ds.WriteXmlSchema(Layer01_Constants.CnsPathGridCfgSchema);
        //    Ds.WriteXml(Layer01_Constants.CnsPathGridCfg);
        //}

        //public static DataTable pGridCfg_Get(String GridName)
        //{
        //    DataSet Ds = new DataSet("GridCfg");
        //    DataTable Dt = new DataTable(GridName);
        //    DataTable Dt_Default = new DataTable();

        //    try
        //    {
        //        Ds.ReadXmlSchema(Layer01_Constants.CnsPathGridCfgSchema);
        //        Ds.ReadXml(Layer01_Constants.CnsPathGridCfg);
        //    }
        //    catch
        //    {
        //        Ds = new DataSet("GridCfg");
        //        Ds.WriteXmlSchema(Layer01_Constants.CnsPathGridCfgSchema);
        //        Ds.WriteXml(Layer01_Constants.CnsPathGridCfg);
        //    }

        //    Dt = Ds.Tables[GridName];
        //    if (Dt == null)
        //    {
        //        Dt = new DataTable(GridName);
        //        Ds.Tables.Add(Dt);

        //        Dt.Columns.Add("FieldName", typeof(String));
        //        Dt.Columns.Add("FieldName_Desc", typeof(String));
        //        Dt.Columns.Add("Width", typeof(Int32));
        //        Dt.Columns.Add("NumberFormat", typeof(String));
        //        Dt.Columns.Add("System_LookupID_FieldType", typeof(Int32));
        //        Dt.Columns.Add("System_LookupID_HorizontalAlign", typeof(Int32));
        //        Dt.Columns.Add("IsLocked", typeof(Boolean));
        //        Dt.Columns.Add("OrderIndex", typeof(Int32));
        //    }

        //    return Dt;
        //}

        #endregion
    }
}
