using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DVLDDataAccsess;
namespace DVLDBassnisLayer
{
    public class clsBassnisApplications
    {
        enum enMode { Update = 0, AddNew = 1 }
        enMode Mode = enMode.Update;
        public int ApplicationID { get; set; }
        public int ApplicantPersonID { get; set; }
        public DateTime ApplicationDate { get; set; }
        public int ApplicationTypeID { get; set; }
        public Byte ApplicationStatus { get; set; }
        public DateTime LastStatusDate { get; set; }
        public double PaidFees { get; set; }
        public int CreatedByUserID { get; set; }

        clsBassnisApplications(int applicationID, int applicantPersonID, DateTime applicationDate, int applicationTypeID, byte applicationStatus, DateTime lastStatusDate, double paidFees, int createdByUserID)
        {
           
            this.ApplicationID = applicationID;
            this.ApplicantPersonID = applicantPersonID;
            this.ApplicationDate = applicationDate;
            this.ApplicationTypeID = applicationTypeID;
            this.ApplicationStatus = applicationStatus;
            this.LastStatusDate = lastStatusDate;
            this.PaidFees = paidFees;
            this.CreatedByUserID = createdByUserID;
            this.Mode = enMode.Update;
        }

       public clsBassnisApplications()
        {

            this.ApplicationID = -1;
            this.ApplicantPersonID = -1;
            this.ApplicationDate = DateTime.Now;
            this.ApplicationTypeID = -1;
            this.ApplicationStatus = 1;
            this.LastStatusDate = DateTime.Now;
            this.PaidFees = 0;
            this.CreatedByUserID = -1;
            this.Mode = enMode.AddNew;
        }

        static public clsBassnisApplications Find(int ID)
        {

            int ApplicantPersonID=-1;
            DateTime ApplicationDate = DateTime.Now;
            int ApplicationTypeID = -1;
            byte ApplicationStatus = 1;
            DateTime LastStatusDate = DateTime.Now;
            double PaidFees = 0;
            int CreatedByUserID = -1;

            if (clsDataAccessApplications.GetApplicationsByID(ID, ref ApplicantPersonID,
            ref ApplicationDate, ref  ApplicationTypeID, ref ApplicationStatus,
            ref  LastStatusDate, ref  PaidFees, ref  CreatedByUserID))
            {
                return new clsBassnisApplications(ID,ApplicantPersonID,
            ApplicationDate,ApplicationTypeID,ApplicationStatus,
            LastStatusDate,PaidFees,CreatedByUserID);
            }
            else
            {
                return null;
            }

        }

        static public clsBassnisApplications FindByPersonID(int PersonID)
        {

            int ID = -1;
            DateTime ApplicationDate = DateTime.Now;
            int ApplicationTypeID = -1;
            byte ApplicationStatus = 1;
            DateTime LastStatusDate = DateTime.Now;
            double PaidFees = 0;
            int CreatedByUserID = -1;

            if (clsDataAccessApplications.GetApplicationsByApplicantPersonID(ref ID, PersonID,
            ref ApplicationDate, ref ApplicationTypeID, ref ApplicationStatus,
            ref LastStatusDate, ref PaidFees, ref CreatedByUserID))
            {
                return new clsBassnisApplications(ID, PersonID,
            ApplicationDate, ApplicationTypeID, ApplicationStatus,
            LastStatusDate, PaidFees, CreatedByUserID);
            }
            else
            {
                return null;
            }

        }




        bool _AddNewApplications()
        {
            this.ApplicationID = (clsDataAccessApplications.AddNewApplications(
             this.ApplicantPersonID,this.ApplicationDate,this.ApplicationTypeID,
              this.ApplicationStatus,this.LastStatusDate,this.PaidFees,this.CreatedByUserID));

            return (this.ApplicationID != -1);
        }

        bool _UpdateApplications()
        {
            return (clsDataAccessApplications.UpdateApplications(
             this.ApplicationID,this.ApplicantPersonID,this.ApplicationDate, this.ApplicationTypeID,
              this.ApplicationStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID));
        }

        public bool Save()
        {
            switch (this.Mode)
            {
                case enMode.AddNew:
                    if (_AddNewApplications())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    if (_UpdateApplications())
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

        static public bool DeleteApplications(int ID)
        {
            return clsDataAccessApplications.DeleteApplications(ID);
        }

        static public DataTable GetAllApplications()
        {
            return clsDataAccessApplications.GetAllApplications();
        }

        static public DataTable GetDataViueAppLicatin()
        {

            return clsDataAccessApplications.GetDataViueAppLicatin();
        }
        public static bool IsApplicationsExist(int ID)
        {
            return clsDataAccessApplications.IsApplicationsExist(ID);
        }
        public static bool IsApplicationsExist(int IDApplicantPersonID,int ApplicationTypeID)
        {
            return clsDataAccessApplications.IsApplicationsExist(IDApplicantPersonID, ApplicationTypeID);
        }


    }
}
