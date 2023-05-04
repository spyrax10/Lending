using System;
using System.Windows.Forms;
using Lending.Class;
using Lending.Functions;

namespace Lending
{
    public partial class Settings : Form
    {   
        public Settings()
        {
            InitializeComponent();
        }

        private void chkSQL_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSQL.Checked == true)
            {
                tBUser.Text = ""; tBUser.Enabled = false;
                tBPass.Text = ""; tBPass.Enabled = false; 
            }
            else
            {
                tBUser.Text = ""; tBUser.Enabled = true;
                tBPass.Text = ""; tBPass.Enabled = true;
            }
        }

        private void btnFoldPath_Click(object sender, EventArgs e)
        {
            tBPath.Text = Extra.pathFinder();
        }

        private void setFrm_Load(object sender, EventArgs e)
        {
            AppSettings.delAppSettings();
            cBServer.Items.AddRange(SQL.getSql().ToArray());
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            AppSettings.appSettings(cBServer.Text, tBUser.Text, tBPass.Text, tBPath.Text, chkSQL.Checked);
            Main.Enabled = false;

            if (SQL.connectionOpen())
            {
                Notification.Success("Connection Success!");
            }
            else
            {
                Notification.Error("Can't Connect to Server! Please try again later!");
            }

            Main.Enabled = true;
            AppSettings.delAppSettings();
        }

        private void setFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //misc.delAppSettings();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AppSettings.appSettings(cBServer.Text, tBUser.Text, tBPass.Text, tBPath.Text, chkSQL.Checked);
            Main.Enabled = false;

            if (SQL.connectionOpen())
            {
                Builder.CreateAppDatabase();
            }
            else
            {
                Notification.Error("Can't Connect to Server! Please try again later!");
            }

            Main.Enabled = true;
            AppSettings.delAppSettings();
        }

    }
}
