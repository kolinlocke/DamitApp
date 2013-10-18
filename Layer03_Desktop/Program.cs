using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;
using DataObjects_Framework.Common;
using Layer01_Common.Common;

namespace Layer03_Desktop.Main
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Do_Globals.gSettings.pUseSoftDelete = true;
			//Do_Globals.gSettings.pConnectionString = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
			//Do_Globals.gSettings.pDataAccessType = Do_Constants.eDataAccessType.DataAccess_SqlServer;

			Do_Globals.gSettings.pDataAccessType = Do_Constants.eDataAccessType.DataAccess_WCF;
            Do_Globals.gSettings.pWcfAddress = @"http://localhost/Damit/WcfService.svc";
            //Do_Globals.gSettings.pWcfAddress = @"http://localhost:4802/WcfService.svc";

			Layer01_Startup.StartUp();

			//Test Connection String
			using (var Cn = Do_Methods.CreateConnection())
			{
				if (!Cn.Connect())
				{ throw new Exception("Unable to connect to database. Check connection string."); }
			}

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FrmMain());
			//Application.Run(new Test.Test_Form2());
		}
	}
}
