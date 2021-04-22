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
    public partial class logFrm : Form
    {
        public logFrm()
        {
            InitializeComponent();
        }

        private void logFrm_Load(object sender, EventArgs e)
        {
            lblInfo.Visible = false;
        }
    }
}
