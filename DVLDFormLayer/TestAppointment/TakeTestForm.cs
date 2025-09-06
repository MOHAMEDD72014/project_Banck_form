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

namespace DVLDFormLayer.TestAppointment
{
    public partial class TakeTestForm : Form
    {
        int _TestApintMentID;
        clsBassnisTests _Test;
        clsBassnisTestAppointments _TestAppointments;
        public int CountTest1 { get; set; }
        private int _count;
        int _TypeTest;
        public TakeTestForm(int testApintMentID,int TypeTestID)
        {
            InitializeComponent();
           
            _TypeTest = TypeTestID;
            _count = CountTest1;
            _TestApintMentID = testApintMentID;
            LoadDataTest();
            SetTest();
            ImageTestAndTitel();
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
        private void LoadDataTest()
        {
            _TestAppointments = clsBassnisTestAppointments.Find(_TestApintMentID);
            clsBassnisLocalDrivingLicenseApplications _Local = clsBassnisLocalDrivingLicenseApplications.Find(_TestAppointments.LocalDrivingLicenseApplicationID);
            clsBassnisApplications _App = clsBassnisApplications.Find(_Local.ApplicationID);
            clsBassnisPersons person = clsBassnisPersons.Find(_App.ApplicantPersonID);
            lblAppID.Text = _Local.LocalDrivingLicenseApplicationID.ToString();
            lblClassDrive.Text = clsBassnisLicenseClasses.Find(_Local.LicenseClassID).ClassName;
            lblDate.Text = _TestAppointments.AppointmentDate.ToString();
            lblFullName.Text = person.FirstName + " " + person.SecondName + " " + person.ThirdName + " " + person.LastName;
            lblFees.Text = _TestAppointments.PaidFees.ToString();
            lblCountTray.Text = _count.ToString();
            lblTestID.Text = "Not Takeen Yet";
           
        }
        private void SetTest()
        {
            _Test = new clsBassnisTests();
            _Test.TestAppointmentID = _TestApintMentID;
            _Test.Notes = txtNotes.Text;
            if (rbPass.Checked)
            {
                _Test.TestResult = true;
            }
            else if(rbFall.Checked)
            {
                _Test.TestResult = false;
            }

            _Test.CreatedByUserID = clsBassnisGlobal.CurrentUser.UsersID;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TakeTestForm_Load(object sender, EventArgs e)
        {
            _count = CountTest1;
            LoadDataTest();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            _TestAppointments.IsLocked = true;
            ;
            if (_Test.Save()&& _TestAppointments.Save())
            {
                MessageBox.Show("Save Data");
                lblTestID.Text = _Test.TestID.ToString();
            }
            else
            {
                MessageBox.Show("Not Masning Seecsasfoly");
            }
        }

        private void rbPass_CheckedChanged(object sender, EventArgs e)
        {
            SetTest();
        }

        private void rbFall_CheckedChanged(object sender, EventArgs e)
        {
            SetTest();
        }
    }
}
