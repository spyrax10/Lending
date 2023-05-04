using Lending.Class;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Lending
{
    public partial class Login : Form
    {
        public Mutex singleton = new Mutex(true, "Lending");
        public Login()
        {
            InitializeComponent();
            //if (!singleton.WaitOne(TimeSpan.Zero, true))
            //{
            //    //there is already another instance running!
            //    Environment.Exit(0);
            //    Application.Exit();
            //}
        }

        private void logFrm_Load(object sender, EventArgs e)
        {
            lblInfo.Visible = false;
        }

        private void tBPass2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Query.chkLogIn(tBUser, tBPass, tBPass2, lblInfo, paneMain, this);
            }
        }

        private void logFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
