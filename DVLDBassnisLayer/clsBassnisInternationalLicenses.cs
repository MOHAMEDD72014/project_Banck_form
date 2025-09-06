using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DVLDDataAccsess;
using static System.Net.Mime.MediaTypeNames;

namespace DVLDBassnisLayer
{
    public class clsBassnisInternationalLicenses
    {
        enum enMode { Update = 0, AddNew = 1 }
        enMode Mode = enMode.Update;
        public int InternationalLicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int IssuedUsingLocalLicenseID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }

        clsBassnisInternationalLicenses(int InternationalLicenseID, int applicationID, int driverID,
            DateTime issueDate, DateTime expirationDate,int IssuedUsingLocalLicenseID,
            bool isActive, int createdByUserID)
        {
            this.InternationalLicenseID = InternationalLicenseID;
            this.ApplicationID = applicationID;
            this.DriverID = driverID;
            this.IssueDate = issueDate;
            this.ExpirationDate = expirationDate;
            this.IssuedUsingLocalLicenseID = IssuedUsingLocalLicenseID;
            this.IsActive = isActive;
            this.CreatedByUserID = createdByUserID;
            this.Mode = enMode.Update;
        }

        public clsBassnisInternationalLicenses()
        {
            this.InternationalLicenseID = -1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;
            this.IssuedUsingLocalLicenseID = -1;
            this.IsActive = false;
            this.CreatedByUserID = -1;
            this.Mode = enMode.AddNew;
        }

        static public clsBassnisInternationalLicenses Find(int ID)
        {

            int ApplicationID = -1,DriverID = -1, CreatedByUserID = -1;
            DateTime IssueDate = DateTime.MinValue, ExpirationDate = DateTime.MinValue;
            int IssuedUsingLocalLicenseID = -1;
            bool IsActive = false;
          

            if (clsDataAccessInternationalLicenses.GetInternationalLicensesByID(ID, ref ApplicationID, ref DriverID,
            ref IssuedUsingLocalLicenseID, ref IssueDate, ref ExpirationDate,
            ref IsActive, ref CreatedByUserID))
            {
                return new clsBassnisInternationalLicenses(ID, ApplicationID, DriverID, 
                    IssueDate, ExpirationDate, IssuedUsingLocalLicenseID,
                    IsActive, CreatedByUserID);

            }
            else
            {
                return null;
            }


        }


        static public clsBassnisInternationalLicenses FindBylLicenseID(int IssuedUsingLocalLicenseID)
        {

            int ApplicationID = -1, DriverID = -1, CreatedByUserID = -1;
            DateTime IssueDate = DateTime.MinValue, ExpirationDate = DateTime.MinValue;
            int ID = -1;
            bool IsActive = false;


            if (clsDataAccessInternationalLicenses.GetInternationalLicensesByLicenseID(ref ID, ref ApplicationID, ref DriverID,
            IssuedUsingLocalLicenseID, ref IssueDate, ref ExpirationDate,
            ref IsActive, ref CreatedByUserID))
            {
                return new clsBassnisInternationalLicenses(ID, ApplicationID, DriverID,
                    IssueDate, ExpirationDate, IssuedUsingLocalLicenseID,
                    IsActive, CreatedByUserID);

            }
            else
            {
                return null;
            }


        }
        bool _AddNewInternationalLicenses()
        {
            this.InternationalLicenseID = (clsDataAccessInternationalLicenses.AddNewInternationalLicenses(this.ApplicationID,
                this.DriverID, this.IssuedUsingLocalLicenseID, this.IssueDate, this.ExpirationDate,
                this.IsActive,this.CreatedByUserID));

            return (this.InternationalLicenseID != -1);
        }

        bool _UpdateInternationalLicenses()
        {
            return (clsDataAccessInternationalLicenses.UpdateInternationalLicenses(this.InternationalLicenseID,this.ApplicationID,
                this.DriverID, this.IssuedUsingLocalLicenseID, this.IssueDate, this.ExpirationDate,
                this.IsActive, this.CreatedByUserID));
        }

        public bool Save()
        {
            switch (this.Mode)
            {
                case enMode.AddNew:
                    if (_AddNewInternationalLicenses())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    if (_UpdateInternationalLicenses())
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

        static public bool DeleteInternationalLicenses(int ID)
        {
            return clsDataAccessInternationalLicenses.DeleteInternationalLicenses(ID);
        }

        static public DataTable GetAllInternationalLicenses()
        {
            return clsDataAccessInternationalLicenses.GetAllInternationalLicenses();
        }

        static public DataTable GetAllInternationalLicensesByDriverID(int DriverID)
        {
            return clsDataAccessInternationalLicenses.GetAllInternationalLicensesByDriverID(DriverID);
        }
        public static bool IsInternationalLicensesExistByID(int ID)
        {
            return clsDataAccessInternationalLicenses.IsInternationalLicensesExist(ID);
        }
        public static bool IsInternationalLicensesExistByDriverID(int DriverID)
        {
            return clsDataAccessInternationalLicenses.IsInternationalLicensesExistByDriverID(DriverID);
        }


    }
}
