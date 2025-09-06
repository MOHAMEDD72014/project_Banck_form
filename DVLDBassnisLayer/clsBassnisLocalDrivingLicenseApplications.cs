using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DVLDDataAccsess;

namespace DVLDBassnisLayer
{
    public class clsBassnisLocalDrivingLicenseApplications
    {
        public enum enMode { Update = 0, AddNew = 1 }

        public enMode Mode = enMode.Update;
        public int LocalDrivingLicenseApplicationID { get; set; }
        public int ApplicationID { get; set; }
        public int LicenseClassID { get; set; }
        clsBassnisLocalDrivingLicenseApplications(int LocalDrivingLicenseApplicationID, int ApplicationID,
            int LicenseClassID)
        {
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.ApplicationID = ApplicationID;
            this.LicenseClassID = LicenseClassID;

            this.Mode = enMode.Update;
        }
        public clsBassnisLocalDrivingLicenseApplications()
        {
            this.LocalDrivingLicenseApplicationID = -1;
            this.ApplicationID = -1;
            this.LicenseClassID = -1;

            this.Mode = enMode.AddNew;
        }
        static public clsBassnisLocalDrivingLicenseApplications Find(int ID)
        {
           
            int ApplicationID = -1;
            int LicenseClassID = -1;

            if (clsDataAccessLocalDrivingLicenseApplications.GetLocalDrivingLicenseApplicationsByID(ID,
                ref ApplicationID, ref LicenseClassID))
            {
                return new clsBassnisLocalDrivingLicenseApplications(ID, ApplicationID, LicenseClassID);
            }
            else
            {
                return null;
            }
        }

        static public clsBassnisLocalDrivingLicenseApplications FindByApplicationID(int ApplicationID)
        {

            int ID = -1;
            int LicenseClassID = -1;

            if (clsDataAccessLocalDrivingLicenseApplications.GetLocalDrivingLicenseApplicationsByApplicationID(ref ID,
                 ApplicationID, ref LicenseClassID))
            {
                return new clsBassnisLocalDrivingLicenseApplications(ID, ApplicationID, LicenseClassID);
            }
            else
            {
                return null;
            }
        }

        bool _AddNewLocalDrivingLicenseApplications()
        {
            this.LocalDrivingLicenseApplicationID =
                (clsDataAccessLocalDrivingLicenseApplications.AddNewLocalDrivingLicenseApplications(this.ApplicationID,
                this.LicenseClassID));

            return (this.LocalDrivingLicenseApplicationID != -1);
        }

        bool _UpdateLocalDrivingLicenseApplications()
        {
            return (clsDataAccessLocalDrivingLicenseApplications.UpdateLocalDrivingLicenseApplications(this.LocalDrivingLicenseApplicationID,this.ApplicationID,
                this.LicenseClassID));
        }

        public bool Save()
        {
            switch (this.Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLocalDrivingLicenseApplications())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    if (_UpdateLocalDrivingLicenseApplications())
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

        static public bool DeleteLocalDrivingLicenseApplications(int ID)
        {
            return clsDataAccessLocalDrivingLicenseApplications.DeleteLocalDrivingLicenseApplications(ID);
        }

        static public DataTable GetAllLocalDrivingLicenseApplications()
        {
            return clsDataAccessLocalDrivingLicenseApplications.GetAllLocalDrivingLicenseApplications();
        }

        public static bool IsLocalDrivingLicenseApplicationsExist(int ID)
        {
            return clsDataAccessLocalDrivingLicenseApplications.IsLocalDrivingLicenseApplicationsExist(ID);
        }
    }
}
