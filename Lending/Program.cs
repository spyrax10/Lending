using Lending.Class;
using Lending.Functions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lending
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Extra.runAsAdministrator();
            Extra.createLogFolder();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                if (SQL.connectionString() != "")
                {
                    Application.Run(new Login());
                }
                else
                {
                    Application.Run(new Settings());
                }
            }
            catch (Exception e)
            {
                Notification.Error(e.Message);
            }    
        }
    }
}
