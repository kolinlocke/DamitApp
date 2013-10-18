using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Layer02_Objects.Base;
using DataObjects_Framework.Common;

namespace Layer03_Desktop.UserControls
{
    public partial class UcToolStripDetailItem : UserControl
    {
        #region _Variables

        UcGrid mGrid;
        String mSelectionName;

        #endregion

        #region _Events

        public delegate void Ds_GenericWithSender(UcToolStripDetailItem Sender);
        public event Ds_GenericWithSender Ev_BeforeAddItem;
        public event Ds_GenericWithSender Ev_AfterAddItem;

        #endregion

        #region _Constructor

        public UcToolStripDetailItem()
        {
            InitializeComponent();

            this.Btn_Add.Click += new EventHandler(Btn_Add_Click);
            this.Btn_Import.Click += new EventHandler(Btn_Import_Click);
            this.Btn_ExcelExport.Click += new EventHandler(Btn_ExcelExport_Click);
            this.Btn_ExcelImport.Click += new EventHandler(Btn_ExcelImport_Click);
        }

        #endregion

        #region _EventHandlers

        void Btn_Add_Click(object sender, EventArgs e)
        { this.AddItem(); }

        void Btn_Import_Click(object sender, EventArgs e)
        { }

        void Btn_ExcelExport_Click(object sender, EventArgs e)
        { }

        void Btn_ExcelImport_Click(object sender, EventArgs e)
        { }

        #endregion

        #region _Methods

        public void Setup(UcGrid Grid, String SelectionName)
        {
            this.mGrid = Grid;
            this.mSelectionName = SelectionName;
        }

        void AddItem()
        {
            DataTable Dt_Source = this.mGrid.pDt_Source;
            var SelectionResult = FrmSelection.Show(this.mSelectionName, true);

            if (this.Ev_BeforeAddItem != null)
            { this.Ev_BeforeAddItem(this); }

            foreach (DataRow Dr_Selected in SelectionResult.Dt_Selected.Rows)
            {
                StringBuilder Sb_Condition = new StringBuilder();
                Sb_Condition.Append(@" 1 = 1 ");
                foreach (String Key in this.mGrid.pProperties.List_TableKey)
                { Sb_Condition.Append(@" And " + Key + @" = " + Do_Methods.Convert_Int64(Dr_Selected[Key]).ToString()); }

                if (Dt_Source.Select(Sb_Condition.ToString()).Count() == 0)
                { Dt_Source.Rows.Add(Dr_Selected.ItemArray); }
            }

            if (this.Ev_AfterAddItem != null)
            { this.Ev_AfterAddItem(this); }
        }

        #endregion
    }
}
