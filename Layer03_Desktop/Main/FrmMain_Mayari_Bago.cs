using System;
using System.Windows.Forms;
using Layer01_Common.Common;
using Layer02_Objects.Modules;
using Layer03_Desktop._System;

namespace Layer03_Desktop.Main
{
    public partial class FrmMain_Mayari_Bago : Form
    {
        #region _Variables

        Layer03_Styles mStyle = new Layer03_Styles();

        #endregion

        #region _Constructor

        public FrmMain_Mayari_Bago()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form_Load);
        }

        #endregion

        #region _EventHandlers

        void Form_Load(object sender, EventArgs e)
        {
            this.Btn_Tanggapin.Click += new EventHandler(Btn_Tanggapin_Click);
            this.Btn_Ikansela.Click += new EventHandler(Btn_Ikansela_Click);

            //[-]

            this.SetupForm();
        }

        void Btn_Ikansela_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void Btn_Tanggapin_Click(object sender, EventArgs e)
        {
            try { this.Process_Tanggapin(); }
            catch (Exception Ex) { Layer01_Methods.ErrorHandler(Ex, this.GetType().Name); }            
        }

        #endregion

        #region _Methods

        void SetupForm()
        {
            this.SetupForm_Styles();
        }

        void SetupForm_Styles()
        {
            this.Lbl_Pangalan.pStyle = this.mStyle.Style_Label;
            this.Btn_Tanggapin.pStyle = this.mStyle.Style_Button;
            this.Btn_Ikansela.pStyle = this.mStyle.Style_Button;

            Layer03_Common.ApplyStyle(this);
        }

        void Process_Tanggapin()
        {
            ClsMayari Obj_Mayari = new ClsMayari(null);
            Obj_Mayari.Load();
            Obj_Mayari.pDr_RowProperty["Name"] = this.Txt_Pangalan.Text;
            Obj_Mayari.Save();

            this.DialogResult = DialogResult.OK;
        }

        #endregion
    }
}
