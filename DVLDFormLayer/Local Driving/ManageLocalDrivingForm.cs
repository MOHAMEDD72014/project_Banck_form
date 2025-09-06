using DVLDBassnisLayer;
using DVLDFormLayer.LicenseDrive;
using DVLDFormLayer.Manage_Users;
using DVLDFormLayer.TestAppointment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDFormLayer.Local_Driving
{
    public partial class ManageLocalDrivingForm : Form
    {
        int CountPass;
        public ManageLocalDrivingForm()
        {
            InitializeComponent();
            cbFilterApp.SelectedIndex = 0;
            LoadDataViueApplication();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            NewLocalDrivingForm newLocal = new NewLocalDrivingForm();
            newLocal.ShowDialog();
            FilterSearchApplication();
        }
        private void LoadDataViueApplication()
        {
            DataTable data = clsBassnisApplications.GetDataViueAppLicatin();

            DataView dataView = data.DefaultView;
            dgvLocalDriving.DataSource= dataView;

        }
        private void FilterSearchApplication()
        {
            DataTable data = clsBassnisApplications.GetDataViueAppLicatin();
            DataView dataView = data.DefaultView;
            string ValueFilter = cbFilterApp.SelectedItem.ToString();
            if (ValueFilter == "None" )
            {

               
                txtSearchApp.Visible = false;
                LoadDataViueApplication();
               
               
            }
            else
            {
               if(ValueFilter== "L.D.L AppID")
                {
                    ValueFilter = "LocalDrivingLicenseApplicationID";
                }
                    
                dgvLocalDriving.DataSource = dataView;
                txtSearchApp.Visible = true;
                dataView.RowFilter = $"CONVERT({ValueFilter},'System.String') LIKE '%{txtSearchApp.Text}%'";
                dgvLocalDriving.DataSource = dataView.ToTable();
            }

            lblRecordApp.Text = dataView.Count.ToString();
        }
    
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageLocalDrivingForm_Load(object sender, EventArgs e)
        {

        }

        private void cbFilterApp_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterSearchApplication();
        }

        private void txtSearchApp_TextChanged(object sender, EventArgs e)
        {
            FilterSearchApplication();
        }

        private void tsmShowDetailsUser_Click(object sender, EventArgs e)
        {
            PersonDetailsForm det = new PersonDetailsForm((string)dgvLocalDriving.CurrentRow.Cells[2].Value);
            det.ShowDialog();
        }

        private void TsmEdditApplication_Click(object sender, EventArgs e)
        {
            NewLocalDrivingForm newLocalDrivingForm = new NewLocalDrivingForm();
            newLocalDrivingForm.ShowDialog();
            FilterSearchApplication();
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            int tempIDDelet = (int)dgvLocalDriving.CurrentRow.Cells[0].Value;
            clsBassnisApplications app = clsBassnisApplications.Find(clsBassnisLocalDrivingLicenseApplications.Find(tempIDDelet).ApplicationID);


            if (clsBassnisLocalDrivingLicenseApplications.DeleteLocalDrivingLicenseApplications(tempIDDelet))
            {
                if (clsBassnisApplications.DeleteApplications(app.ApplicationID))
                {

                    MessageBox.Show("Deleted Secssfoly");
                }
            }
            else
            {
                MessageBox.Show("Deleted Not Secssfoly");
            }

            FilterSearchApplication();



        }
        private void CheckMnueEnbold()
        {
            int tempIDDelet = (int)dgvLocalDriving.CurrentRow.Cells[0].Value;
            clsBassnisApplications app = clsBassnisApplications.Find(clsBassnisLocalDrivingLicenseApplications.Find(tempIDDelet).ApplicationID);
            switch (app.ApplicationStatus)
            {
                case 1:
                    tsmCancelApplication.Enabled = true;
                    tsmIssueDrivingLicense.Enabled = false;
                    tsmSechduleTests.Enabled = true;
                    TsmEdditApplication.Enabled = true;
                    tsmDelete.Enabled = true;
                    tsmScheduleVisionTest.Enabled = true;
                    tsmScheduleWrittenTest.Enabled = false;
                    tsmScheduleStreetTest.Enabled = false;
                    tsmShowDetailsUser.Enabled = true;
                    tsmShowLicense.Enabled = true;
                    break;

                case 2:
                    tsmCancelApplication.Enabled = false;
                    tsmIssueDrivingLicense.Enabled = false;
                    tsmSechduleTests.Enabled = false;
                    TsmEdditApplication.Enabled = false;
                    tsmShowDetailsUser.Enabled = true;
                    tsmShowLicense.Enabled = true;

                    break;
                    case 3:
                    tsmCancelApplication.Enabled = false;
                    tsmIssueDrivingLicense.Enabled = false;
                    tsmSechduleTests.Enabled = false;
                    TsmEdditApplication.Enabled = false;
                    tsmDelete.Enabled = false;
                    tsmShowDetailsUser.Enabled = true;
                    tsmShowLicense.Enabled = true;
                    break;
            }
        }
        private void tsmCancelApplication_Click(object sender, EventArgs e)
        {
            int tempIDDelet = (int)dgvLocalDriving.CurrentRow.Cells[0].Value;
            clsBassnisApplications app = clsBassnisApplications.Find(clsBassnisLocalDrivingLicenseApplications.Find(tempIDDelet).ApplicationID);
            app.ApplicationStatus = 2;
            if (app.Save())
            {
                MessageBox.Show("Application Secssfoly");
            }
            else
            {
                MessageBox.Show("Application Not Secssfoly");
            }
            FilterSearchApplication();
        }
        private void countPassTest()
        {
            DataTable DATA = clsBassnisApplications.GetDataViueAppLicatin();
            foreach (DataRow row in DATA.Rows)
            {
                if ((int)dgvLocalDriving.CurrentRow.Cells[0].Value == int.Parse(row["LocalDrivingLicenseApplicationID"].ToString()))
                {
                    CountPass = int.Parse(row["PassedTestCount"].ToString());
                    break;
                }

            }
        }
        private void cmsEditeUser_Opening(object sender, CancelEventArgs e)
        {
            CheckMnueEnbold();
            countPassTest();
            switch (CountPass)
            {
                case 0:
                    tsmScheduleVisionTest.Enabled = true;
                    tsmScheduleStreetTest.Enabled = false;
                    tsmScheduleWrittenTest.Enabled = false;
                    break;

                case 1:
                    tsmScheduleVisionTest.Enabled = false;
                    tsmScheduleStreetTest.Enabled = false;
                    tsmScheduleWrittenTest.Enabled = true;
                    break;
                case 2:
                    tsmScheduleVisionTest.Enabled = false;
                    tsmScheduleStreetTest.Enabled = true;
                    tsmScheduleWrittenTest.Enabled = false;
                    break;
                    case 3:
                    tsmSechduleTests.Enabled = false;
                    tsmIssueDrivingLicense.Enabled = true;
                    clsBassnisApplications app = clsBassnisApplications.Find(clsBassnisLocalDrivingLicenseApplications.Find((int)dgvLocalDriving.CurrentRow.Cells[0].Value).ApplicationID);
                    if (app.ApplicationStatus == 3)
                    {
                        tsmIssueDrivingLicense.Enabled = false;
                    }
                    break;
            }

        }

        private void tsmScheduleVisionTest_Click(object sender, EventArgs e)
        {
            VisionTestForm vision = new VisionTestForm((int)dgvLocalDriving.CurrentRow.Cells[0].Value,1);
            vision.ShowDialog();
            FilterSearchApplication();
        }

        private void tsmScheduleWrittenTest_Click(object sender, EventArgs e)
        {
            VisionTestForm vision = new VisionTestForm((int)dgvLocalDriving.CurrentRow.Cells[0].Value,2);
            vision.ShowDialog();
            FilterSearchApplication();
        }

        private void tsmScheduleStreetTest_Click(object sender, EventArgs e)
        {
            VisionTestForm vision = new VisionTestForm((int)dgvLocalDriving.CurrentRow.Cells[0].Value, 3);
            vision.ShowDialog();
            FilterSearchApplication();
        }

        private void tsmIssueDrivingLicense_Click(object sender, EventArgs e)
        {
            IssueDriverForm issue = new IssueDriverForm((int)dgvLocalDriving.CurrentRow.Cells[0].Value);
            issue.ShowDialog();
            FilterSearchApplication();
        }

        private void tsmShowLicense_Click(object sender, EventArgs e)
        {
            ShowDriverLisence driverLisence= new ShowDriverLisence((int)dgvLocalDriving.CurrentRow.Cells[0].Value);
            driverLisence.ShowDialog();
        }

        private void tsmShowPersonLicenseHistory_Click(object sender, EventArgs e)
        {
            LicenseHistoryForm historyForm = new LicenseHistoryForm((int)dgvLocalDriving.CurrentRow.Cells[0].Value, (string)dgvLocalDriving.CurrentRow.Cells[2].Value);
            historyForm.ShowDialog();
        }
    }
}
