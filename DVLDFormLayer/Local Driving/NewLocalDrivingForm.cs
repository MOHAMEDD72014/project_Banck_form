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
    public partial class NewLocalDrivingForm : Form
         
    {
        int _PersonID;
        string UserName;
        DateTime Appdete;
        int FeesApplication;
        enum enApplicationStatus {New=1 ,Cancelled=2,Completed=3 }
        clsBassnisApplications _Applications;
        clsBassnisLocalDrivingLicenseApplications _LicenseApplications;
        clsBassnisLicenseClasses _LicenseClasses;
        public NewLocalDrivingForm()
        {
            InitializeComponent();
            UserName= clsBassnisGlobal.CurrentUser.UserName;
            Appdete = DateTime.Now;
            FeesApplication = 15;
        }
        private void LoadDataSetting()
        {
            lblAppUserName.Text = UserName;
            lblAppFees.Text = FeesApplication.ToString();
            lblAppDate.Text = Appdete.ToString();

        }
        private void LoadClassLicensDate()
        {
            DataTable types = clsBassnisLicenseClasses.GetAllLicenseClasses();
            foreach (DataRow t in types.Rows)
            {
                cbClassLicense.Items.Add(t["ClassName"].ToString());
            }
            cbClassLicense.SelectedIndex = 0;
        }

        private void NewLocalDrivingForm_Load(object sender, EventArgs e)
        {
            LoadDataSetting();
            LoadClassLicensDate();

        }
       private void LicenseApplicationsSet()
        {
            _LicenseApplications = new clsBassnisLocalDrivingLicenseApplications();
            _LicenseApplications.ApplicationID = _Applications.ApplicationID;
            _LicenseApplications.LicenseClassID=cbClassLicense.SelectedIndex+1;
            if (_LicenseApplications.Save())
            {
                MessageBox.Show("Application Seccsafoly");
            }
        }
        private void SetNewApplication()
        {
            _Applications=new clsBassnisApplications();

            if(!clsBassnisApplications.IsApplicationsExist(filterAndInformationPerson1.PersonID,
                cbClassLicense.SelectedIndex+1)&& _Applications.ApplicationStatus == (int)enApplicationStatus.New)
            {
                _Applications.ApplicantPersonID = filterAndInformationPerson1.PersonID;
                _Applications.ApplicationDate = Appdete;
                _Applications.ApplicationTypeID = 1;
                _Applications.CreatedByUserID = clsBassnisGlobal.CurrentUser.UsersID;
                _Applications.LastStatusDate = Appdete;
                _Applications.ApplicationStatus = (int)enApplicationStatus.New;
                _Applications.PaidFees = clsBassnisApplicationTypes.Find(1).ApplicationFees;
                _Applications.Save();
                LicenseApplicationsSet();
                lblAppID.Text = _Applications.ApplicationID.ToString();
            }
            else
            {
                MessageBox.Show("Can not you reload Same Class Lissns Plase Try Agane");
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SetNewApplication();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
