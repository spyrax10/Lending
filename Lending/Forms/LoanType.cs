using System;
using System.Windows.Forms;

namespace Lending.Forms
{
    public partial class LoanType : Form
    {
        public LoanType()
        {
            InitializeComponent();
            Screen primaryScreen = Screen.PrimaryScreen;
            this.Location = new System.Drawing.Point(0, primaryScreen.WorkingArea.Height - this.Height - 10);
        }

        private void BTNClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
