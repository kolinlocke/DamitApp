using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Text;
using Layer03_Desktop._System;

namespace Layer03_Desktop._System
{
    public class Layer03_Styles
    {
        public virtual Layer03_Common.Str_Style Style_Label
        {
            get
            {
                return new Layer03_Common.Str_Style()
                {
                    Color = Color.FromKnownColor(KnownColor.Green),
                    Font = new Font(new FontFamily("Tahoma"), 8, FontStyle.Bold)
                };
            }
        }

        public virtual Layer03_Common.Str_Style Style_Button
        {
            get
            {
                return new Layer03_Common.Str_Style()
                {
                    Color = Color.FromKnownColor(KnownColor.DarkBlue),
                    Font = new Font(new FontFamily("Tahoma"), 8, FontStyle.Bold)
                };
            }
        }

        public virtual Layer03_Common.Str_Style Style_ComboBox
        {
            get
            {
                return new Layer03_Common.Str_Style()
                {
                    Color = Color.FromKnownColor(KnownColor.DarkBlue),
                    Font = new Font(new FontFamily("Tahoma"), 8, FontStyle.Bold)
                };
            }
        }

        public virtual Layer03_Common.Str_Style Style_Field_Label
        {
            get
            {
                return new Layer03_Common.Str_Style()
                {
                    Color = Color.FromKnownColor(KnownColor.Black),
                    Font = new Font(new FontFamily("Tahoma"), 8, FontStyle.Bold)
                };
            }
        }

        public virtual Layer03_Common.Str_Style Style_Field_Textbox
        {
            get
            {
                return new Layer03_Common.Str_Style()
                {
                    Color = Color.Black,
                    Font = new Font(new FontFamily("Tahoma"), 8, FontStyle.Regular)
                };
            }
        }
    }
}
