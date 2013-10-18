using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataObjects_Framework.Common;
using DataObjects_Framework.Objects;
using Layer01_Common.Common;
using Layer01_Common.Objects;
using Layer02_Objects._System;
using Layer02_Objects.Base;
using Layer03_Desktop._System;

namespace Layer03_Desktop.Base
{
	public partial class FrmBaseList : Form
	{
		#region _Variables

		ClsBase mBase;
		Int64 mSystem_ModulesID;
		String mGridDef_Name;
		protected Boolean mIsReadOnly;
		
		#endregion

		#region _Constructor

		public FrmBaseList()
		{
			InitializeComponent();

			//[-]

			this.Load += new EventHandler(FrmBaseList_Load);
			this.FormClosing += new FormClosingEventHandler(FrmBaseList_FormClosing);

			this.Btn_New.Click += new EventHandler(Btn_New_Click);
			this.Btn_Open.Click += new EventHandler(Btn_Open_Click);
			this.Btn_Refresh.Click += new EventHandler(Btn_Refresh_Click);
			this.Btn_Print.Click += new EventHandler(Btn_Print_Click);
			this.Btn_Close.Click += new EventHandler(Btn_Close_Click);

			this.MnuMain_New.Click += new EventHandler(Btn_New_Click);
			this.MnuMain_Open.Click += new EventHandler(Btn_Open_Click);
			this.MnuMain_Refresh.Click += new EventHandler(Btn_Refresh_Click);
			this.MnuMain_Print.Click += new EventHandler(Btn_Print_Click);
			this.MnuMain_Close.Click += new EventHandler(Btn_Close_Click);

			this.Grid_List.pGrid.DoubleClick += new EventHandler(pGrid_DoubleClick);
			this.Grid_List.Ev_KeyEnter += new UserControls.UcGrid.Ds_Generic(Grid_List_Ev_KeyEnter);
		}

		#endregion

		#region _EventHandlers

		void FrmBaseList_Load(object sender, EventArgs e)
		{ 
			//For Designer View to work, uncomment return
			//return;

			this.SetupForm(); 
		}

		void FrmBaseList_FormClosing(object sender, FormClosingEventArgs e)
		{
            this.Grid_List.SaveGridDefinition();
		}

		void Btn_New_Click(object sender, EventArgs e)
		{
			try
			{ this.NewForm(); }
			catch (Exception Ex)
			{ Layer01_Methods.ErrorHandler(Ex, this.GetType().Name); }
		}

		void Btn_Open_Click(object sender, EventArgs e)
		{
			try
			{ this.OpenForm(); }
			catch (Exception Ex)
			{ Layer01_Methods.ErrorHandler(Ex, this.GetType().Name); }
		}

		void Btn_Refresh_Click(object sender, EventArgs e)
		{
			try
			{ this.SetupForm(); }
			catch (Exception Ex)
			{ Layer01_Methods.ErrorHandler(Ex, this.GetType().Name); }
		}

		void Btn_Print_Click(object sender, EventArgs e)
		{
			
		}

		void Btn_Close_Click(object sender, EventArgs e)
		{
			try { this.Close(); }
			catch { }
		}

		void FrmDetail_Ev_NewForm()
		{ this.NewForm(); }

		void FrmDetail_Ev_FormSaved(DataRow Dr_Obj)
		{
			//DataObjects_Framework.Objects.Keys Keys = this.mBase.GetKeys(Dr_Obj);
			//DataTable Dt_List = (DataTable)this.Grid_List.pGrid.DataSource;

			//StringBuilder Sb_Keys = new StringBuilder();
			//Sb_Keys.Append(@"1 = 1");
			//foreach (var Key in Keys.pName)
			//{ Sb_Keys.Append(@" And " + Key + @" = " + Do_Methods.Convert_Int64(Dr_Obj[Key])); }

			//DataRow[] Arr_Dr = Dt_List.Select(Sb_Keys.ToString());
			//if (Arr_Dr.Length > 0)
			//{
			//    foreach (DataColumn Dc in Arr_Dr[0].Table.Columns)
			//    {
			//        if (Keys.pName.Any(O => O == Dc.ColumnName)) { continue; }
			//        Arr_Dr[0][Dc.ColumnName] = Dr_Obj[Dc.ColumnName];
			//    }
			//}
			//else
			//{ Dt_List.Rows.Add(Dr_Obj.ItemArray); }
		}

		void FrmDetail_Ev_FormSaved(DataObjects_Framework.Objects.Keys Keys)
		{
			ClsBase Obj_Base = (ClsBase)Activator.CreateInstance(this.mBase.GetType(), new Object[] { null });
			Obj_Base.Load(Keys);
			
			DataRow Dr_Obj = Obj_Base.pDr;

			DataTable Dt_List = (DataTable)this.Grid_List.pGrid.DataSource;

			StringBuilder Sb_Keys = new StringBuilder();
			Sb_Keys.Append(@"1 = 1");
			foreach (var Key in Keys.pName)
			{ Sb_Keys.Append(@" And " + Key + @" = " + Do_Methods.Convert_Int64(Dr_Obj[Key])); }

			DataRow[] Arr_Dr = Dt_List.Select(Sb_Keys.ToString());
			if (Arr_Dr.Length > 0)
			{
				foreach (DataColumn Dc in Arr_Dr[0].Table.Columns)
				{
					if (Keys.pName.Any(O => O == Dc.ColumnName)) { continue; }
					Arr_Dr[0][Dc.ColumnName] = Dr_Obj[Dc.ColumnName];
				}
			}
			else
			{ Dt_List.Rows.Add(Dr_Obj.ItemArray); }
		}

		void Grid_List_Ev_KeyEnter()
		{
			try
			{ this.OpenForm(); }
			catch (Exception Ex)
			{ Layer01_Methods.ErrorHandler(Ex, this.GetType().Name); }
		}

		void pGrid_DoubleClick(object sender, EventArgs e)
		{
			try
			{ this.OpenForm(); }
			catch (Exception Ex)
			{ Layer01_Methods.ErrorHandler(Ex, this.GetType().Name); }
		}

		#endregion

		#region _Methods

		protected void Setup(
			ClsBase Base
			, String GridDefinition_Name
			, Int64 System_ModulesID)
		{
			this.mBase = Base;
			this.mGridDef_Name = GridDefinition_Name;
			this.mSystem_ModulesID = System_ModulesID;
		}

		protected virtual void SetupForm()
		{
			this.SetupForm_Grid();
			this.SetupForm_Styles_Begin();
		}

		void SetupForm_Grid()
		{
			ClsBindGrid GridDef = Layer03_Common.GetBindGrid(this.mGridDef_Name);
			this.Filter_List.Setup(GridDef, this.mBase.List_Empty());
			this.Grid_List.Setup_FromBase(this.GetType().Name + "_Grid", this.mBase, GridDef);
		}

		protected virtual void SetupForm_Styles() { }

		void SetupForm_Styles_Begin()
		{ 
			this.SetupForm_Styles();
			this.SetupForm_Styles_End();
		}

		void SetupForm_Styles_End()
		{ Layer03_Common.ApplyStyle(this.Panel_Main2); }

		void NewForm()
		{
			if (!this.Btn_New.Enabled) 
			{ return; }

			DataRow[] Arr_Modules = Layer03_Common.Dt_System_Modules.Select("System_ModulesID = " + this.mSystem_ModulesID);
			if (Arr_Modules.Length == 0)
			{ throw new Exception("FormDetail is not defined."); }

			String FormDetails = Do_Methods.Convert_String(Arr_Modules[0]["FormDetail"]);

			FrmBaseDetail FrmDetail = (FrmBaseDetail)this.GetType().Assembly.CreateInstance(
				this.GetType().Namespace + "." + FormDetails
				, false
				, System.Reflection.BindingFlags.CreateInstance
				, null
				, new Object[] { this.mSystem_ModulesID }
				, null
				, null);

			FrmDetail.LoadForm();
			FrmDetail.Ev_NewForm += new FrmBaseDetail.Ds_Generic(FrmDetail_Ev_NewForm);
			FrmDetail.Ev_FormSaved += new FrmBaseDetail.Ds_ObjectSaved(FrmDetail_Ev_FormSaved);
			FrmDetail.Show();
		}

		protected virtual void OpenForm()
		{
			if (!this.Btn_Open.Enabled)
			{ return; }

			DataRow Dr_Selected = this.Grid_List.GetSelected();

			if (Dr_Selected == null)
			{ throw new Exception("There is no record to open."); }

			DataRow[] Arr_Modules = Layer03_Common.Dt_System_Modules.Select("System_ModulesID = " + this.mSystem_ModulesID);
			if (Arr_Modules.Length == 0)
			{ throw new Exception("FormDetail is not defined."); }

			String FormDetails = Do_Methods.Convert_String(Arr_Modules[0]["FormDetail"]);

			FrmBaseDetail FrmDetail = (FrmBaseDetail)this.GetType().Assembly.CreateInstance(
				this.GetType().Namespace + "." + FormDetails
				, false
				, System.Reflection.BindingFlags.CreateInstance
				, null
				, new Object[] { this.mSystem_ModulesID }
				, null
				, null);

			FrmDetail.LoadForm(this.mBase.GetKeys(Dr_Selected));
			FrmDetail.Ev_NewForm += new FrmBaseDetail.Ds_Generic(FrmDetail_Ev_NewForm);
			FrmDetail.Ev_FormSaved += new FrmBaseDetail.Ds_ObjectSaved(FrmDetail_Ev_FormSaved);
			FrmDetail.Show();
		}

		#endregion
	}
}
