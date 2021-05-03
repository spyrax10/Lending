using Lending.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lending
{
    public partial class mainFrm : Form
    {
        public mainFrm()
        {
            InitializeComponent();
        }

        public void clrCusInfo()
        {
            btnCusReg.Text = "REGISTER";
            tBCusID.Text = "";
            misc.clrCont(paneCusBody);
            dbQ.loadCount(cBCusCount);
            cBCusCount.SelectedIndex = 0;
            pBCusFace.Image = null;
        }

        private void mainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void mainFrm_Load(object sender, EventArgs e)
        {
            dbQ.loadCount(cBCusCount);
            cBCusCount.SelectedIndex = 0;
        }

        private void btnCusSelImg_Click(object sender, EventArgs e)
        {
            dbQ.updCusImg(pBCusFace, btnCusReg, tBCusID);
        }

        private void cBCusCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            dbQ.loadPro(cBCusCount, cBCusPro);
        }

        private void cBCusPro_SelectedIndexChanged(object sender, EventArgs e)
        {
            dbQ.loadMun(cBCusCount, cBCusPro, cBCusMun);
        }

        private void cBCusMun_SelectedIndexChanged(object sender, EventArgs e)
        {
            dbQ.loadBar(cBCusCount, cBCusPro, cBCusMun, cBCusBar);
        }

        private void btnCusReg_Click(object sender, EventArgs e)
        {
            if (tBCusFB.Text == "")
            {
                tBCusFB.Text = "N/A";
            }
            dbQ.createCusInfo(paneCusBody, tBCusFirst, tBCusMid, tBCusLast, tBCusMob, tBCusFB,
                cBCusCount, cBCusPro, cBCusMun, cBCusBar, tBCusPur, tBCusBal, 
                btnCusReg, tBCusID);
        }

        private void btnCusFirst_Click(object sender, EventArgs e)
        {
            dbQ.viewCusDet(2, tBCusID, tBCusFirst, tBCusMid, tBCusLast, tBCusMob, tBCusFB,
                cBCusCount, cBCusPro, cBCusMun, cBCusBar, tBCusPur, tBCusBal, pBCusFace, btnCusReg);
        }

        private void btnCusLast_Click(object sender, EventArgs e)
        {
            dbQ.viewCusDet(1, tBCusID, tBCusFirst, tBCusMid, tBCusLast, tBCusMob, tBCusFB,
                cBCusCount, cBCusPro, cBCusMun, cBCusBar, tBCusPur, tBCusBal, pBCusFace, btnCusReg);
        }

        private void btnCusPrev_Click(object sender, EventArgs e)
        {
            if (tBCusID.Text != "")
            {
                dbQ.viewCusDet(4, tBCusID, tBCusFirst, tBCusMid, tBCusLast, tBCusMob, tBCusFB,
                    cBCusCount, cBCusPro, cBCusMun, cBCusBar, tBCusPur, tBCusBal, pBCusFace, btnCusReg);
            }       
        }

        private void btnCusNxt_Click(object sender, EventArgs e)
        {
            if (tBCusID.Text != "")
            {
                dbQ.viewCusDet(3, tBCusID, tBCusFirst, tBCusMid, tBCusLast, tBCusMob, tBCusFB,
                    cBCusCount, cBCusPro, cBCusMun, cBCusBar, tBCusPur, tBCusBal, pBCusFace, btnCusReg);
            }   
        }

        private void btnCusAdd_Click(object sender, EventArgs e)
        {
            clrCusInfo();
        }
    }
}
