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
    public partial class ShowLicenseControl : UserControl
    {
        public int LocalID {  get; set; }
        public int LicenseID { get; set; }

        public ShowLicenseControl()
        {
            InitializeComponent();
        }

        private void LoadDataDraiverLicense()
        {
            if (!this.DesignMode && LocalID>0)
            {
                clsBassnisLocalDrivingLicenseApplications _Local;
                clsBassnisApplications _App;
                clsBassnisLicenses _Licenses;
                clsBassnisPersons _Person;
                _Local = clsBassnisLocalDrivingLicenseApplications.Find(LocalID);
                _App = clsBassnisApplications.Find(_Local.ApplicationID);
                _Person = clsBassnisPersons.Find(_App.ApplicantPersonID);
                _Licenses = clsBassnisLicenses.FindByApplicationID(_App.ApplicationID);
                if (_Local != null || _App != null || _Person != null || _Licenses != null)
                {
                    lblClassName.Text = clsBassnisLicenseClasses.Find(_Local.LicenseClassID).ClassName;
                    lblFullName.Text = _Person.FirstName + " " + _Person.SecondName + " " + _Person.ThirdName + " " + _Person.LastName;
                    lblNationalNo.Text = _Person.NationalNo;
                    lblLicenseID.Text = _Licenses.LicenseID.ToString();
                    if (_Person.Gender == 0)
                    {
                        lblGendor.Text = "Male";
                    }
                    else
                    {
                        lblGendor.Text = "Female";
                    }
                    lblIssuDate.Text = _Licenses.IssueDate.ToShortDateString();
                    switch (_Licenses.IssueReason)
                    {
                        case 1:
                            lblIssueResons.Text = "First Time";
                            break;
                        case 2:
                            lblIssueResons.Text = "Renew";
                            break;
                        case 3:
                            lblIssueResons.Text = "Replacement for Damaged";
                            break;
                        case 4:
                            lblIssueResons.Text = "Replacement for Lost";
                            break;
                    }
                    if (_Licenses.Notes != "")
                    {
                        lblNotes.Text = _Licenses.Notes;
                    }
                    else
                    {
                        lblNotes.Text = "No Notes";

                    }
                    if (_Licenses.IsActive)
                    {
                        lblIsActive.Text = "Yes";
                    }
                    else
                    {
                        lblIsActive.Text = "No";
                    }
                    lblDateOfBirth.Text = _Person.DateOFbarth.ToShortDateString();
                    lblDriverID.Text = _Licenses.DriverID.ToString();
                    lblExpDate.Text = _Licenses.ExpirationDate.ToShortDateString();
                    lblIsDetained.Text = "راجعها لامن تعمل فورم الحجز";

                    if (_Person.ImagePath != ""||_Person.ImagePath!=null)
                    {
                        pcPepoleImege.ImageLocation=_Person.ImagePath;
                    }
                    else if(_Person.Gender==0)
                    {
                        pcPepoleImege.Load("D:\\Icons\\Icons\\Male512.png");
                    }
                    else
                    {
                        pcPepoleImege.Load("D:\\Icons\\Icons\\Female512.png");
                    }


                }
            }
           


        }

        public void LoadDataDraiverLicenseByLisensesID()
        {
            if (!this.DesignMode)
            {
                clsBassnisLocalDrivingLicenseApplications _Local;
                clsBassnisApplications _App;
                clsBassnisLicenses _Licenses;
                clsBassnisPersons _Person;
                
                
                _Licenses = clsBassnisLicenses.Find(LicenseID);
                _App = clsBassnisApplications.Find(_Licenses.ApplicationID);
                _Local = clsBassnisLocalDrivingLicenseApplications.FindByApplicationID(_App.ApplicationID);
                _Person = clsBassnisPersons.Find(_App.ApplicantPersonID);
                
                if (_Local != null || _App != null || _Person != null || _Licenses != null)
                {
                    if (_Local.LicenseClassID == 3)
                    {
                        lblClassName.Text = clsBassnisLicenseClasses.Find(_Local.LicenseClassID).ClassName;
                        lblFullName.Text = _Person.FirstName + " " + _Person.SecondName + " " + _Person.ThirdName + " " + _Person.LastName;
                        lblNationalNo.Text = _Person.NationalNo;
                        lblLicenseID.Text = _Licenses.LicenseID.ToString();
                        if (_Person.Gender == 0)
                        {
                            lblGendor.Text = "Male";
                        }
                        else
                        {
                            lblGendor.Text = "Female";
                        }
                        lblIssuDate.Text = _Licenses.IssueDate.ToShortDateString();
                        switch (_Licenses.IssueReason)
                        {
                            case 1:
                                lblIssueResons.Text = "First Time";
                                break;
                            case 2:
                                lblIssueResons.Text = "Renew";
                                break;
                            case 3:
                                lblIssueResons.Text = "Replacement for Damaged";
                                break;
                            case 4:
                                lblIssueResons.Text = "Replacement for Lost";
                                break;
                        }
                        if (_Licenses.Notes != "")
                        {
                            lblNotes.Text = _Licenses.Notes;
                        }
                        else
                        {
                            lblNotes.Text = "No Notes";

                        }
                        if (_Licenses.IsActive)
                        {
                            lblIsActive.Text = "Yes";
                        }
                        else
                        {
                            lblIsActive.Text = "No";
                        }
                        lblDateOfBirth.Text = _Person.DateOFbarth.ToShortDateString();
                        lblDriverID.Text = _Licenses.DriverID.ToString();
                        lblExpDate.Text = _Licenses.ExpirationDate.ToShortDateString();
                        lblIsDetained.Text = "راجعها لامن تعمل فورم الحجز";

                        if (_Person.ImagePath != "" || _Person.ImagePath != null)
                        {
                            pcPepoleImege.ImageLocation = _Person.ImagePath;
                        }
                        else if (_Person.Gender == 0)
                        {
                            pcPepoleImege.Load("D:\\Icons\\Icons\\Male512.png");
                        }
                        else
                        {
                            pcPepoleImege.Load("D:\\Icons\\Icons\\Female512.png");
                        }
                    }
                    else
                    {
                        MessageBox.Show("You Messing Have Class 3 - Ordinary driving license");
                    }
                   


                }
            }



        }

        private void ShowLicenseControl_Load(object sender, EventArgs e)
        {
            LoadDataDraiverLicense();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
