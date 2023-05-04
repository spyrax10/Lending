using Lending.Class;
using System;
using System.Windows.Forms;

namespace Lending
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        public void clrCusInfo()
        {
            btnCusReg.Text = "REGISTER";
            tBCusID.Text = "";
            Extra.clrCont(paneCusBody);
            Query.loadCount(cBCusCount);
            cBCusCount.SelectedIndex = 0;
            pBCusFace.Image = null;
        }

        private void mainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void mainFrm_Load(object sender, EventArgs e)
        {
            Query.loadCount(cBCusCount);
            cBCusCount.SelectedIndex = 0;
        }

        private void btnCusSelImg_Click(object sender, EventArgs e)
        {
            Query.updCusImg(pBCusFace, btnCusReg, tBCusID);
        }

        private void cBCusCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            Query.loadPro(cBCusCount, cBCusPro);
        }

        private void cBCusPro_SelectedIndexChanged(object sender, EventArgs e)
        {
            Query.loadMun(cBCusCount, cBCusPro, cBCusMun);
        }

        private void cBCusMun_SelectedIndexChanged(object sender, EventArgs e)
        {
            Query.loadBar(cBCusCount, cBCusPro, cBCusMun, cBCusBar);
        }

        private void btnCusReg_Click(object sender, EventArgs e)
        {
            if (tBCusFB.Text == "")
            {
                tBCusFB.Text = "N/A";
            }
            Query.createCusInfo(paneCusBody, tBCusFirst, tBCusMid, tBCusLast, tBCusMob, tBCusFB,
                cBCusCount, cBCusPro, cBCusMun, cBCusBar, tBCusPur, tBCusBal, 
                btnCusReg, tBCusID);
        }

        private void btnCusFirst_Click(object sender, EventArgs e)
        {
            Query.viewCusDet(2, tBCusID, tBCusFirst, tBCusMid, tBCusLast, tBCusMob, tBCusFB,
                cBCusCount, cBCusPro, cBCusMun, cBCusBar, tBCusPur, tBCusBal, pBCusFace, btnCusReg);
        }

        private void btnCusLast_Click(object sender, EventArgs e)
        {
            Query.viewCusDet(1, tBCusID, tBCusFirst, tBCusMid, tBCusLast, tBCusMob, tBCusFB,
                cBCusCount, cBCusPro, cBCusMun, cBCusBar, tBCusPur, tBCusBal, pBCusFace, btnCusReg);
        }

        private void btnCusPrev_Click(object sender, EventArgs e)
        {
            if (tBCusID.Text != "")
            {
                Query.viewCusDet(4, tBCusID, tBCusFirst, tBCusMid, tBCusLast, tBCusMob, tBCusFB,
                    cBCusCount, cBCusPro, cBCusMun, cBCusBar, tBCusPur, tBCusBal, pBCusFace, btnCusReg);
            }       
        }

        private void btnCusNxt_Click(object sender, EventArgs e)
        {
            if (tBCusID.Text != "")
            {
                Query.viewCusDet(3, tBCusID, tBCusFirst, tBCusMid, tBCusLast, tBCusMob, tBCusFB,
                    cBCusCount, cBCusPro, cBCusMun, cBCusBar, tBCusPur, tBCusBal, pBCusFace, btnCusReg);
            }   
        }

        private void btnCusAdd_Click(object sender, EventArgs e)
        {
            clrCusInfo();
        }
    }
}
