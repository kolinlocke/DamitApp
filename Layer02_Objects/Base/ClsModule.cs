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
using Layer02_Objects.Base;
using Layer02_Objects._System;
using DataObjects_Framework;
using DataObjects_Framework.Common;
using DataObjects_Framework.Objects;

namespace Layer02_Objects.Base
{
    public abstract class ClsModule: ClsBase
    {
        #region _Variables

        protected ClsRowProperty mObj_RowProperty;

        #endregion

        #region _Constructor

        protected override void Setup(ClsCurrentUser pCurrentUser, string pTableName = "", string pViewName = "")
        {
            base.Setup(pCurrentUser, pTableName, pViewName);
            this.mObj_RowProperty = new ClsRowProperty(this.mCurrentUser);
        }

        #endregion

        #region _Methods

        public override void Load(Keys Keys = null)
        {
            base.Load(Keys);

            List<string> KeyNames = new List<string>();
            KeyNames.Add("RowPropertyID");
            Keys = this.GetKeys(this.pDr, KeyNames);
            this.mObj_RowProperty.Load(Keys);
        }

        public override bool Save(DataObjects_Framework.DataAccess.Interface_DataAccess Da = null)
        {
            this.mObj_RowProperty.Save();
            this.pDr["RowPropertyID"] = this.mObj_RowProperty.pID;
            return base.Save(Da);
        }

        #endregion

        #region _Properties

        public DataRow pDr_RowProperty
        {
            get { return this.mObj_RowProperty.pDr; }
        }

        #endregion
    }
}
