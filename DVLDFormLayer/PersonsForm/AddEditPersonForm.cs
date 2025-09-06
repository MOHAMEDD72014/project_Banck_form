using DVLDBassnisLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDFormLayer
{
    public partial class AddEditPersonForm : Form
    {
        public delegate void SandPersonID(object sender, int PersonIDT);
        public event SandPersonID EventSandID;


        public event Action<int> OnSavePerson;
        protected virtual void SavePersonEvent(int PersonID1)
        {
            Action<int> Handler=OnSavePerson;
            if(Handler != null)
            {
                Handler(PersonID1);
            }
        }

        enum enMode { Update = 1, AddNew = 0 }
        enMode _Mode;
        clsBassnisPersons persons;
        int _PersonID;
        public AddEditPersonForm(int PersonID)
        {
            InitializeComponent();
          _PersonID=PersonID;
            if (_PersonID == -1)
            {
                _Mode = enMode.AddNew;
            }
            else
            {
                _Mode = enMode.Update;
            }

        }

        private void _FillCountriesInComoboBox()
        {
            DataTable dt = clsBassnisCountries.GetAllCountry();
            foreach (DataRow dr in dt.Rows)
            {
                cbCoutryList.Items.Add(dr["CountryName"]);

            }
            cbCoutryList.SelectedItem = "Sudan";
        }


        private void RadieBoutmImege()
        {
            if (rbMale.Checked)
            {
                pcPepoleImege.Load("D:\\Icons\\Icons\\Male512.png");
            }
            else if (rbFemale.Checked)
            {
                pcPepoleImege.Load("D:\\Icons\\Icons\\Female512.png");
            }


        }


        private void SettingDateTimePicker()
        {
            dtpPeopleOfBirth.MaxDate = DateTime.Today.AddYears(-18);

        }



        private void LoadPeople()
        {
            if (_Mode == enMode.AddNew)
            {
                lblStats.Text = "Add New Person";
                persons = new clsBassnisPersons();
                return;
            }
            persons = clsBassnisPersons.Find(_PersonID);
            if (persons == null)
            {
                MessageBox.Show("This form will be closed because No Contact with ID = " + _PersonID);
                this.Close();

                return;

            }
                lblPersonID.Text =_PersonID.ToString();
                txtFirstName.Text = persons.FirstName;
                txtSecond.Text = persons.SecondName;
                txtThird.Text = persons.ThirdName;
                txtLastName.Text = persons.LastName;
                txtEmail.Text = persons.Email;
                txtPhone.Text = persons.Phone;
                txtAddress.Text = persons.Address;
                txtNationalNo.Text = persons.NationalNo;
                dtpPeopleOfBirth.Value = persons.DateOFbarth;
                if (persons.Gender == 0)
                {
                    rbMale.Checked = true;
                    rbFemale.Checked = false;
                }
                else
                {
                    rbFemale.Checked = true;
                    rbMale.Checked = false;
                }

                cbCoutryList.SelectedIndex = cbCoutryList.FindString(clsBassnisCountries.Find(persons.NationalityCountryID).CountryName);
                if (persons.ImagePath != "")
                {
                    pcPepoleImege.Load(persons.ImagePath);
                    lblRemove.Visible = true;
                }
                else
                {

                    lblRemove.Visible = false;
                }

        }



        private void AddNewPeople()
        {

            persons.FirstName = txtFirstName.Text;
            persons.SecondName = txtSecond.Text;
            persons.ThirdName = txtThird.Text;
            persons.LastName = txtLastName.Text;
            persons.Email = txtEmail.Text;
            persons.Phone = txtPhone.Text;
            persons.Address = txtAddress.Text;

            persons.NationalNo = txtNationalNo.Text;
            persons.DateOFbarth = dtpPeopleOfBirth.Value;
            if (rbMale.Checked)
            {
                persons.Gender = 0;
            }
            else
            {
                persons.Gender = 1;
            }
            persons.NationalityCountryID = (clsBassnisCountries.Find(cbCoutryList.Text).CountryID);
            if (pcPepoleImege.Location != null)
            {
                persons.ImagePath = pcPepoleImege.ImageLocation;
                lblRemove.Visible = true;
            }
            else 
            {
                persons.ImagePath = "";
                lblRemove.Visible = false;
            }
            if (persons.Save())
            {
                MessageBox.Show(persons.PersonID.ToString());
                _Mode = enMode.Update;
                lblStats.Text = "Update Person";
                lblPersonID.Text = persons.PersonID.ToString();
                EventSandID?.Invoke(this, persons.PersonID);
                

            }
            else
            {
                MessageBox.Show("error");
            }

            return;
        }
        private bool IsValidEmail(string Email)
        {
            string Pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(Email, Pattern);
        }

        private void TestNationalNo()
        {

            if (clsBassnisPersons.IsPersonsExist(txtNationalNo.Text))
            {
                errorProvider1.SetError(txtNationalNo, "This National No is already exist");
                txtNationalNo.Focus();
            }
            else
            {
                errorProvider1.Clear();

            }

        }



        private void peopleInfoAdd1_Load(object sender, EventArgs e)
        {
           
            
        }

        private void PeopleAdd_Load(object sender, EventArgs e)
        {
            _FillCountriesInComoboBox();
            SettingDateTimePicker();
            LoadPeople();
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            RadieBoutmImege();
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            RadieBoutmImege();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
          
        }

        private void lblSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Filter|*.jpg;*.jpeg;*.png;*.gif;*.bmp;";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string OathImage = openFileDialog1.FileName;
                pcPepoleImege.Load(OathImage);
                lblRemove.Visible = true;

            }
        }
        private void RemoveImage()
        {
            pcPepoleImege.Image = null;
            pcPepoleImege.ImageLocation = null;
            lblRemove.Visible = false;
            RadieBoutmImege();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            AddNewPeople();

           
        }

        private void lblRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RemoveImage();
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            string Email = txtEmail.Text.Trim();
            if (IsValidEmail(Email) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "");
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(txtEmail, "Invalid Email Format");

            }
        }

        private void txtNationalNo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {
            TestNationalNo();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
