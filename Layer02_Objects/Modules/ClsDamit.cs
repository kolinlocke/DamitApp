using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Layer02_Objects.Base;
using Layer02_Objects._System;

namespace Layer02_Objects.Modules
{
    public class ClsDamit : ClsModule
    {
        public ClsDamit(ClsCurrentUser CurrentUser)
        {
            this.Setup(CurrentUser, "Damit", "uvw_Damit");
        }
    }
}
