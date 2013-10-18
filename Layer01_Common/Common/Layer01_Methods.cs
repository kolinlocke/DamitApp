using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using DataObjects_Framework;
using DataObjects_Framework.Common;
using Microsoft.VisualBasic;
using System.IO;

namespace Layer01_Common.Common
{
    public class Layer01_Methods
    {
        public static void BindCombo(ComboBox Cbo, DataTable Dt, string DisplayField, string ValueField)
        {
            //Cbo.DataSource = Dt;
            //Cbo.DisplayMember = DisplayField;
            //Cbo.ValueMember = ValueField;

            BindCombo(Cbo, (Object)Dt, DisplayField, ValueField);
        }

        public static void BindCombo(ComboBox Cbo, Object Source, string DisplayField, string ValueField)
        {
            Cbo.DataSource = Source;
            Cbo.DisplayMember = DisplayField;
            Cbo.ValueMember = ValueField;
        }

        public static void ErrorHandler(Exception Ex, string ModuleName)
        {
            MessageBox.Show(Ex.Message, @"System Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            System.Diagnostics.Debug.Print(@"Error: " + Ex.Message);

            string St = @"Error Log: " + ModuleName + ": " + Ex.Message + " : " + Ex.Source + " : " + (Ex.TargetSite != null ? Ex.TargetSite.Name : "");
            Layer01_Methods.LogWrite(St);
        }

        public static void LogWrite(string Msg)
        {
            Msg = @"[" + DateTime.Now.ToString() + @"] " + Msg;
            string FileName = @"System Logs [" + string.Format("{0:yyyy.MM.dd}", DateTime.Now.ToString()) + @"].log";
            Do_Methods.LogWrite(Msg, Do_Methods.SetFolderPath(Application.StartupPath) + "System Logs");
        }
    }
}
