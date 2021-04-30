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

        private void mainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Restart();
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
            dbQ.createCusInfo(paneCusBody, tBCusFirst.Text, tBCusMid.Text, tBCusLast.Text, tBCusMob.Text, tBCusFB.Text,
                cBCusCount.Text, cBCusPro.Text, cBCusMun.Text, cBCusBar.Text, tBCusPur.Text, tBCusBal, 
                btnCusReg, tBCusID);
        }
    }
}
