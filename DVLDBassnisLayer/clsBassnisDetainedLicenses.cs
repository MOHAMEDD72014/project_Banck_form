using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DVLDDataAccsess;
using System.ComponentModel;

namespace DVLDBassnisLayer
{
    public class clsBassnisDetainedLicenses
    {
        enum enMode { Update = 0, AddNew = 1 }
        enMode Mode = enMode.Update;
        public int DetainID { get; set; }
        public int LicenseID { get; set; }
        public DateTime DetainDate { get; set; }
        public double FineFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsReleased { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int ReleasedByUserID { get; set; }
        public int ReleaseApplicationID { get; set; }


        clsBassnisDetainedLicenses(int detainID, int licenseID, DateTime detainDate, double fineFees, int createdByUserID,
            bool isReleased, DateTime releaseDate, int releasedByUserID, int releaseApplicationID)
        {
            this.DetainID = detainID;
            this.LicenseID = licenseID;
            this.DetainDate = detainDate;
            this.FineFees = fineFees;
            this.CreatedByUserID = createdByUserID;
            this.IsReleased = isReleased;
            this.ReleaseDate = releaseDate;
            this.ReleasedByUserID = releasedByUserID;
            this.ReleaseApplicationID = releaseApplicationID;
            this.Mode = enMode.Update;
        }

        public clsBassnisDetainedLicenses()
        {
            this.DetainID = -1;
            this.LicenseID = -1;
            this.DetainDate = DateTime.Now;
            this.FineFees = 0;
            this.CreatedByUserID = -1;
            this.IsReleased = false;
            this.ReleaseDate = DateTime.Now;
            this.ReleasedByUserID = -1;
            this.ReleaseApplicationID = -1;
            this.Mode = enMode.AddNew;
        }

        static public clsBassnisDetainedLicenses Find(int ID)
        {

           
           int LicenseID = -1;
           DateTime DetainDate = DateTime.Now;
           double FineFees = 0;
           int CreatedByUserID = -1;
           bool IsReleased = false;
           DateTime ReleaseDate = DateTime.Now;
           int ReleasedByUserID = -1;
           int ReleaseApplicationID = -1;

            if (clsDataAccessDetainedLicenses.GetDetainedLicensesByID(ID, 
            ref  LicenseID, ref  CreatedByUserID,
            ref  DetainDate, ref  IsReleased, ref  ReleaseDate,
            ref FineFees, ref  ReleasedByUserID, ref  ReleaseApplicationID))
            {
                return new clsBassnisDetainedLicenses(ID,LicenseID, DetainDate, FineFees,CreatedByUserID,
             IsReleased,  ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            }
            else
            {
                return null;
            }

        }




        bool _AddNewDetainedLicenses()
        {
            this.DetainID = (clsDataAccessDetainedLicenses.AddNewDetainedLicenses(this.LicenseID,
                this.CreatedByUserID,this.DetainDate,this.IsReleased,this.ReleaseDate,
              this.FineFees,this.ReleasedByUserID,this.ReleaseApplicationID
             ));

            return (this.DetainID != -1);
        }

        bool _UpdateDetainedLicenses()
        {
            return (clsDataAccessDetainedLicenses.UpdateDetainedLicenses(
             this.DetainID,this.LicenseID,
             this.CreatedByUserID, this.DetainDate, this.IsReleased, this.ReleaseDate,
             this.FineFees, this.ReleasedByUserID, this.ReleaseApplicationID));
        }

        public bool Save()
        {
            switch (this.Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDetainedLicenses())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    if (_UpdateDetainedLicenses())
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

        static public bool DeleteDetainedLicenses(int ID)
        {
            return clsDataAccessDetainedLicenses.DeleteDetainedLicenses(ID);
        }

        static public DataTable GetAllDetainedLicenses()
        {
            return clsDataAccessDetainedLicenses.GetAllDetainedLicenses();
        }

        public static bool IsDetainedLicensesExist(int ID)
        {
            return clsDataAccessDetainedLicenses.IsDetainedLicensesExist(ID);
        }

    }
}
