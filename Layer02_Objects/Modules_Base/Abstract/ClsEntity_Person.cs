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
using Layer02_Objects.Modules_Base;
using Layer02_Objects.Modules_Base.Abstract;
using Layer02_Objects.Modules_Base.Objects;
using Layer02_Objects._System;
using DataObjects_Framework;
using DataObjects_Framework.Common;
using DataObjects_Framework.Objects;

namespace Layer02_Objects.Modules_Base.Abstract
{
    public abstract class ClsEntity_Person: ClsEntity
    {
        #region _Variables

        protected ClsPerson mObj_Person;

        #endregion

        #region _Constructor

        protected override void Setup(Layer01_Common.Common.Layer01_Constants.eSystem_LookupPartyType pPartyType, ClsSysCurrentUser pCurrentUser = null, string pTableName = "", string pViewName = "")
        {
            base.Setup(pPartyType, pCurrentUser, pTableName, pViewName);
            this.mObj_Person = new ClsPerson(this.mCurrentUser);
        }
                
        protected override void Setup(ClsSysCurrentUser pCurrentUser, string pTableName = "", string pViewName = "")
        { throw new NotImplementedException(); }

        #endregion

        #region _Methods

        public override void Load(ClsKeys Keys = null)
        {
            base.Load(Keys);

            List<string> KeyNames = new List<string>();
            KeyNames.Add("PersonID");
            Keys = this.GetKeys(this.pDr, KeyNames);
            this.mObj_Person.Load(Keys);
        }

        public override bool Save(DataObjects_Framework.DataAccess.Interface_DataAccess Da = null)
        {
            this.mObj_Person.Save();
            this.pDr["PersonID"] = this.mObj_Person.pID;
            return base.Save(Da);
        }

        #endregion

        #region _Properties

        public DataRow pDr_Person
        {
            get { return this.mObj_Person.pDr; }
        }

        public ClsPerson pObj_Person
        {
            get { return this.mObj_Person; }
        }

        #endregion
    }
}
