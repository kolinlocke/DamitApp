using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Layer01_Common;
using Layer01_Common.Common;
using Layer02_Objects;
using Layer02_Objects._System;
using DataObjects_Framework;
using DataObjects_Framework.Connection;
using DataObjects_Framework.Common;
using DataObjects_Framework.Objects;
using DataObjects_Framework.DataAccess;

namespace Layer02_Objects._System
{
    public class Layer02_Common
    {
        public static DateTime GetServerDate(Interface_DataAccess Da)
        {
            DataTable Dt = Da.ExecuteQuery("Select GetDate() As ServerDate").Tables[0];
            if (Dt.Rows.Count > 0) return (DateTime)Dt.Rows[0][0];
            else return DateTime.Now;
        }

        public static DateTime GetServerDate()
        {
            //Interface_Connection Da = Do_Methods.CreateConnection();
            //try
            //{
            //    Da.Connect();
            //    return GetServerDate(Da);
            //}
            //catch (Exception ex)
            //{ throw ex; }
            //finally
            //{ Da.Close(); }

            //[-]

            using (Interface_DataAccess Da = Do_Methods.CreateDataAccess())
            { return GetServerDate(Da); }
        }

        public static string GetSeriesNo(string Name)
        {
            string Rv = "";
            DataTable Dt;
            string TableName;
            string FieldName;
            string Prefix;
            Int32 Digits;

            Dt = Do_Methods_Query.GetQuery("System_DocumentSeries", "", "ModuleName = '" + Name + "'");
            if (Dt.Rows.Count > 0)
            {
                TableName = (string)Do_Methods.IsNull(Dt.Rows[0]["TableName"], "");
                FieldName = (string)Do_Methods.IsNull(Dt.Rows[0]["FieldName"], "");
                Prefix = (string)Do_Methods.IsNull(Dt.Rows[0]["Prefix"], "");
                Digits = (Int32)Do_Methods.IsNull(Dt.Rows[0]["Digits"], "");
            }
            else
            { return Rv; }

            List<QueryParameter> Sp = new List<QueryParameter>();
            Sp.Add(new QueryParameter("@TableName", TableName));
            Sp.Add(new QueryParameter("@FieldName", FieldName));
            Sp.Add(new QueryParameter("@Prefix", Prefix));
            Sp.Add(new QueryParameter("@Digits", Digits));

            Dt = Do_Methods_Query.ExecuteQuery("usp_GetSeriesNo", Sp).Tables[0];
            if (Dt.Rows.Count > 0)
            { Rv = (string)Dt.Rows[0][0]; }

            return Rv;
        }

        public static bool CheckSeriesDuplicate(
            string TableName
            , string SeriesField
            , Keys Keys
            , string SeriesNo)
        {
            bool Rv = false;
            DataTable Dt;

            System.Text.StringBuilder Sb_Query_Key = new StringBuilder();
            string Query_Key = "";
            string Query_And = "";

            foreach (string Inner_Key in Keys.pName)
            {
                Sb_Query_Key.Append(Query_And + " " + Inner_Key + " = " + Keys[Inner_Key]);
                Query_And = " And ";
            }

            Query_Key = " 1 = 1 ";
            if (Sb_Query_Key.ToString() != "")
            { Query_Key = "(Not (" + Sb_Query_Key.ToString() + "))"; }

            Dt = Do_Methods_Query.GetQuery(
                "[" + TableName + "]"
                , "Count(1) As [Ct]"
                , Query_Key + " And " + SeriesField + " = '" + SeriesNo + "'");
            if (Dt.Rows.Count > 0)
            {
                if ((Int32)Dt.Rows[0][0] > 0)
                { Rv = true; }
            }

            //True means duplicates have been found
            return Rv;
        }

        public static DataTable GetLookup(String Name)
        { return Do_Methods_Query.GetQuery("udf_Lookup('" + Name + "')", "", "", "[Desc]"); }

        public static DataTable GetSystemLookup(String Name)
        { return Do_Methods_Query.GetQuery("udf_System_Lookup('" + Name + "')", "", "", "[OrderIndex]"); }
    }
}
