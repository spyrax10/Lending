using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lending.Forms
{
    public partial class Customer : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Click(object sender, EventArgs e)
        {
            this.BringToFront();
        }

        private void BTNClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Customer_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Customer_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Customer_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
