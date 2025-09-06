using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLDDataAccsess;

namespace DVLDBassnisLayer
{
    public class clsBassnisPersons
    {
        public enum enMode { AddNew = 0, Update = 1 }

        public enMode Mode = enMode.AddNew;
        public int PersonID { get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int NationalityCountryID { get; set; }
        public Byte Gender { get; set; }
        public string ImagePath { get; set; }
        public DateTime DateOFbarth { get; set; }

        public clsBassnisPersons()
        {
            this.PersonID = -1;
            this.NationalNo = "";
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.Email = "";
            this.Phone = "";
            this.Address = "";
            this.Gender = 0;
            this.ImagePath = "";
            this.NationalityCountryID = -1;
            this.DateOFbarth = DateTime.Now;
            this.Mode = enMode.AddNew;
        }


        private clsBassnisPersons(int PersonID, string NationalNo,string FirstName,
            string SecondName, string ThirdName, string LastName,string Email,
            string Phone, DateTime DateOFbarth, byte Gender, string Address,
            int NationalityCountryID, string ImagePath)
        {
            this.PersonID = PersonID;
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;
            this.Address = Address;
            this.Gender = Gender;
            this.ImagePath = ImagePath;
            this.NationalityCountryID = NationalityCountryID;
            this.DateOFbarth = DateOFbarth;
            this.Mode = enMode.Update;
        }

        static public clsBassnisPersons Find(int ID)
        {

            string NationalNo = "";
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            string Email = "";
            string Phone = "";
            string Address = "";
            byte Gender = 0;
            string ImagePath = "";
            int NationalityCountryID = -1;
            DateTime DateOFbarth = DateTime.Now;

            if (clsDataAccsessPersons.GetPersonsById(ref ID,ref NationalNo, ref FirstName,
            ref SecondName, ref ThirdName, ref LastName, ref Email,
            ref Phone,ref DateOFbarth, ref Gender, ref Address,
            ref NationalityCountryID, ref ImagePath))

                return new clsBassnisPersons( ID,  NationalNo,  FirstName,
                                        SecondName,  ThirdName,  LastName,  Email,
                                        Phone,  DateOFbarth,  Gender,  Address,
                                        NationalityCountryID,  ImagePath);
                else
                return null;

        }

        static public clsBassnisPersons Find(string NationalNo)
        {

            int PersonID = -1;
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            string Email = "";
            string Phone = "";
            string Address = "";
            byte Gender = 0;
            string ImagePath = "";
            int NationalityCountryID = -1;
            DateTime DateOFbarth = DateTime.Now;

            if (clsDataAccsessPersons.GetPersonsByNationalNo(ref PersonID, ref NationalNo, ref FirstName,
            ref SecondName, ref ThirdName, ref LastName, ref Email,
            ref Phone, ref DateOFbarth, ref Gender, ref Address,
            ref NationalityCountryID, ref ImagePath))

                return new clsBassnisPersons(PersonID, NationalNo, FirstName,
                                        SecondName, ThirdName, LastName, Email,
                                        Phone, DateOFbarth, Gender, Address,
                                        NationalityCountryID, ImagePath);
            else
                return null;

        }


        private bool _AddNewPersons()
        {
            this.PersonID = (clsDataAccsessPersons.AddNewPersons(this.NationalNo,
                this.FirstName,this.SecondName,
                this.ThirdName,this.LastName,this.Email,this.Phone,this.DateOFbarth,
                this.Gender,this.Address,this.NationalityCountryID,this.ImagePath));
            return (this.PersonID != -1);
        }

        private bool _UpdatePesons()
        {
            return clsDataAccsessPersons.UpdatePersons(this.PersonID,this.NationalNo,
                this.FirstName, this.SecondName,
                this.ThirdName, this.LastName, this.Email, this.Phone, this.DateOFbarth,
                this.Gender, this.Address, this.NationalityCountryID, this.ImagePath);
        }


        public bool Save()
        {

            switch (this.Mode)
            {
                case enMode.AddNew:

                    if (_AddNewPersons())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    if (_UpdatePesons())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                  
            }
            return false;

        }

        static public bool DeletePersons(int ID)
        {
            return clsDataAccsessPersons.DeletePersons(ID);
        }


        static public DataTable GetAllDataPersons()
        {
            return clsDataAccsessPersons.GetAllDataPersons();
        }

        static public bool IsPersonsExist(int ID)
        {
            return clsDataAccsessPersons.IsPersonsExist(ID);
        }
        static public bool IsPersonsExist(string NationalNo)
        {
            return clsDataAccsessPersons.IsPersonsExist(NationalNo);
        }

    }
}
