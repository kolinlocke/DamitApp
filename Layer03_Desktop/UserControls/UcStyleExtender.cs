using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using Layer03_Desktop;
using Layer03_Desktop._System;

namespace Layer03_Desktop.UserControls
{
    public class UcStyleExtender : Control, System.ComponentModel.IExtenderProvider
    {
        Layer03_Common.Str_Style mStyle;
        //string mStyleName = "";

        public bool CanExtend(object extendee)
        {
            return true;
        }

        public Layer03_Common.Str_Style pStyle
        {
            get { return this.mStyle; }
            set { this.mStyle = value; }
        }
    }
}
