using Lending.Class;
using Lending.Functions;
using Lending.Functions.Models;
using System;
using System.Drawing;
using System.Linq;
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
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            Location = new Point(screenWidth - Width, 0);
            btnToggle.Location = new Point(0, btnToggle.Location.Y);
            PaneTable.Width = PaneAdd.Visible ? 801 : PaneMain.Width - btnToggle.Width - 5;
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

        private void Customer_Load(object sender, EventArgs e)
        {
            cBCountry.Items.AddRange(zzz_Addresses._placesList
                .Select(place => place.Country)
                .Distinct()
                .ToArray()
            );
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            PaneAdd.Visible = !PaneAdd.Visible;
            btnToggle.Location = new Point(PaneAdd.Visible ? PaneAdd.Width : 0, btnToggle.Location.Y);
            Extra.clear_contents(PaneAdd);

            PaneTable.Width = PaneAdd.Visible ? 801 : PaneMain.Width - btnToggle.Width - 5;
        }

        private void btn_UploadPhoto_Click(object sender, EventArgs e)
        {
            Extra.select_Img(pBCust);
        }

        private void cBCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBCountry.Text != null && cBCountry.Items.Count > 0)
            {
                cBProvince.Text = ""; cBProvince.Items.Clear();
                cBMun.Text = ""; cBMun.Items.Clear();
                cBBar.Text = ""; cBBar.Items.Clear();

                cBProvince.Items.AddRange(zzz_Addresses._placesList
                    .Where(place => place.Country == cBCountry.Text)
                    .Select(place => place.Province)
                    .OrderBy(province => province)
                    .Distinct()
                    .ToArray()
                );
            }
        }
        private void cBProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBProvince.Text != null && cBProvince.Items.Count > 0)
            {
                cBMun.Text = ""; cBMun.Items.Clear();
                cBBar.Text = ""; cBBar.Items.Clear();

                cBMun.Items.AddRange(zzz_Addresses._placesList
                    .Where(place => place.Province == cBProvince.Text)
                    .Select(place => place.Municipality)
                    .OrderBy(municipality => municipality)
                    .Distinct()
                    .ToArray()
                );

            }
        }
        private void cBMun_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBMun.Text != null && cBMun.Items.Count > 0)
            {
                cBBar.Text = ""; cBBar.Items.Clear();

                cBBar.Items.AddRange(zzz_Addresses._placesList
                    .Where(place => place.Municipality == cBMun.Text)
                    .Select(place => place.Barangay)
                    .OrderBy(barangay => barangay)
                    .Distinct()
                    .ToArray()
                );
            }
        }
    }
}
