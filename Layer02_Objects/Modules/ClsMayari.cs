using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Layer02_Objects;
using Layer02_Objects.Base;
using Layer02_Objects._System;

namespace Layer02_Objects.Modules
{
    public class ClsMayari : ClsModule
    {
        public ClsMayari(ClsCurrentUser CurrentUser)
        {
            this.Setup(CurrentUser, "Mayari", "uvw_Mayari");
        }
    }
}
