using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Layer02_Objects._System;
using Layer02_Objects.Base;
using System.Data;

namespace Layer02_Objects.Modules
{
    public class ClsPinalaba : ClsModule
    {
        #region _Constructor

        public ClsPinalaba(ClsCurrentUser CurrentUser)
        {
            this.Setup(CurrentUser, "Pinalaba", "uvw_Pinalaba");
            this.Setup_AddTableDetail("Pinalaba_Damit", "uvw_Pinalaba_Damit");
        }

        #endregion

        #region _Properties

        public DataTable pDt_Damit
        {
            get { return this.pTableDetail_Get("Pinalaba_Damit"); }
        }

        #endregion
    }
}
