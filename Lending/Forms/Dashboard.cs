using System;
using System.Windows.Forms;

namespace Lending.Forms
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void BTNClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ToolStripCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
            customer.BringToFront();
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            this.BringToFront();
        }
    }
}
