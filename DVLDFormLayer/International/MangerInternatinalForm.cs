using DVLDBassnisLayer;
using DVLDFormLayer.LicenseDrive;
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
    public partial class MangerInternatinalForm : Form
    {
        public MangerInternatinalForm()
        {
            InitializeComponent();
            cbFilter.SelectedIndex = 0;
        }
        private void FilterINternatinalLoadInfo()
        {
            DataTable data = clsBassnisInternationalLicenses.GetAllInternationalLicenses();
            if (data.Rows.Count > 0)
            {


                DataView dataView = data.DefaultView;
                string ValueFilter = cbFilter.SelectedItem.ToString();
                if (ValueFilter == "None")
                {


                    txtSerch.Visible = false;
                    dgvInterntinal.DataSource = dataView.ToTable();


                }
                else
                {


                    dgvInterntinal.DataSource = dataView;
                    txtSerch.Visible = true;
                    dataView.RowFilter = $"CONVERT({ValueFilter},'System.String') LIKE '%{txtSerch.Text}%'";
                    dgvInterntinal.DataSource = dataView.ToTable();
                }

                lblRecordUser.Text = dataView.Count.ToString();
            }
        }
    
        private void MangerInternatinalForm_Load(object sender, EventArgs e)
        {
            FilterINternatinalLoadInfo();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterINternatinalLoadInfo();
        }

        private void txtSerch_TextChanged(object sender, EventArgs e)
        {
            FilterINternatinalLoadInfo();
        }

        private void tsmShowDetails_Click(object sender, EventArgs e)
        {
            int ApplicatinID = (int)dgvInterntinal.CurrentRow.Cells[1].Value;
            int PersonID = clsBassnisApplications.Find(ApplicatinID).ApplicantPersonID;
            PersonDetailsForm personDetailsForm = new PersonDetailsForm(PersonID);
            personDetailsForm.ShowDialog();
        }

        private void tsmShowLicinse_Click(object sender, EventArgs e)
        {
            ShowInternatinalInfoForm infoForm = new ShowInternatinalInfoForm((int)dgvInterntinal.CurrentRow.Cells[3].Value);
            infoForm.ShowDialog();
        }

        private void TsmHistory_Click(object sender, EventArgs e)
        {
           
            int ApplicatinID = (int)dgvInterntinal.CurrentRow.Cells[1].Value;
            int PersonID = clsBassnisApplications.Find(ApplicatinID).ApplicantPersonID;
            string NatinalNo = clsBassnisPersons.Find(PersonID).NationalNo;
            ApplicatinID = clsBassnisLicenses.Find((int)dgvInterntinal.CurrentRow.Cells[3].Value).ApplicationID; ;
            int LocalID = clsBassnisLocalDrivingLicenseApplications.FindByApplicationID(ApplicatinID).LocalDrivingLicenseApplicationID;
            LicenseHistoryForm historyForm = new LicenseHistoryForm(LocalID, NatinalNo);
            historyForm.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            InternationalAppliction international = new InternationalAppliction();
            international.ShowDialog();
            FilterINternatinalLoadInfo(); 
        }
    }
}
