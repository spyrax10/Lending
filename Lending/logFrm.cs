using Lending.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lending
{
    public partial class logFrm : Form
    {
        public Mutex singleton = new Mutex(true, "Login");
        public logFrm()
        {
            InitializeComponent();
            if (!singleton.WaitOne(TimeSpan.Zero, true))
            {
                //there is already another instance running!
                Application.Exit();
                Environment.Exit(0);
            }
        }

        private void logFrm_Load(object sender, EventArgs e)
        {
            misc.runAdm();
            lblInfo.Visible = false;
        }

        private void tBPass2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                dbQ.chkLogIn(tBUser, tBPass, tBPass2, lblInfo, paneMain, this);
            }
        }

        private void logFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
