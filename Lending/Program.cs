using Lending.Class;
using System;
using System.Collections.Generic;
using System.Linq;
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                if (misc.chkCon() != "" &&  misc.conStat() == true)
                {
                    Application.Run(new logFrm());
                }
                else
                {
                    Application.Run(new setFrm());
                }
            }
            catch (Exception e)
            {
                misc.errMsg(e.Message);
            }    
        }
    }
}
