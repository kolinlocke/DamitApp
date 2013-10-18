using System;
using System.Windows.Forms;
using DataObjects_Framework.Common;
using Layer01_Common.Common;
using Layer02_Objects;
using Layer02_Objects._System;
using Layer02_Objects.Modules;
using Layer03_Desktop._System;

namespace Layer03_Desktop.Main
{
    public partial class FrmMain_Mayari : Form
    {
        #region _Variables

        Layer03_Styles mStyle = new Layer03_Styles();
        ClsMayari mObj_Mayari;
        ClsCurrentUser mCurrentUser = new ClsCurrentUser();

        #endregion

        #region _Constructor

        public FrmMain_Mayari()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form_Load);
        }

        #endregion

        #region _EventHandlers

        void Form_Load(object sender, EventArgs e)
        {
            this.Btn_Bago.Click += new EventHandler(Btn_Bago_Click);
            this.Btn_Piliin.Click += new EventHandler(Btn_Piliin_Click);

            //[-]

            try { this.SetupForm(); }
            catch (Exception Ex)
            { Layer01_Methods.ErrorHandler(Ex, this.GetType().Name); }            
        }

        void Btn_Piliin_Click(object sender, EventArgs e)
        {
            this.mCurrentUser.Login_Mayari(Do_Methods.Convert_Int64(this.Cbo_Mayari.SelectedValue));
            this.Close();
        }

        void Btn_Bago_Click(object sender, EventArgs e)
        {
            FrmMain_Mayari_Bago Frm = new FrmMain_Mayari_Bago();
            if (Frm.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            { this.SetupForm_Bind(); }
        }

        #endregion

        #region _Methods

        void SetupForm()
        { 
            this.SetupForm_Styles();
            this.SetupForm_Bind();
        }

        void SetupForm_Styles()
        {
            this.Lbl_Mayari.pStyle = this.mStyle.Style_Label;
            this.Btn_Piliin.pStyle = this.mStyle.Style_Button;
            this.Btn_Bago.pStyle = this.mStyle.Style_Button;
            this.Cbo_Mayari.pStyle = this.mStyle.Style_ComboBox;

            Layer03_Common.ApplyStyle(this.Panel);
        }

        void SetupForm_Bind()
        {
            this.mObj_Mayari = new ClsMayari(null);
            Layer01_Methods.BindCombo(this.Cbo_Mayari, this.mObj_Mayari.List(), "Name", "MayariID");
        }

        new public static ClsCurrentUser Show(IWin32Window Owner)
        {
            FrmMain_Mayari Frm = new FrmMain_Mayari();
            Frm.ShowDialog(Owner);
            return Frm.pCurrentUser;            
        }

        #endregion

        #region _Properties

        public ClsCurrentUser pCurrentUser
        {
            get { return this.mCurrentUser; }
        }

        #endregion
    }
}
