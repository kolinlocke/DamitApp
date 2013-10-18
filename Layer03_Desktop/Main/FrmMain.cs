using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DataObjects_Framework.Common;
using Layer01_Common.Common;
using Layer02_Objects._System;
using Layer03_Desktop._System;
using Layer03_Desktop.Test;
using DataObjects_Framework.DataAccess;

namespace Layer03_Desktop.Main
{
    public partial class FrmMain : Form
    {
        #region _Variables

        ClsCurrentUser mCurrentUser;
        DataTable mDt_Modules;
        Int64 mCurrentModuleKey;
        List<Form> mLoadedForms = new List<Form>();

        #endregion

        #region _Constructor

        public FrmMain()
        {
            InitializeComponent();

            this.Load += new EventHandler(FrmMain_Load);
            this.Tv_Modules.NodeMouseDoubleClick += new TreeNodeMouseClickEventHandler(Tv_Modules_NodeMouseDoubleClick);
            this.Tv_Modules.KeyDown += new KeyEventHandler(Tv_Modules_KeyDown);

            this.MnuFile_Logoff.Click += new EventHandler(MnuFile_Logoff_Click);
            this.MnuFile_Close.Click += new EventHandler(MnuFile_Close_Click);

            //[-]

            this.MnuTest_Test.Click += new EventHandler(MnuTest_Test_Click);
        }

        #endregion

        #region _EventHandlers

        void FrmMain_Load(object sender, EventArgs e)
        {
            try { this.SetupForm(); }
            catch (Exception Ex) { throw Ex; }
        }

        void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form Form = (Form)sender;
            Form.FormClosed -= Form_FormClosed;
            this.mLoadedForms.Remove(Form);
        }

        void Tv_Modules_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                Int64 ModuleID = this.GetNodeKey(e.Node, this.Tv_Modules);
                this.SelectModule(ModuleID);                
            }
            catch (Exception Ex)
            { Layer01_Methods.ErrorHandler(Ex, this.GetType().Name); }
        }

        void Tv_Modules_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space))
            { return; }

            try
            {
                Int64 ModuleID = this.GetNodeKey(this.Tv_Modules.SelectedNode, this.Tv_Modules);
                this.SelectModule(ModuleID);                
            }
            catch (Exception Ex)
            { Layer01_Methods.ErrorHandler(Ex, this.GetType().Name); }
        }

        void MnuFile_Logoff_Click(object sender, EventArgs e)
        {
            try
            { this.Logoff(); }
            catch (Exception Ex)
            { Layer01_Methods.ErrorHandler(Ex, this.GetType().Name); }            
        }

        void MnuFile_Close_Click(object sender, EventArgs e)
        { this.Close(); }

        void MnuTest_Test_Click(object sender, EventArgs e)
        {
            //Test_Form3 Form = new Test_Form3();
            //Form.Show();

            //Interface_DataAccess Da = Do_Methods.CreateDataAccess();
            //Da.InvokeError();
        }

        #endregion

        #region _Methods

        void SetupForm()
        {
            Layer03_Common.CurrentUser = FrmMain_Mayari.Show(this);
            this.mCurrentUser = Layer03_Common.CurrentUser;
            if (!this.mCurrentUser.pIsLoggedIn)
            { 
                this.Close();
                return;
            }

            //[-]

            Layer03_Common.SetupApp(this.mCurrentUser);


            //[-]

            this.Tv_Modules.Nodes.Clear();
            this.mDt_Modules = Layer03_Common.Dt_System_Modules.Clone();
            this.mCurrentModuleKey = 0;
            this.GetMenus(this.mCurrentModuleKey);

            //[-]

            this.Lbl_Mayari.Text = @"May-Ari: " + Do_Methods.Convert_String(this.mCurrentUser.pDr_Mayari["Name"]);

            //[-]

            this.WindowState = FormWindowState.Maximized;
            this.Visible = true;
        }

        void GetMenus(Int64 ModuleID_Parent)
        {
            this.mCurrentModuleKey = ModuleID_Parent;

            DataRow[] Arr_Dr = Layer03_Common.Dt_System_Modules.Select(@"ISNULL(Parent_System_ModulesID,0) = " + ModuleID_Parent);
            TreeNodeCollection ModuleNodes = null;

            if (ModuleID_Parent == 0)
            { ModuleNodes = this.Tv_Modules.Nodes; }
            else
            {
                TreeNode[] Arr_Node = this.Tv_Modules.Nodes.Find(ModuleID_Parent.ToString(), true);
                if (Arr_Node.Length > 0)
                { ModuleNodes = Arr_Node[0].Nodes; }
            }

            this.mDt_Modules.Rows.Clear();
            foreach (DataRow Dr in Arr_Dr)
            {
                this.mDt_Modules.Rows.Add(Dr.ItemArray);
                string Inner_ModuleKey = Do_Methods.Convert_Int64(Dr["System_ModulesID"]).ToString();

                TreeNode Inner_Node = ModuleNodes.Add(
                    Do_Methods.Convert_Int64(Dr["System_ModulesID"]).ToString()
                    , Do_Methods.Convert_String(Dr["Name"])
                    , Do_Methods.Convert_Int32(Dr["IconIndex"])
                    , Do_Methods.Convert_Int32(Dr["IconIndex"]));

                TreeNode[] Arr_Node = this.Tv_Modules.Nodes.Find(Inner_ModuleKey, true);
                if (Arr_Node.Length > 0)
                {
                    DataRow[] Inner_Arr_Dr = Layer03_Common.Dt_System_Modules.Select(@"Parent_System_ModulesID = " + Do_Methods.Convert_Int64(Dr["System_ModulesID"]).ToString());
                    if (Inner_Arr_Dr.Length > 0)
                    {
                        if (Inner_Node != null)
                        { Inner_Node.Nodes.Add("Dummy", "[-]", 0); }
                    }
                }
            }
        }

        void SelectModule(Int64 ModuleID)
        {
            DataRow[] ArrDr_SelectedModule = Layer03_Common.Dt_System_Modules.Select("System_ModulesID = " + ModuleID.ToString());
            if (ArrDr_SelectedModule.Length > 0)
            {
                DataRow Dr_SelectedModule = ArrDr_SelectedModule[0];
                String ModuleName_List = Do_Methods.Convert_String(Dr_SelectedModule["FormList"]);
                String ModuleCode = Do_Methods.Convert_String(Dr_SelectedModule["Code"]);
                String FormName = ModuleName_List + ModuleCode;
                String Args = Do_Methods.Convert_String(Dr_SelectedModule["Arguments"]);

                if (ModuleName_List == "")
                { this.GetMenus(ModuleID); }
                else
                {
                    DataRow[] ArrDr_Sma = Layer03_Common.Dt_System_Modules_Access.Select("System_ModulesID = " + ModuleID + " And System_Modules_AccessLibID = 1");
                    if (ArrDr_Sma.Length > 0)
                    {
                        Form Form = this.mLoadedForms.FirstOrDefault(O => O.Name == FormName);
                        if (Form != null)
                        {
                            Form.Activate();
                            return;
                        }

                        Form = (Form)this.GetType().Assembly.CreateInstance(
                            this.GetType().Namespace + "." + ModuleName_List
                            , false
                            , System.Reflection.BindingFlags.CreateInstance
                            , null
                            , new Object[] { ModuleID, Args }
                            , null
                            , null);
                        Form.Name = FormName;

                        this.mLoadedForms.Add(Form);
                        Form.FormClosed += new FormClosedEventHandler(Form_FormClosed);
                        Form.Show();
                    }
                }
            }
        }

        Int64 GetNodeKey(TreeNode Node, TreeView Tv)
        {
            Int64 ModuleID = 0;

            foreach (DataRow Dr in Layer03_Common.Dt_System_Modules.Rows)
            {
                TreeNode FoundNode = null;
                TreeNode[] Nodes = Tv.Nodes.Find(Do_Methods.Convert_String(Dr["System_ModulesID"]), true);
                if (Nodes.Length > 0)
                { FoundNode = Nodes[0]; }
                else
                { continue; }

                if (ReferenceEquals(Node, FoundNode))
                {
                    ModuleID = Do_Methods.Convert_Int64(Dr["System_ModulesID"]);
                    break;
                }
            }

            return ModuleID;
        }

        void Logoff()
        {
            if (Application.OpenForms.Count > 1)
            {
                if (MessageBox.Show(@"There still open windows, log off?", "Log Off", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                { return; }
            }

            foreach (Form Item in Application.OpenForms)
            {
                if (Item.Name != this.Name)
                { Item.Close(); }
            }

            this.Visible = false;
            this.Refresh();
            this.SetupForm();
        }

        #endregion
    }
}
