using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualBasic;
using Layer01_Common;
using Layer01_Common.Common;
using Layer01_Common.Objects;
using Layer02_Objects;
using Layer02_Objects.Modules_Base;
using Layer02_Objects.Modules_Base.Abstract;
using Layer02_Objects.Modules_Base.Objects;
using Layer02_Objects._System;
using DataObjects_Framework;
using DataObjects_Framework.Base;
using DataObjects_Framework.Common;
using DataObjects_Framework.DataAccess;
using DataObjects_Framework.Connection;
using DataObjects_Framework.Objects;

namespace Layer02_Objects.Modules_Masterfiles
{
    public class ClsItem : ClsModule
    {
        #region _Constructor

        public ClsItem(ClsSysCurrentUser pCurrentUser)
        {
            this.Setup(pCurrentUser,  "Item", "uvw_Item");
            this.Setup_AddTableDetail("Item_Part", "uvw_Item_Part", "IsNull(IsDeleted,0) = 0");
            this.Setup_AddTableDetail("Item_Location", "uvw_Item_Location", "IsNull(IsDeleted,0) = 0");
            this.Setup_AddTableDetail("Item_Supplier", "uvw_Item_Supplier", "IsNull(IsDeleted,0) = 0");
        }

        #endregion

        #region _Methods

        public override bool Save(DataObjects_Framework.DataAccess.Interface_DataAccess Da = null)
        {
            bool Rv = base.Save(Da);

            Int64 ItemID = (Int64)Do_Methods.IsNull(this.pDr["ItemID"], 0);
            double Price = 0;
            DataTable Dt = Do_Methods_Query.ExecuteQuery("Select Top 1 Price From Item_PriceHistory Where ItemID = " + ItemID + " Order By DatePosted").Tables[0];
            if (Dt.Rows.Count > 0) Price = Convert.ToDouble(Do_Methods.IsNull(Dt.Rows[0]["Price"], 0));
            if (Price != Convert.ToDouble(Do_Methods.IsNull(this.pDr["Price"], 0))) this.UpdatePriceHistory(ItemID);

            return Rv;
        }

        //[-]

        public void UpdatePriceHistory(DataRow[] ArrDr_Item)
        {
            DateTime ServerDate = Layer03_Common.GetServerDate();

            ClsPreparedQuery Pq = new ClsPreparedQuery();
            Pq.pQuery = @"Insert Into Item_PriceHistory (ItemID, Price, EmployeeID_PostedBy, DatePosted) Values (@ItemID, @Price, @EmployeeID_PostedBy, @DatePosted)";
            Pq.Add_Parameter("ItemID", SqlDbType.BigInt);
            Pq.Add_Parameter("EmployeeID_PostedBy", SqlDbType.BigInt, 0, 0, 0, this.mCurrentUser.pDrUser["EmployeeID"]);
            Pq.Add_Parameter("DatePosted", SqlDbType.DateTime, 0, 0, 0, ServerDate);
            Pq.Add_Parameter("Price", SqlDbType.Decimal, 0, 18, 2);
            Pq.Prepare();

            foreach (DataRow Dr in ArrDr_Item)
            {
                Pq.pParameters["ItemID"].Value = Dr["ItemID"];
                Pq.pParameters["Price"].Value = Dr["Price"];
                Pq.ExecuteNonQuery();
            }
        }

        public void UpdatePriceHistory(Int64 ItemID)
        {
            DataTable Dt_Item = Do_Methods_Query.GetQuery("Item", "", "ItemID = " + ItemID);
            DataRow Dr_Item = null;
            if (Dt_Item.Rows.Count > 0) Dr_Item = Dt_Item.Rows[0];
            else return;

            DateTime ServerDate = Layer03_Common.GetServerDate();
            DataTable Dt_PriceHistory = Do_Methods_Query.GetQuery("Item_PriceHistory", "", "1 = 0");
            DataRow Dr_PriceHistory = Dt_PriceHistory.NewRow();

            Dr_PriceHistory["ItemID"] = ItemID;
            Dr_PriceHistory["Price"] = Dr_Item["Price"];
            Dr_PriceHistory["EmployeeID_PostedBy"] = this.mCurrentUser.pDrUser["EmployeeID"];
            Dr_PriceHistory["DatePosted"] = ServerDate;

            Interface_DataAccess Da = Do_Methods.CreateDataAccess();
            try
            {
                Da.Connect();
                Da.SaveDataRow(Dr_PriceHistory, "Item_PriceHistory");
            }
            catch { }
            finally
            { Da.Close(); }
        }

        #endregion

        #region _Properties

        public DataTable pDt_Part
        {
            get { return this.pTableDetail_Get("Item_Part"); }
        }

        public DataTable pDt_Location
        {
            get { return this.pTableDetail_Get("Item_Location"); }
        }

        public DataTable pDt_Supplier
        {
            get { return this.pTableDetail_Get("Item_Supplier"); }
        }

        #endregion
    }
}
