using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualBasic;
using Layer01_Common;
using Layer01_Common.Common;
//using Layer01_Common.DataAccess;
using Layer01_Common.Objects;
using Layer02_Objects;
using Layer02_Objects.Modules_Base;
using Layer02_Objects.Modules_Base.Abstract;
using Layer02_Objects.Modules_Base.Objects;
using Layer02_Objects._System;
using DataObjects_Framework;
using DataObjects_Framework.Common;
using DataObjects_Framework.Base;
using DataObjects_Framework.Objects;

namespace Layer02_Objects.Modules_Base.Abstract
{
    public abstract class ClsEntity: ClsBase
    {
        #region _Variables

        protected ClsParty mObj_Party;

        #endregion

        #region _Constructor

        protected virtual void Setup(Layer01_Common.Common.Layer01_Constants.eSystem_LookupPartyType pPartyType, ClsSysCurrentUser pCurrentUser = null, string pTableName = "", string pViewName = "")
        {
            base.Setup(pCurrentUser, pTableName, pViewName);
            this.mObj_Party = new ClsParty(pPartyType, this.mCurrentUser);
        }
        
        #endregion

        #region _Methods

        public override void Load(ClsKeys Keys = null)
        {
            base.Load(Keys);

            List<string> KeyNames = new List<string>();
            KeyNames.Add("PartyID");
            Keys = this.GetKeys(this.pDr, KeyNames);
            this.mObj_Party.Load(Keys);
        }

        public override bool Save(DataObjects_Framework.DataAccess.Interface_DataAccess Da = null)
        {
            this.mObj_Party.Save();
            this.pDr["PartyID"] = this.mObj_Party.pID;
            return base.Save(Da);
        }

        #endregion

        #region _Properties

        public DataRow pDr_RowProperty
        {
            get { return this.mObj_Party.pDr_RowProperty; }
        }

        public DataRow pDr_Party
        {
            get { return this.mObj_Party.pDr; }
        }

        public ClsParty pObj_Party
        {
            get { return this.mObj_Party; }
        }

        public DataRow pDr_Address
        {
            get { return this.mObj_Party.pDr_Address; }
        }

        public ClsAddress pObj_Address
        {
            get { return this.mObj_Party.pObj_Address; }
        }

        #endregion

    }
}
