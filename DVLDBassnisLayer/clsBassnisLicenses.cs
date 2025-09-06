using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DVLDDataAccsess;
using System.Runtime.CompilerServices;
namespace DVLDBassnisLayer
{
    public class clsBassnisLicenses
    {
        enum enMode { Update = 0, AddNew = 1 }
        enMode Mode = enMode.Update;
        public int LicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int LicenseClass { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public double PaidFees { get; set; }
        public bool IsActive { get; set; }
        public byte IssueReason { get; set; }
        public int CreatedByUserID { get; set; }

        clsBassnisLicenses(int licenseID, int applicationID, int driverID, int licenseClass,
            DateTime issueDate, DateTime expirationDate, string notes, double paidFees,
            bool isActive, byte issueReason, int createdByUserID)
        {
            this.LicenseID = licenseID;
            this.ApplicationID = applicationID;
            this.DriverID = driverID;
            this.LicenseClass = licenseClass;
            this.IssueDate = issueDate;
            this.ExpirationDate = expirationDate;
            this.Notes = notes;
            this.PaidFees = paidFees;
            this.IsActive = isActive;
            this.IssueReason = issueReason;
            this.CreatedByUserID = createdByUserID;
            this.Mode = enMode.Update;
        }

        public clsBassnisLicenses()
        {
            this.LicenseID = -1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.LicenseClass = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now.AddYears(5);
            this.Notes = "";
            this.PaidFees = 0.0;
            this.IsActive = false;
            this.IssueReason = 1;
            this.CreatedByUserID = -1;
            this.Mode = enMode.AddNew;
        }

        static public clsBassnisLicenses Find(int ID)
        {

            int ApplicationID = -1, DriverID = -1, LicenseClass = -1, CreatedByUserID = -1;
            DateTime IssueDate = DateTime.MinValue, ExpirationDate = DateTime.MinValue;
            string Notes = "";
            double PaidFees = 0.0;
            bool IsActive = false;
            byte IssueReason = 1;

            if (clsDataAccessLicenses.GetLicensesByID(  ID, ref ApplicationID, ref DriverID,
            ref   LicenseClass, ref IssueDate, ref ExpirationDate,
            ref Notes, ref  PaidFees,
            ref IsActive, ref IssueReason, ref CreatedByUserID)){


                return new clsBassnisLicenses(ID, ApplicationID, DriverID, LicenseClass,
                    IssueDate, ExpirationDate, Notes, PaidFees,
                    IsActive, IssueReason, CreatedByUserID);

            }
            else
            {
                return null;
            }

           
        }


        static public clsBassnisLicenses FindByApplicationID(int ApplicationID)
        {

            int ID = -1, DriverID = -1, LicenseClass = -1, CreatedByUserID = -1;
            DateTime IssueDate = DateTime.MinValue, ExpirationDate = DateTime.MinValue;
            string Notes = "";
            double PaidFees = 0.0;
            bool IsActive = false;
            byte IssueReason = 1;

            if (clsDataAccessLicenses.GetLicensesByApplicationID(ref ID, ApplicationID, ref DriverID,
            ref LicenseClass, ref IssueDate, ref ExpirationDate,
            ref Notes, ref PaidFees,
            ref IsActive, ref IssueReason, ref CreatedByUserID))
            {


                return new clsBassnisLicenses(ID, ApplicationID, DriverID, LicenseClass,
                    IssueDate, ExpirationDate, Notes, PaidFees,
                    IsActive, IssueReason, CreatedByUserID);

            }
            else
            {
                return null;
            }


        }

        bool _AddNewLicenses()
        {
            this.LicenseID = (clsDataAccessLicenses.AddNewLicenses(this.ApplicationID,
                this.DriverID,this.LicenseClass,
                    this.IssueDate, this.ExpirationDate, this.Notes, this.PaidFees,
                    this.IsActive, this.IssueReason, this.CreatedByUserID
             ));

            return (this.LicenseID != -1);
        }

        bool _UpdateLicenses()
        {
            return (clsDataAccessLicenses.UpdateLicenses(
             this.LicenseID,this.ApplicationID,
                this.DriverID, this.LicenseClass,
                    this.IssueDate, this.ExpirationDate,this.Notes,this.PaidFees,
                    this.IsActive, this.IssueReason, this.CreatedByUserID));
        }

        public bool Save()
        {
            switch (this.Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLicenses())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    if (_UpdateLicenses())
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

        static public bool DeleteLicenses(int ID)
        {
            return clsDataAccessLicenses.DeleteLicenses(ID);
        }

        static public DataTable GetAllLicenses()
        {
            return clsDataAccessLicenses.GetAllLicenses();
        }
        static public DataTable GetAllLicenseByLocalID(int LocalID)
        {
            return clsDataAccessLicenses.GetAllLicensesByLocalID(LocalID);
        }

        public static bool IsLicensesExist(int ID)
        {
            return clsDataAccessLicenses.IsLicensesExist(ID);
        }


    }
}
