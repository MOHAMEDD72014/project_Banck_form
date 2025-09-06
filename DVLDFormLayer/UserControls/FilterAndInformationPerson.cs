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
    public partial class FilterAndInformationPerson : UserControl
    {
        public int PersonID { get; set; }
        public string NatonalNo { get; set; }
        clsBassnisPersons _Person;
        public FilterAndInformationPerson()
        {
            InitializeComponent();
            cbUserFilter.SelectedIndex = 0;
        }

        public event Action<int> OnSavePerson;
        protected virtual void SavePersonEvent(int PersonID1)
        {
            Action<int> Handler = OnSavePerson;
            if (Handler != null)
            {
                Handler(PersonID1);
            }
        }
        public void FilterSearchPerson()
        {
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                               
                
                if (cbUserFilter.SelectedItem.ToString() == "PersonID")
                {
                  
                    PersonID = Convert.ToInt32(txtSearch.Text);
                    
                    LoadInformtionPerson(PersonID);
                  
                }
                else
                {
                    NatonalNo = txtSearch.Text;
                    LoadInformtionPerson(NatonalNo);
                    
                }
            }
        }
        public void FilterIsNotActive()
        {
            groupBox2.Enabled= false;
        }
        public void LoadInformtionPerson(int PersonID)
        {
            clsBassnisPersons Find = clsBassnisPersons.Find(PersonID);
            
            if (Find != null)
            {
                
                _Person = Find;
                lblPersonID.Text = PersonID.ToString();
                lblFullName.Text = Find.FirstName + " " + Find.SecondName + " " + Find.ThirdName + " " + Find.LastName;
                lblNationalNo.Text = Find.NationalNo;
                if (Find.Gender == 0)
                {
                    lblGendor.Text = "Male";
                }
                else
                {
                    lblGendor.Text = "Female";
                }
                lblEmail.Text = Find.Email;
                lblAddress.Text = Find.Address;
                lblDateOfBirth.Text = Find.DateOFbarth.ToString();
                lblPhone.Text = Find.Phone;
                lblCountry.Text = clsBassnisCountries.Find(Find.NationalityCountryID).CountryName;
                if (Find.ImagePath != "")
                {
                    pcPepoleImege.Load(Find.ImagePath);
                }
                else
                {
                    return;
                }

                if (OnSavePerson != null)
                {
                    SavePersonEvent(_Person.PersonID);
                }
            }
            else
            {
                DevilitformationPerson();
            }
        }

        private void LoadInformtionPerson(string NationalNo)
        {
            clsBassnisPersons Find = clsBassnisPersons.Find(NationalNo);

            if (Find != null)
            {
                PersonID= Find.PersonID;
                _Person = Find;
                lblPersonID.Text = Find.PersonID.ToString();
                lblFullName.Text = Find.FirstName + " " + Find.SecondName + " " + Find.ThirdName + " " + Find.LastName;
                lblNationalNo.Text = Find.NationalNo;
                if (Find.Gender == 0)
                {
                    lblGendor.Text = "Male";
                }
                else
                {
                    lblGendor.Text = "Female";
                }
                lblEmail.Text = Find.Email;
                lblAddress.Text = Find.Address;
                lblDateOfBirth.Text = Find.DateOFbarth.ToString();
                lblPhone.Text = Find.Phone;
                lblCountry.Text = clsBassnisCountries.Find(Find.NationalityCountryID).CountryName;
                if (Find.ImagePath != "")
                {
                    pcPepoleImege.Load(Find.ImagePath);
                }
                else
                {
                    return;
                }
            }
            else
            {
                DevilitformationPerson();
            }
        }

        public void DevilitformationPerson()
        {

            lblPersonID.Text = "???";
            lblFullName.Text = "???";
            lblNationalNo.Text = "???";
            lblGendor.Text = "Male";
            lblEmail.Text = "???";
            lblAddress.Text = "???";
            lblDateOfBirth.Text = "???";
            lblPhone.Text = "???";
            lblCountry.Text = "???";
            pcPepoleImege.Load("D:\\Icons\\Icons\\Male512.png");

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void filterUserCntrol1_Load(object sender, EventArgs e)
        {

        }

        private void FilterAndInformationPerson_Load(object sender, EventArgs e)
        {

        }

        private void cbUserFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Clear();
            FilterSearchPerson();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FilterSearchPerson();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AddEditPersonForm add = new AddEditPersonForm(-1);
            add.ShowDialog();
        }

        private void lblLinkEditPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddEditPersonForm add = new AddEditPersonForm(_Person.PersonID);
            add.ShowDialog();
        }
    }
}
