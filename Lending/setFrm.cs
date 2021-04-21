using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lending.Class;

namespace Lending
{
    public partial class setFrm : Form
    {
        public setFrm()
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
            tBPath.Text = misc.pathFinder();
        }

        private void setFrm_Load(object sender, EventArgs e)
        {
            misc.runAdm();
            cBServer.Items.AddRange(misc.getSql().ToArray());
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (chkSQL.Checked == true)
            {
                if (tBPath.Text == "" && cBServer.Text == "")
                {
                    misc.invMsg("Missing Fields!");
                }
                else
                {
                    misc.appSettings(cBServer.Text, tBUser.Text, tBPass.Text, tBPath.Text, chkSQL);
                    paneMain.Enabled = false;
                    if (misc.conStat() == true)
                    {
                        misc.sucMsg("Connection Sucess!");
                        paneMain.Enabled = true;
                    }
                    else
                    {
                        misc.errMsg("Can't Connect to Server! Please try again later!");
                        paneMain.Enabled = true;
                    }
                }
            }
            else if (chkSQL.Checked == false)
            {
                if (misc.isEmptyFields(paneMain) == false)
                {
                    misc.appSettings(cBServer.Text, tBUser.Text, tBPass.Text, tBPath.Text, chkSQL);
                    paneMain.Enabled = false;
                    if (misc.conStat() == true)
                    {
                        misc.sucMsg("Connection Sucess!");
                        paneMain.Enabled = true;
                    }
                    else
                    {
                        misc.errMsg("Can't Connect to Server! Please try again later!");
                        paneMain.Enabled = true;
                    }
                }
                else
                {
                    misc.invMsg("Missing Fields!");
                }
            }
        }

        private void setFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            misc.delAppSettings();
        }
    }
}
