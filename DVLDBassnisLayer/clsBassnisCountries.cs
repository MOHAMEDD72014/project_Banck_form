using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLDDataAccsess;
using System.Runtime.CompilerServices;

namespace DVLDBassnisLayer
{
    public class clsBassnisCountries
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.Update;
        public int CountryID { get; set; }
        public string CountryName { get; set; }

        clsBassnisCountries(int CountryID, string CountryName)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;
            Mode = enMode.Update;   
        }

       static public clsBassnisCountries Find(int ID)
        {
            string CountryName = "";
            if (clsDataAccsessCountries.GetByCountryId( ID,ref CountryName)){

                return new clsBassnisCountries(ID,CountryName);

            }
            else
            {
                return null;
            }

           
        }

        static public clsBassnisCountries Find(string Name)
        {
            int CountryID = -1;
            if (clsDataAccsessCountries.GetByCountryName(ref CountryID,Name))
            {

                return new clsBassnisCountries(CountryID, Name);

            }
            else
            {
                return null;
            }


        }


        static public DataTable GetAllCountry()
        {
            return clsDataAccsessCountries.GetAllCountry();
        }


    }
}
