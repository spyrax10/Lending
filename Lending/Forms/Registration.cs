using Lending.Functions.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lending.Forms
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            cBCountry.Items.AddRange(zzz_Addresses._placesList
                .Select(place => place.Country)
                .Distinct()
                .ToArray()
            );
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
                    .Distinct()
                    .ToArray()
                );
            }
        }
    }
}
