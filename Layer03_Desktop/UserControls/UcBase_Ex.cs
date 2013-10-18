using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Layer03_Desktop._System;

namespace Layer03_Desktop.UserControls
{
    public partial class UcBase_Ex : UserControl
    {
        Layer03_Common.Str_Style? mStyle = null ;

        public UcBase_Ex()
        {
            InitializeComponent();
            this.Load += new EventHandler(UcBase_Load);
        }

        void UcBase_Load(object sender, EventArgs e)
        { this.Setup_Style(); }

        public void Setup_Style()
        { UcBase_Ex.ApplyStyle(this, this.mStyle); }

        public Layer03_Common.Str_Style pStyle
        {
            get { return this.mStyle.HasValue ? this.mStyle.Value : new Layer03_Common.Str_Style(); }
            set { this.mStyle = value; }
        }

        static void ApplyStyle(Control C, Layer03_Common.Str_Style? Style)
        {
            if (Style == null) { return; }

            Layer03_Common.Str_Style Inner_Style = Style.Value;

            if (C.Controls.Count > 0)
            { UcBase_Ex.ApplyStyle(C, Style); }

            if (C is TextBox)
            {
                C.Font = Inner_Style.Font;
                C.ForeColor = Inner_Style.Color;
            }
        }

    }
}
