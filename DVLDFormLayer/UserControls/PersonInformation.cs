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

namespace DVLDFormLayer
{
    public partial class PersonInformation : UserControl
    {
        public int PersonID {  get; set; }
        public int NatinalNo {  get; set; }
        public PersonInformation()
        {
            InitializeComponent();
        }


        public void LoadInformationPerson(string natinalNo)
        {
           
            clsBassnisPersons Find = clsBassnisPersons.Find(natinalNo);

            if (Find != null)
            {
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





        //public void LoadInformationPersonString()
        //{
        //    string PersonID = this.Tag.ToString();
        //    clsBassnisPersons Find = clsBassnisPersons.Find(PersonID);

        //    if (Find != null)
        //    {
        //        lblPersonID.Text = Find.PersonID.ToString();
        //        lblFullName.Text = Find.FirstName + " " + Find.SecondName + " " + Find.ThirdName + " " + Find.LastName;
        //        lblNationalNo.Text = Find.NationalNo;
        //        if (Find.Gender == 0)
        //        {
        //            lblGendor.Text = "Male";
        //        }
        //        else
        //        {
        //            lblGendor.Text = "Female";
        //        }
        //        lblEmail.Text = Find.Email;
        //        lblAddress.Text = Find.Address;
        //        lblDateOfBirth.Text = Find.DateOFbarth.ToString();
        //        lblPhone.Text = Find.Phone;
        //        lblCountry.Text = clsBassnisCountries.Find(Find.NationalityCountryID).CountryName;
        //        if (Find.ImagePath != "")
        //        {
        //            pcPepoleImege.Load(Find.ImagePath);
        //        }
        //        else
        //        {
        //            return;
        //        }
        //    }
        //    else
        //    {
        //        DevilitformationPerson();
        //    }

        //}

        public void LoadInformationPerson()
        {
            
            clsBassnisPersons Find = clsBassnisPersons.Find(PersonID);

            if (Find != null)
            {
                lblPersonID.Text = PersonID.ToString();
                lblFullName.Text=Find.FirstName+" "+Find.SecondName+" "+Find.ThirdName+" "+Find.LastName;
                lblNationalNo.Text=Find.NationalNo;
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
        public void LoadInformationPerson(int personID)
        {

            clsBassnisPersons Find = clsBassnisPersons.Find(personID);

            if (Find != null)
            {
                lblPersonID.Text = personID.ToString();
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

        private void lblLinkEditPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddEditPersonForm Add = new AddEditPersonForm(PersonID);
            Add.ShowDialog();
        }

        private void PersonInformation_Load(object sender, EventArgs e)
        {
            LoadInformationPerson();
        }
    }
}
