using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualBasic;
using Layer01_Common;
using Layer01_Common.Common;
using Layer02_Objects;
using Layer02_Objects._System;
using DataObjects_Framework;
using DataObjects_Framework.Common;
using DataObjects_Framework.DataAccess;
using DataObjects_Framework.BaseObjects;

namespace Layer02_Objects.Base
{
    public class ClsBase : DataObjects_Framework.BaseObjects.Base
    {
        #region _Variables

        protected ClsCurrentUser mCurrentUser;
        protected bool mIsCache = false;
        
        #endregion

        #region _Methods

        protected virtual void Setup(ClsCurrentUser CurrentUser, string TableName, string ViewName ="")
        {
            base.Setup(TableName, ViewName);
            this.mCurrentUser = CurrentUser;
        }

        protected void Setup_EnableCache()
        { this.mIsCache = true; }

        public override void Load(DataObjects_Framework.Objects.Keys Keys = null)
        {
            Interface_DataAccess Da = Do_Methods.CreateDataAccess();

            try
            {
                if (this.mIsCache)
                { Da.Connect(Do_Methods.Convert_String(Do_Globals.gSettings.pCollection[Layer01_Constants.CnsConnectionString_Cache])); }
                else
                { Da.Connect(); }

                base.Load(Da, Keys);
            }
            catch (Exception Ex) { throw Ex; }
            finally { Da.Close(); }
        }

        #endregion

        #region _Properties

        public ClsCurrentUser pCurrentUser
        {
            get { return this.mCurrentUser; }
        }

        #endregion
    }
}
