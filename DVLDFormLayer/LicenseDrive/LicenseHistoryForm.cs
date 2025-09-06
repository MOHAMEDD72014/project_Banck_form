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

namespace DVLDFormLayer.LicenseDrive
{
    public partial class LicenseHistoryForm : Form
    {
        int _LocalID;
        string _NationalNo;
        public LicenseHistoryForm(int LocalID,string NationalNo)
        {
            InitializeComponent();
            _LocalID = LocalID;
            _NationalNo = NationalNo;
        }
        private void DataPersonUplode()
        {
           
            clsBassnisLocalDrivingLicenseApplications _Local = clsBassnisLocalDrivingLicenseApplications.Find(_LocalID);
            clsBassnisApplications _App = clsBassnisApplications.Find(_Local.ApplicationID);
            clsBassnisPersons _Person = clsBassnisPersons.Find(_App.ApplicantPersonID);
            clsBassnisLicenses _Licenses = clsBassnisLicenses.FindByApplicationID(_App.ApplicationID);

            if (_Local != null || _App != null || _Person != null || _Licenses != null)
            {
                personInformation1.PersonID = _Person.PersonID;
                personInformation1.LoadInformationPerson();

                DataTable data = clsBassnisLicenses.GetAllLicenseByLocalID(_LocalID);
                DataView dataView = data.DefaultView;
                dgvLocal.DataSource = dataView.ToTable();
                dgvLocal.AutoSizeColumnsMode= DataGridViewAutoSizeColumnsMode.Fill;
                dgvLocal.AllowUserToAddRows= false;
                lblRecord.Text= dgvLocal.RowCount.ToString();
                if (_App != null || _Person != null || _Licenses != null)
                {
                    _Person = clsBassnisPersons.Find(_NationalNo);
                    _App = clsBassnisApplications.FindByPersonID(_Person.PersonID);
                    _Licenses = clsBassnisLicenses.FindByApplicationID(_App.ApplicationID);
                    DataTable data2 = clsBassnisInternationalLicenses.GetAllInternationalLicensesByDriverID(_Licenses.DriverID);
                    DataView dataView2 = data2.DefaultView;
                    dgvHostory.DataSource = dataView2.ToTable();
                    dgvHostory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvHostory.AllowUserToAddRows = false;
                    lblRecordHistory.Text = dgvHostory.RowCount.ToString();
                }
                else
                {
                    return;
                }

            }
            else
            {
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LicenseHistoryForm_Load(object sender, EventArgs e)
        {
            DataPersonUplode();
        }
    }
}
