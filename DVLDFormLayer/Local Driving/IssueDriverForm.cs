using DVLDBassnisLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDFormLayer.Local_Driving
{
    public partial class IssueDriverForm : Form
    {
        int _LocalID;
        clsBassnisDrivers drivers;
        clsBassnisLicenses licenses;
        public IssueDriverForm(int LocalID)
        {
            InitializeComponent();
            _LocalID = LocalID;
        }
        private void loadDataIssueDriver()
        {
            int LinthDate= clsBassnisLicenseClasses.Find(clsBassnisLocalDrivingLicenseApplications.Find(_LocalID).LicenseClassID).DefaultValidityLength;
            controlVisionTestInfo1.LocalID = _LocalID;
            controlVisionTestInfo1.LoadDataVisionTestInfo();
            drivers = new clsBassnisDrivers();
            drivers.CreatedByUserID = clsBassnisGlobal.CurrentUser.UsersID;
            drivers.CreatedDate=DateTime.Now;
            drivers.PersonID = clsBassnisApplications.Find(clsBassnisLocalDrivingLicenseApplications.Find(_LocalID).ApplicationID).ApplicantPersonID;
            
            licenses=new clsBassnisLicenses();
            licenses.IssueDate = DateTime.Now;
            licenses.PaidFees = clsBassnisLicenseClasses.Find(1).ClassFees;
            licenses.Notes = txtNotes.Text;
            licenses.CreatedByUserID = clsBassnisGlobal.CurrentUser.UsersID;
            licenses.ApplicationID = clsBassnisLocalDrivingLicenseApplications.Find(_LocalID).ApplicationID;
            licenses.IsActive = true;
            licenses.LicenseClass = clsBassnisLocalDrivingLicenseApplications.Find(_LocalID).LicenseClassID;
            licenses.ExpirationDate = DateTime.Now.AddYears(LinthDate);
            licenses.IssueReason = 1;
        }

        private void IssueDriverForm_Load(object sender, EventArgs e)
        {
           loadDataIssueDriver();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (drivers.Save())
            {
                licenses.DriverID = drivers.DriverID;
                clsBassnisApplications App=clsBassnisApplications.Find(clsBassnisLocalDrivingLicenseApplications.Find(_LocalID).ApplicationID);
                App.ApplicationStatus = 3;
                App.LastStatusDate = DateTime.Now;
                if (licenses.Save()&&App.Save())
                {
                    MessageBox.Show("Issue Driver Secssfoly");
                }
                else
                {
                    MessageBox.Show("Issue Driver not Secssfoly");
                }
            }
            else
            {
                MessageBox.Show("error");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
