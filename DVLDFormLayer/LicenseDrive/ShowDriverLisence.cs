using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDFormLayer.LicenseDrive
{
    public partial class ShowDriverLisence : Form
    {
        int _LocalID;
        public ShowDriverLisence(int LocalID)
        {
            InitializeComponent();
            _LocalID = LocalID;
            showLicenseControl1.LocalID = _LocalID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
