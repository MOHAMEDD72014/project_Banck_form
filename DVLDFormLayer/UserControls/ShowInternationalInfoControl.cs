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
    public partial class ShowInternationalInfoControl : UserControl
    {
       
        public int LicenseID { get; set; }
        public ShowInternationalInfoControl()
        {
            InitializeComponent();
        }
        private void LoadInterntinalLicnseInfo()
        {
            if (!this.DesignMode)
            {
               
                clsBassnisLicenses _Licenses = clsBassnisLicenses.Find(LicenseID);
                clsBassnisApplications _App = clsBassnisApplications.Find(_Licenses.ApplicationID);
                clsBassnisLocalDrivingLicenseApplications _Local = clsBassnisLocalDrivingLicenseApplications.FindByApplicationID(_App.ApplicationID);
                clsBassnisPersons _Person = clsBassnisPersons.Find(_App.ApplicantPersonID);
                clsBassnisInternationalLicenses _Inter = clsBassnisInternationalLicenses.FindBylLicenseID(_Licenses.LicenseID);
                if (_Local != null || _App != null || _Person != null || _Licenses != null)
                {
                    if (_Local.LicenseClassID == 3)
                    {
                       
                        lblFullName.Text = _Person.FirstName + " " + _Person.SecondName + " " + _Person.ThirdName + " " + _Person.LastName;
                        lblNatinalNo.Text = _Person.NationalNo;
                        lblInterntinalID.Text = _Inter.InternationalLicenseID.ToString();
                        lblLicinseID.Text = _Licenses.LicenseID.ToString();
                        if (_Person.Gender == 0)
                        {
                            lblGendor.Text = "Male";
                        }
                        else
                        {
                            lblGendor.Text = "Female";
                        }
                        lblIssueDate.Text = _Inter.IssueDate.ToShortDateString();
                       
                       
                        if (_Inter.IsActive)
                        {
                            lblIsActive.Text = "Yes";
                        }
                        else
                        {
                            lblIsActive.Text = "No";
                        }
                        lblApplicatinID.Text = _Inter.ApplicationID.ToString();
                        lblBarthDate.Text = _Person.DateOFbarth.ToShortDateString();
                        lblDriveID.Text = _Inter.DriverID.ToString();
                        lblExDete.Text = _Inter.ExpirationDate.ToShortDateString();
                       

                        if (_Person.ImagePath != "" || _Person.ImagePath != null)
                        {
                            pcPerson.ImageLocation = _Person.ImagePath;
                        }
                        else if (_Person.Gender == 0)
                        {
                            pcPerson.Load("D:\\Icons\\Icons\\Male512.png");
                        }
                        else
                        {
                            pcPerson.Load("D:\\Icons\\Icons\\Female512.png");
                        }
                    }
                    

                }
            }

        }
        private void ShowInternationalInfoControl_Load(object sender, EventArgs e)
        {
            LoadInterntinalLicnseInfo();
        }
    }
}
