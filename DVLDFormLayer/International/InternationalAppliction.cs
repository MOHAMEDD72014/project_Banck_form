using DVLDBassnisLayer;
using DVLDFormLayer.International;
using DVLDFormLayer.LicenseDrive;
using DVLDFormLayer.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDFormLayer
{
    public partial class InternationalAppliction : Form
    {
        clsBassnisLicenses _Licenses;
        clsBassnisApplications _App;
        clsBassnisLocalDrivingLicenseApplications _Local;
        clsBassnisPersons _Person;
        clsBassnisInternationalLicenses _International;
        public InternationalAppliction()
        {
            InitializeComponent();
        }

        private void ApplicationInterNatinalLicenses()
        {
            _International = new clsBassnisInternationalLicenses();
           clsBassnisApplications _AppTemp = new clsBassnisApplications();
            _AppTemp.ApplicantPersonID = _App.ApplicantPersonID;
            _AppTemp.ApplicationStatus = 3;
            _AppTemp.ApplicationDate = DateTime.Today;
            _AppTemp.ApplicationTypeID = 6;
            _AppTemp.CreatedByUserID = clsBassnisGlobal.CurrentUser.UsersID;
            _AppTemp.LastStatusDate = DateTime.Today;

            
            _International.CreatedByUserID= clsBassnisGlobal.CurrentUser.UsersID;
            _International.DriverID=_Licenses.DriverID;
            _International.IssueDate = DateTime.Today;
            _International.IsActive = true;
            _International.IssuedUsingLocalLicenseID = _Licenses.LicenseID;
            _International.ExpirationDate= DateTime.Today.AddYears(1);


            lblAppDate.Text = _AppTemp.ApplicationDate.ToShortDateString();
            lblIssuDate.Text=_International.IssueDate.ToShortDateString();
            lblFees.Text = clsBassnisApplicationTypes.Find(_AppTemp.ApplicationTypeID).ApplicationFees.ToString();
            lblLocalLicenseID.Text = _International.IssuedUsingLocalLicenseID.ToString();
            lblExpDate.Text = _International.ExpirationDate.ToShortDateString();
            lblUserName.Text = clsBassnisGlobal.CurrentUser.UserName;


            _App = _AppTemp;
        }

        private void LoadInfoLisense()
        {
           _Licenses = clsBassnisLicenses.Find(Convert.ToInt32(txtSearch.Text));
           _App = clsBassnisApplications.Find(_Licenses.ApplicationID);
           _Local = clsBassnisLocalDrivingLicenseApplications.FindByApplicationID(_App.ApplicationID);
           _Person = clsBassnisPersons.Find(_App.ApplicantPersonID);
            if (_Person != null || _Local != null || _App != null || _Licenses != null)
            {
                if (clsBassnisInternationalLicenses.IsInternationalLicensesExistByDriverID(_Licenses.DriverID))
                {
                    btnIssue.Enabled = false;
                    linkInfo.Enabled = true;
                    MessageBox.Show($"Person Alrade Have An Active International License {txtSearch.Text}", "Not Alowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (_Licenses.IsActive)
                    {
                        btnIssue.Enabled = true;
                        linkInfo.Enabled = false;
                    }
                    else
                    {
                        btnIssue.Enabled = false;
                        linkInfo.Enabled = false;
                        MessageBox.Show("Your License Not Active Please Soupport 999");
                    }
                    
                }
                showLicenseControl1.LocalID = -1;
                showLicenseControl1.LicenseID = Convert.ToInt32(txtSearch.Text);
                showLicenseControl1.LoadDataDraiverLicenseByLisensesID();
                ApplicationInterNatinalLicenses();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadInfoLisense();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (_App.Save())
            {
                _International.ApplicationID= _App.ApplicationID;
                if (_International.Save())
                {
                    lblLApplicationID.Text = _App.ApplicationID.ToString();
                    lblIntenationalID.Text = _International.InternationalLicenseID.ToString();
                    btnIssue.Enabled = false;
                    linkInfo.Enabled = true;
                    MessageBox.Show("International New Secssfoly");
                }
                else
                {
                    MessageBox.Show("International Not Secssfoly");
                }
            }
        }

        private void linkHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicenseHistoryForm licenseHistory = new LicenseHistoryForm(_Local.LocalDrivingLicenseApplicationID,_Person.NationalNo);
            licenseHistory.ShowDialog();
        }

        private void linkInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowInternatinalInfoForm infoForm = new ShowInternatinalInfoForm(Convert.ToInt32(txtSearch.Text));
            infoForm.ShowDialog();
        }
    }
}
