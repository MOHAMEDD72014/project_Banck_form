using DVLDBassnisLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDFormLayer.TestAppointment
{
    public partial class ScheduleTestForm : Form
    {
        int _LocalID;
        public int AppintmentID { get; set; }
        public bool IsActeve { get; set; }
        public int CountTest { get; set; }
        int _TypeTest;
        clsBassnisTestAppointments _testApuntment;
        clsBassnisLocalDrivingLicenseApplications _Local;
        clsBassnisApplications _App;
        public ScheduleTestForm(int LocalID,int TypeTest)
        {
            InitializeComponent();
            _LocalID = LocalID;
            _TypeTest = TypeTest;
        }
       private void Isvisbail()
        {
            if (IsActeve == true)
            {
                lblEror.Visible = true;
                btnSave.Enabled= false;
                dtpDateTest.Enabled= false;
                groupBox2.Visible= true;
            }
            else
            {
                lblEror.Visible =false;
                btnSave.Enabled = true;
                dtpDateTest.Enabled = true;
                groupBox2.Visible = false;
            }
        }


        private void loadRetakrApp()
        {
            ImageTestAndTitel();
            _App = new clsBassnisApplications();
            _App.CreatedByUserID = clsBassnisGlobal.CurrentUser.UsersID;
            _App.ApplicationDate = DateTime.Now;
            _App.ApplicationTypeID = 7;
            _App.ApplicationStatus = 1;
            _App.ApplicantPersonID = clsBassnisApplications.Find(clsBassnisLocalDrivingLicenseApplications.Find(_LocalID).ApplicationID).ApplicantPersonID;
            _App.LastStatusDate = DateTime.Now;
            _App.PaidFees = clsBassnisApplicationTypes.Find(7).ApplicationFees;

            _testApuntment = new clsBassnisTestAppointments();
            _testApuntment.TestTypeID = _TypeTest;
            _testApuntment.LocalDrivingLicenseApplicationID = _LocalID;
            _testApuntment.CreatedByUserID = clsBassnisGlobal.CurrentUser.UsersID;
            _testApuntment.PaidFees = clsBassnisTestTypes.Find(_testApuntment.TestTypeID).TestTypeFees;
            _testApuntment.AppointmentDate = dtpDateTest.Value;
            _testApuntment.IsLocked = false;
            


            lblTitel.Text = "Schedule Retake Test";
            groupBox2.Visible = true;
            lblRAppFees.Text = _App.PaidFees.ToString();
            lblTotalFees.Text = Convert.ToString(_testApuntment.PaidFees + _App.PaidFees);
            clsBassnisPersons person = clsBassnisPersons.Find(_App.ApplicantPersonID);
            lblAppID.Text = _LocalID.ToString();
            lblClassDrive.Text = clsBassnisLicenseClasses.Find(clsBassnisLocalDrivingLicenseApplications.Find(_LocalID).LicenseClassID).ClassName;
            lblFullName.Text = person.FirstName + " " + person.SecondName + " " + person.ThirdName + " " + person.LastName;
            lblFees.Text = _testApuntment.PaidFees.ToString();
            lblCountTray.Text = CountTest.ToString();
            lblTestID.Visible = false;
            label7.Visible = false;
            pictureBox6.Visible= false;
        }
        private bool RetakeTest()
        {
            if (CountTest > 0)
            {
                
                if (_App.Save())
                {
                    _testApuntment.RetakeTestApplicationID = _App.ApplicationID;
                    if (_testApuntment.Save())
                    {
                        MessageBox.Show("Test Appintment Add Secssfoly");

                        lblRTestAppID.Text = _testApuntment.RetakeTestApplicationID.ToString();
                    }
                   
                }
                else
                {
                    MessageBox.Show("Test Appintment Add Secssfoly");
                }
               


                return true;
            }
            return false;
        }
        private void loadDataTestAppintmentAndSetAppintMent()
        {
            ImageTestAndTitel();
            if (_LocalID != -1)
            {
                _Local = clsBassnisLocalDrivingLicenseApplications.Find(_LocalID);
                _testApuntment = new clsBassnisTestAppointments();
                _testApuntment.TestTypeID = _TypeTest;
                _testApuntment.LocalDrivingLicenseApplicationID = _LocalID;
                _testApuntment.CreatedByUserID = clsBassnisGlobal.CurrentUser.UsersID;
                _testApuntment.PaidFees = clsBassnisTestTypes.Find(_testApuntment.TestTypeID).TestTypeFees;
                _testApuntment.AppointmentDate = dtpDateTest.Value;
                _testApuntment.IsLocked = false;

                _App = clsBassnisApplications.Find(_Local.ApplicationID);
                clsBassnisPersons person = clsBassnisPersons.Find(_App.ApplicantPersonID);

                lblAppID.Text = _LocalID.ToString();
                lblClassDrive.Text = clsBassnisLicenseClasses.Find(_Local.LicenseClassID).ClassName;
                lblFullName.Text = person.FirstName + " " + person.SecondName + " " + person.ThirdName + " " + person.LastName;
                lblFees.Text = _testApuntment.PaidFees.ToString();
                lblCountTray.Text = CountTest.ToString();
            }
            else
            {
                _testApuntment = clsBassnisTestAppointments.Find(AppintmentID);
                _Local = clsBassnisLocalDrivingLicenseApplications.Find(_testApuntment.LocalDrivingLicenseApplicationID);
                _testApuntment.AppointmentDate = dtpDateTest.Value;

                _App = clsBassnisApplications.Find(_Local.ApplicationID);
                clsBassnisPersons person = clsBassnisPersons.Find(_App.ApplicantPersonID);

                lblAppID.Text = _Local.LocalDrivingLicenseApplicationID.ToString();
                lblClassDrive.Text = clsBassnisLicenseClasses.Find(_Local.LicenseClassID).ClassName;
                lblFullName.Text = person.FirstName + " " + person.SecondName + " " + person.ThirdName + " " + person.LastName;
                lblFees.Text = _testApuntment.PaidFees.ToString();
                lblCountTray.Text = CountTest.ToString();
                lblTestID.Text = _testApuntment.TestAppointmentID.ToString();
                Isvisbail();
            }
            

            
        }

  
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (RetakeTest()==true)
            { 
                
                return;
            }

            if (_testApuntment.Save())
            {
                MessageBox.Show("Test Appintment Add Secssfoly");
                lblTestID.Text = _testApuntment.TestAppointmentID.ToString();
                lblRTestAppID.Text = _testApuntment.TestAppointmentID.ToString();
            }
            else
            {
                MessageBox.Show("Test Appintment Add Secssfoly");
            }
            loadDataTestAppintmentAndSetAppintMent();
        }

       private void ImageTestAndTitel()
        {
            switch (_TypeTest)
            {
                case 2:
                    pictureBox1.Load("D:\\Icons\\Icons\\Written Test 512.png");
                    groupBox1.Text = "Written Test";
                    break;
                case 3:
                    pictureBox1.Load("D:\\Icons\\Icons\\WallPaper2.jpg");
                    break;
            }
        }
        private void ScheduleTestForm_Load(object sender, EventArgs e)
        {
            clsBassnisTestAppointments te = clsBassnisTestAppointments.FindbyLocalDrivingLicenseApplicationID(_LocalID);
            if (CountTest > 0 && te.IsLocked == true)
            {
                loadRetakrApp();
                return;
            }
            loadDataTestAppintmentAndSetAppintMent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
