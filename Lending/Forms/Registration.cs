using Lending.Class;
using Lending.Functions;
using Lending.Functions.Models;
using System;
using System.Data;
using System.Linq;
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

            cBCountry.SelectedIndex = (int)(zzz_Addresses._placesList
                .FirstOrDefault(i => i.Country == "Philippines")?.ID) - 1;
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

                Extra.ErrorTextBox(PaneMain);
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

                Extra.ErrorTextBox(PaneMain);
            }
        }

        private void cBBar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Extra.ErrorTextBox(PaneMain);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (Extra.isEmptyFields(PaneAddress) || Extra.isEmptyFields(PaneContact) || 
                Extra.isEmptyFields(PaneInfo) || Extra.isEmptyFields(PaneMain))
            {
                Extra.ErrorTextBox(PaneMain);
                
                Notification.Invalid("Missing Fields...");
            }
            else if (!ChkTC.Checked)
            {
                Notification.Invalid("Please Read and Agree to our Terms & Conditions!");
            }
            else
            {
                Company company = new Company();

                company.Code = tBCode.Text;
                company.Name = tBName.Text;
                company.Last_Update = DateTime.Now.ToString("yyyy-MM-dd");

                Addresses addresses = new Addresses();

                addresses.Country = cBCountry.Text;
                addresses.Province = cBProvince.Text;
                addresses.Municipality = cBMun.Text;
                addresses.Barangay = cBBar.Text;
                addresses.Street = tBStreet.Text;
                addresses.ZipCode = tBZip.Text;
                addresses.Last_Update = DateTime.Now.ToString("yyyy-MM-dd");

                User user = new User();
                user.FirstName = tBFirstName.Text;
                user.MiddleName = tBMidName.Text;
                user.LastName = tBLastName.Text;
                user.Username = "admin";
                user.Password = Extra.GetMD5("Abcde12");
                user.Last_Update = DateTime.Now.ToString("yyyy-MM-dd");

                Contacts contacts = new Contacts();
                contacts.Email = tBEmail.Text;
                contacts.Mobile = tBMobile.Text;
                contacts.Type = 1;
                contacts.Last_Update = DateTime.Now.ToString("yyyy-MM-dd");

                company.CreateNewCompany(company, user, contacts);
            }
        }

        private void tBCode_KeyUp(object sender, KeyEventArgs e)
        {
            Extra.ErrorTextBox(PaneMain);
        }
    }
}
