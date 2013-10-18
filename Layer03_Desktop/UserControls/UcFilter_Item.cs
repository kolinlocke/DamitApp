using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Layer01_Common.Objects;
using Layer03_Desktop._System;

namespace Layer03_Desktop.UserControls
{
    public partial class UcFilter_Item : UserControl, Interface_Style
    {
        #region _Interface_Style_Implementations

        StyleBase mStyleBase = new StyleBase();

        public StyleBase pStyleBase
        {
            get { return this.mStyleBase; }
        }

        public Layer03_Common.Str_Style pStyle
        {
            get { return this.pStyleBase.pStyle; }
            set { this.pStyleBase.pStyle = value; }
        }

        #endregion

        #region _Constructor

        public UcFilter_Item()
        {
            InitializeComponent();
            this.pStyleBase.Setup(this);
        }

        #endregion
    }
}
