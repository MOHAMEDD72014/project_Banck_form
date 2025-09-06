using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DVLDDataAccsess;
namespace DVLDBassnisLayer
{
    public class clsBassnisTestAppointments
    {
        public enum enMode { Update = 0, AddNew = 1 }

        public enMode Mode = enMode.Update;
        public int TestAppointmentID { get; set; }
        public int TestTypeID { get; set; }
        public int LocalDrivingLicenseApplicationID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public Double PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsLocked { get; set; }
        public int RetakeTestApplicationID { get; set; }


        clsBassnisTestAppointments(int TestAppointmentID, int TestTypeID,
             int LocalDrivingLicenseApplicationID, DateTime AppointmentDate,
             Double PaidFees, int CreatedByUserID,
             bool IsLocked, int RetakeTestApplicationID)
        {
            this.TestAppointmentID = TestAppointmentID;
            this.TestTypeID = TestTypeID;
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.AppointmentDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsLocked = IsLocked;
            this.RetakeTestApplicationID = RetakeTestApplicationID;

            this.Mode = enMode.Update;
        }

        public clsBassnisTestAppointments()
        {
            this.TestAppointmentID = -1;
            this.TestTypeID = -1;
            this.LocalDrivingLicenseApplicationID = -1;
            this.AppointmentDate = DateTime.Now;
            this.PaidFees = 0.0;
            this.CreatedByUserID = -1;
            this.IsLocked = false;
            this.RetakeTestApplicationID = -1;
            this.Mode = enMode.AddNew;
        }

        static public clsBassnisTestAppointments Find(int ID)
        {
            
            int TestTypeID = -1;
            int LocalDrivingLicenseApplicationID = -1;
            DateTime AppointmentDate = DateTime.Now;
            double PaidFees = 0.0;
            int CreatedByUserID = -1;
            bool IsLocked = false;
            int RetakeTestApplicationID = -1;

            clsDataAccessTestAppointments.GetTestAppointmentsByID(ID, ref TestTypeID,
             ref LocalDrivingLicenseApplicationID, ref AppointmentDate,
             ref PaidFees, ref CreatedByUserID, ref IsLocked, ref RetakeTestApplicationID);

            return new clsBassnisTestAppointments(ID, TestTypeID,
                LocalDrivingLicenseApplicationID, AppointmentDate,
                PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID);

                

        }


        static public clsBassnisTestAppointments FindbyLocalDrivingLicenseApplicationID(int LocalDrivingLicenseApplicationID)
        {

            int TestTypeID = -1;
            int ID = -1;
            DateTime AppointmentDate = DateTime.Now;
            double PaidFees = 0.0;
            int CreatedByUserID = -1;
            bool IsLocked = false;
            int RetakeTestApplicationID = -1;

            clsDataAccessTestAppointments.GetTestAppointmentsByLocalDrivingLicenseApplicationID(ref ID, ref TestTypeID,
              LocalDrivingLicenseApplicationID, ref AppointmentDate,
             ref PaidFees, ref CreatedByUserID, ref IsLocked, ref RetakeTestApplicationID);

            return new clsBassnisTestAppointments(ID, TestTypeID,
                LocalDrivingLicenseApplicationID, AppointmentDate,
                PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID);



        }
        bool _AddNewTestAppointments()
        {
            this.TestAppointmentID = (clsDataAccessTestAppointments.AddNewTestAppointments(
          this.TestTypeID,this.LocalDrivingLicenseApplicationID,this.AppointmentDate,
          this.PaidFees,this.CreatedByUserID,this.IsLocked,this.RetakeTestApplicationID));

            return (this.TestAppointmentID != -1);
        }

        bool _UpdateTestAppointments()
        {
            return (clsDataAccessTestAppointments.UpdateTestAppointments(this.TestAppointmentID,
            this.TestTypeID, this.LocalDrivingLicenseApplicationID, this.AppointmentDate,
          this.PaidFees, this.CreatedByUserID, this.IsLocked, this.RetakeTestApplicationID));
        }

        public bool Save()
        {
            switch (this.Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTestAppointments())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    if (_UpdateTestAppointments())
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

        static public bool DeleteTestAppointments(int ID)
        {
            return clsDataAccessTestAppointments.DeleteTestAppointments(ID);
        }

        static public DataTable GetAllTestAppointments()
        {
            return clsDataAccessTestAppointments.GetAllTestAppointments();
        }

        static public DataTable GetAllTestAppointments(int LocalID)
        {
            return clsDataAccessTestAppointments.GetAllTestAppointments(LocalID);
        }
        static public DataTable GetAllTestAppointments(int LocalID, int typeID)
        {
            return clsDataAccessTestAppointments.GetAllTestAppointments(LocalID,typeID);
        }

        public static bool IsTestAppointmentsExist(int ID)
        {
            return clsDataAccessTestAppointments.IsTestAppointmentsExist(ID);
        }



    }
}
