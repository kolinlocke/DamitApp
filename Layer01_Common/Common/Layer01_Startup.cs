using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using DataObjects_Framework.Common;

namespace Layer01_Common.Common
{
    public class Layer01_Startup
    {
        public static void StartUp()
        {
            DirectoryInfo Di = new DirectoryInfo(Layer01_Constants.CnsPathAppRoot);
            if (!Di.Exists)
            { Di.Create(); }
        }
    }
}
