using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DVLDDataAccsess;

namespace DVLDBassnisLayer
{

    public class clsBassnisLicenseClasses
    {
        public enum enMode { Update = 0, AddNew = 1 }

        public enMode Mode = enMode.Update;
        public int LicenseClassID { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public byte MinimumAllowedAge { get; set; }
        public byte DefaultValidityLength { get; set; }
        public double ClassFees { get; set; }



        clsBassnisLicenseClasses(int LicenseClassID, string ClassName,
           string ClassDescription, byte MinimumAllowedAge,
           byte DefaultValidityLength, double ClassFees)
        {
            this.LicenseClassID = LicenseClassID;
            this.ClassName = ClassName;
            this.ClassDescription = ClassDescription;
            this.MinimumAllowedAge = MinimumAllowedAge;
            this.DefaultValidityLength = DefaultValidityLength;
            this.ClassFees = ClassFees;

            this.Mode = enMode.Update;
        }

        public clsBassnisLicenseClasses()
        {
            this.LicenseClassID = -1;
            this.ClassName = "";
            this.ClassDescription = "";
            this.MinimumAllowedAge = 0;
            this.DefaultValidityLength =0;
            this.ClassFees = 0;

            this.Mode = enMode.AddNew;
        }

        static public clsBassnisLicenseClasses Find(int ID)
        {

            int LicenseClassID = -1;
            string ClassName = "";
            string ClassDescription = "";
            byte MinimumAllowedAge = 0;
            byte DefaultValidityLength = 0;
            double ClassFees = 0;

            clsDataAccessLicenseClasses.GetLicenseClassesByID(ID,
             ref ClassName, ref ClassDescription,
             ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees);

            return new clsBassnisLicenseClasses(ID,
             ClassName, ClassDescription,
             MinimumAllowedAge, DefaultValidityLength, ClassFees);



        }

        bool _AddNewLicenseClasses()
        {
            this.LicenseClassID = (clsDataAccessLicenseClasses.AddNewLicenseClasses(this.ClassName,
                this.ClassDescription, this.MinimumAllowedAge, this.DefaultValidityLength, this.ClassFees));

            return (this.LicenseClassID != -1);
        }

        bool _UpdateLicenseClasses()
        {
            return (clsDataAccessLicenseClasses.UpdateLicenseClasses(this.LicenseClassID,this.ClassName,
                this.ClassDescription, this.MinimumAllowedAge, this.DefaultValidityLength, this.ClassFees));
        }

        public bool Save()
        {
            switch (this.Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLicenseClasses())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    if (_UpdateLicenseClasses())
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

        static public bool DeleteLicenseClasses(int ID)
        {
            return clsDataAccessLicenseClasses.DeleteLicenseClasses(ID);
        }

        static public DataTable GetAllLicenseClasses()
        {
            return clsDataAccessLicenseClasses.GetAllLicenseClasses();
        }

        public static bool IsTLicenseClassesExist(int ID)
        {
            return clsDataAccessLicenseClasses.IsLicenseClassesExist(ID);
        }




    }
}
