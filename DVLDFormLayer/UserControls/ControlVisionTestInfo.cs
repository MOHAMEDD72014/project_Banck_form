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



namespace DVLDFormLayer.UserControls
{
    public partial class ControlVisionTestInfo : UserControl
    {
        clsBassnisLocalDrivingLicenseApplications _Local;

        clsBassnisApplications _Application ;
       
       public int LocalID { get; set; }
        
        public ControlVisionTestInfo()
        {
           
            InitializeComponent();
           
            
        }
       
       
        public void LoadDataVisionTestInfo()
        {
            if (!this.DesignMode)
            {

                _Local = clsBassnisLocalDrivingLicenseApplications.Find(LocalID);
                if (_Local != null) {
                    _Application = clsBassnisApplications.Find(_Local.ApplicationID);
                    lblAppID.Text = _Local.LocalDrivingLicenseApplicationID.ToString();
                    lblClassLicense.Text = clsBassnisLicenseClasses.Find(_Local.LicenseClassID).ClassName;
                    DataTable table = clsBassnisApplications.GetDataViueAppLicatin();
                    foreach (DataRow row in table.Rows)
                    {
                        if (Convert.ToInt32(row["LocalDrivingLicenseApplicationID"]) == _Local.LocalDrivingLicenseApplicationID)
                        {
                            lblPassedTests.Text = Convert.ToString(row["PassedTestCount"]);
                            lblFullName.Text = Convert.ToString(row["FullName"]); ;
                            break;
                        }

                    }
                    lblApplicationID.Text = _Local.ApplicationID.ToString();
                    lblType.Text = clsBassnisApplicationTypes.Find(clsBassnisApplications.Find(_Application.ApplicationID).ApplicationTypeID).ApplicationTypeTitle;
                    lblDate.Text = _Application.ApplicationDate.ToString();
                    lblDateStatas.Text = _Application.LastStatusDate.ToString();
                    lblUsername.Text = _Application.CreatedByUserID.ToString();
                    lblFees.Text = _Application.PaidFees.ToString();
                    switch (_Application.ApplicationStatus)
                    {
                        case 1:
                            lblStatas.Text = "New";
                            break;
                        case 2:
                            lblStatas.Text = "Cancelled";
                            break;
                        case 3:
                            lblStatas.Text = "Completed";
                            break;
                    }

                }
                else
                {
                    return;
                }
            }
           
        }
        private void ControlVisionTestInfo_Load(object sender, EventArgs e)
        {
            LoadDataVisionTestInfo();
        }

        private void lnkViewPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PersonDetailsForm ditels = new PersonDetailsForm(_Application.ApplicantPersonID);
            ditels.ShowDialog();
        }
    }
}
