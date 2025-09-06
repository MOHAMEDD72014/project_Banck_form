using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DVLDDataAccsess;
namespace DVLDBassnisLayer
{
    public class clsBassnisTests
    {
        public enum enMode { Update = 0, AddNew = 1 }
        public enMode Mode = enMode.Update;
       public int TestID { get; set; }
        public int TestAppointmentID { get; set; }
        public bool TestResult { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserID { get; set; }

         clsBassnisTests(int TestID, int testAppointmentID, bool testResult, string notes, int createdByUserID)
        {
            this.TestID = TestID;
            this.TestAppointmentID = testAppointmentID;
            this.TestResult = testResult;
            this.Notes = notes;
            this.CreatedByUserID = createdByUserID;
            this.Mode = enMode.Update;
        }

       public clsBassnisTests()
        {
            this.TestID = -1;
            this.TestAppointmentID = -1;
            this.TestResult = false;
            this.Notes = "";
            this.CreatedByUserID = -1;
            this.Mode = enMode.AddNew;
        }

        static public clsBassnisTests Find(int ID)
        {
            int TestAppointmentID = -1;
            bool TestResult = false;
            string Notes = "";
            int CreatedByUserID = -1;

            if (clsDataAccessTests.GetTestsByID(ID, ref TestAppointmentID, ref TestResult,
                ref Notes, ref CreatedByUserID))
                return new clsBassnisTests(ID, TestAppointmentID, TestResult,
                    Notes, CreatedByUserID);
            else
                return null;
        }


        static public clsBassnisTests FindByTestAppointmentID(int TestAppointmentID)
        {
            int ID = -1;
            bool TestResult = false;
            string Notes = "";
            int CreatedByUserID = -1;

            if (clsDataAccessTests.GetTestsByTestAppointmentID(ref ID,TestAppointmentID, ref TestResult,
                ref Notes, ref CreatedByUserID))
                return new clsBassnisTests(ID, TestAppointmentID, TestResult,
                    Notes, CreatedByUserID);
            else
                return null;
        }


        bool _AddNewTests()
        {
            this.TestID = (clsDataAccessTests.AddNewTests(
           this.TestAppointmentID,this.TestResult,this.Notes,this.CreatedByUserID));

            return (this.TestID != -1);
        }

        bool _UpdateTests()
        {
            return (clsDataAccessTests.UpdateTests(
            this.TestID,this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUserID));
        }

        public bool Save()
        {
            switch (this.Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTests())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    if (_UpdateTests())
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

        static public bool DeleteTests(int ID)
        {
            return clsDataAccessTests.DeleteTests(ID);
        }

        static public DataTable GetAllTests()
        {
            return clsDataAccessTests.GetAllTests();
        }

        public static bool IsTestsExist(int ID)
        {
            return clsDataAccessTests.IsTestsExist(ID);
        }
    }
}
