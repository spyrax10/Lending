using Lending.Class;
using Lending.Functions;
using System;
using System.Windows.Forms;

namespace Lending
{
    public partial class Dashboard2 : Form
    {
        public Dashboard2()
        {
            InitializeComponent();
        }

        public void clrCusInfo()
        {
            btnCusReg.Text = "REGISTER";
            tBCusID.Text = "";
            Extra.clear_contents(paneCusBody);
           
            cBCusCount.SelectedIndex = 0;
            pBCusFace.Image = null;
        }

        private void mainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void mainFrm_Load(object sender, EventArgs e)
        {
            
            cBCusCount.SelectedIndex = 0;
        }

        private void btnCusSelImg_Click(object sender, EventArgs e)
        {
            Query2.updCusImg(pBCusFace, btnCusReg, tBCusID);
        }

        private void cBCusCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cBCusPro_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cBCusMun_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnCusReg_Click(object sender, EventArgs e)
        {
            if (tBCusFB.Text == "")
            {
                tBCusFB.Text = "N/A";
            }
            Query2.createCusInfo(paneCusBody, tBCusFirst, tBCusMid, tBCusLast, tBCusMob, tBCusFB,
                cBCusCount, cBCusPro, cBCusMun, cBCusBar, tBCusPur, tBCusBal, 
                btnCusReg, tBCusID);
        }

        private void btnCusFirst_Click(object sender, EventArgs e)
        {
            Query2.viewCusDet(2, tBCusID, tBCusFirst, tBCusMid, tBCusLast, tBCusMob, tBCusFB,
                cBCusCount, cBCusPro, cBCusMun, cBCusBar, tBCusPur, tBCusBal, pBCusFace, btnCusReg);
        }

        private void btnCusLast_Click(object sender, EventArgs e)
        {
            Query2.viewCusDet(1, tBCusID, tBCusFirst, tBCusMid, tBCusLast, tBCusMob, tBCusFB,
                cBCusCount, cBCusPro, cBCusMun, cBCusBar, tBCusPur, tBCusBal, pBCusFace, btnCusReg);
        }

        private void btnCusPrev_Click(object sender, EventArgs e)
        {
            if (tBCusID.Text != "")
            {
                Query2.viewCusDet(4, tBCusID, tBCusFirst, tBCusMid, tBCusLast, tBCusMob, tBCusFB,
                    cBCusCount, cBCusPro, cBCusMun, cBCusBar, tBCusPur, tBCusBal, pBCusFace, btnCusReg);
            }       
        }

        private void btnCusNxt_Click(object sender, EventArgs e)
        {
            if (tBCusID.Text != "")
            {
                Query2.viewCusDet(3, tBCusID, tBCusFirst, tBCusMid, tBCusLast, tBCusMob, tBCusFB,
                    cBCusCount, cBCusPro, cBCusMun, cBCusBar, tBCusPur, tBCusBal, pBCusFace, btnCusReg);
            }   
        }

        private void btnCusAdd_Click(object sender, EventArgs e)
        {
            clrCusInfo();
        }

        private void btnCusTkeImg_Click(object sender, EventArgs e)
        {

        }
    }
}
