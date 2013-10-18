using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Layer03_Desktop._System;

namespace Layer03_Desktop.UserControls
{
    public class StyleBase
    {
        Layer03_Common.Str_Style? mStyle;
        Control mBaseControl;

        public void Setup(Control BaseControl)
        { this.mBaseControl = BaseControl; }

        public Layer03_Common.Str_Style? pStyle
        {
            get { return this.mStyle; }
            set { this.mStyle = value; }
        }

        public Control pBaseControl
        { 
            get { return this.mBaseControl; } 
        }
    }
}
