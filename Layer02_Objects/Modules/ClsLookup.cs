using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DataObjects_Framework.Common;
using DataObjects_Framework.Objects;
using DataObjects_Framework.PreparedQueryObjects;
using Layer02_Objects._System;
using Layer02_Objects.Base;

namespace Layer02_Objects.Modules
{
    public class ClsLookup : ClsBase_List
    {
        #region _Variables

        Int64 mLookupID;

        #endregion

        #region _Constructor

        public ClsLookup(ClsCurrentUser CurrentUser, String TableName, String ViewName, Int64 LookupID)
        {
            this.mLookupID = LookupID;
            if (this.mLookupID != 0)
            { 
                TableName = "Lookup_Details";
                ViewName = "";
            }

            base.Setup(CurrentUser, TableName, ViewName);
        }

        #endregion

        #region _Methods

        public override void Load(Keys Keys)
        {
            String Condition = "";
            if (this.mLookupID != 0)
            { Condition = "LookupID = " + this.mLookupID.ToString(); }

            base.Load(Condition);
            this.mDt_List.Columns.Add("IsDuplicate", typeof(Boolean));
        }

        protected override void Save_Add()
        {
            if (this.mLookupID == 0)
            {
                foreach (DataRow Dr in base.mDt_List.Rows)
                {
                    ClsRowProperty Rp = new ClsRowProperty(this.mCurrentUser);
                    Keys Keys = new Keys();

                    Int64 RowPropertyID = Do_Methods.Convert_Int64(Dr["RowPropertyID"]);
                    if (RowPropertyID == 0) 
                    { Keys = null; }
                    else
                    { Keys.Add("RowPropertyID", RowPropertyID); }

                    Rp.Load(Keys);

                    Rp.pDr["Code"] = Do_Methods.Convert_String(Dr["Code"]);
                    Rp.pDr["Remarks"] = Do_Methods.Convert_String(Dr["Desc"]);

                    Rp.Save();
                    Dr["RowPropertyID"] = Rp.pDr["RowPropertyID"];
                }
            }
            else
            {
                foreach (DataRow Dr in base.mDt_List.Rows)
                { Dr["LookupID"] = this.mLookupID; }
            }
        }

        public Boolean CheckList()
        {
            Boolean IsFound = false;

            if (this.mLookupID == 0)
            {
                PreparedQuery Pq = this.mDa.CreatePreparedQuery();
                Pq.pQuery = @"Select Count(1) As [Ct] From " + this.mHeader_ViewName + @" Where Code = @Code And " + this.mHeader_Key[0] + " <> @Key";
                Pq.Add_Parameter(new QueryParameter() { Name = "Code", Type = Do_Constants.eParameterType.VarChar, Size = 1000 });
                Pq.Add_Parameter(new QueryParameter() { Name = "Key", Type = Do_Constants.eParameterType.Long });
                Pq.Prepare();

                DataRow[] ArrDr = this.mDt_List.Select("", "", DataViewRowState.CurrentRows);
                foreach (DataRow Dr in ArrDr)
                {
                    Pq.pParameter_Set("Code", Dr["Code"]);
                    Pq.pParameter_Set("Key", Dr[this.mHeader_Key[0]]);

                    Dr["IsDuplicate"] = false;

                    DataTable Dt = Pq.ExecuteQuery().Tables[0];
                    if (Dt.Rows.Count > 0)
                    {
                        if (Do_Methods.Convert_Int32(Dt.Rows[0][0]) > 0)
                        {
                            Dr["IsDuplicate"] = true;
                            IsFound = true;
                        }
                    }
                }
            }
            else
            {
                PreparedQuery Pq = this.mDa.CreatePreparedQuery();
                Pq.pQuery = "Select Count(1) From Lookup_Details Where [Desc] = @Desc And Lookup_DetailsID <> @ID";
                Pq.Add_Parameter(new QueryParameter() { Name = "Desc", Type = Do_Constants.eParameterType.VarChar, Size = 1000 });
                Pq.Add_Parameter(new QueryParameter() { Name = "ID", Type = Do_Constants.eParameterType.Long });

                Pq.Prepare();

                DataRow[] ArrDr = this.mDt_List.Select("", "", DataViewRowState.CurrentRows);
                foreach (DataRow Dr in ArrDr)
                {
                    Pq.pParameter_Set("Desc", Do_Methods.Convert_String(Dr["Desc"]));
                    Pq.pParameter_Set("ID", Do_Methods.Convert_Int64(Dr["Lookup_DetailsID"]));

                    Dr["IsDuplicate"] = false;
                    
                    DataTable Dt = Pq.ExecuteQuery().Tables[0];
                    if (Dt.Rows.Count > 0)
                    {
                        if (Do_Methods.Convert_Int32(Dt.Rows[0][0]) > 0)
                        {
                            Dr["IsDuplicate"] = true;
                            IsFound = true;
                        }
                    }
                }
            }

            return !IsFound;
        }

        #endregion
    }
}
