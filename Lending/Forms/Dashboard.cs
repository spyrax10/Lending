using Lending.Functions;
using System;
using System.Windows.Forms;

namespace Lending.Forms
{
    public partial class Dashboard : Form
    {

        public Dashboard()
        {
            InitializeComponent();
            Location = new System.Drawing.Point(0, 0);
        }

        private void BTNClose_Click(object sender, EventArgs e)
        {
            int openFormsCount = Application.OpenForms.Count - 1;

            if (openFormsCount > 0)
            {
                Notification.Invalid("Please Close the Open Forms!");
            }
            else
            {
                Application.Exit();
            }
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

        private void Dashboard_Load(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is Registration)
                {
                    form.Hide();
                    break;
                }
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int openFormsCount = Application.OpenForms.Count - 1;
            if (openFormsCount > 0)
            {
                Notification.Invalid("Please Close the Open Forms!");
            }
            else
            {
                this.Hide();
                Login login = new Login();
                login.Show();
            }
        }
    }
}
