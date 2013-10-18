﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Layer03_Desktop._System;

namespace Layer03_Desktop.UserControls
{
    public class UcTabControl : TabControl, Interface_Style
    {
        StyleBase mStyleBase = new StyleBase();

        public UcTabControl()
        {
            this.pStyleBase.Setup(this);   
        }

        public StyleBase pStyleBase
        {
            get { return this.mStyleBase; }
        }

        public Layer03_Common.Str_Style? pStyle
        {
            get { return this.pStyleBase.pStyle; }
            set { this.pStyleBase.pStyle = value; }
        }
    }
}