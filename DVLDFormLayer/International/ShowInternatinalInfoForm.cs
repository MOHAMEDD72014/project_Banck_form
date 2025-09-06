using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDFormLayer.International
{
    public partial class ShowInternatinalInfoForm : Form
    {
        int _LicenseID;
        public ShowInternatinalInfoForm(int LicenseID)
        {
            InitializeComponent();
            _LicenseID = LicenseID;
            showInternationalInfoControl1.LicenseID = _LicenseID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
