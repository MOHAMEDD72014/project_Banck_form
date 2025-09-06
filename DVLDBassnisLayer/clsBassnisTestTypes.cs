using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DVLDDataAccsess;
namespace DVLDBassnisLayer
{
   public class clsBassnisTestTypes
    {
        enum enMode { Update = 0, AddNew = 1 }
        enMode Mode = enMode.Update;
        public int TestTypeID { get; set; }
        public string TestTypeTitle { get; set; }
        public string TestTypeDescription { get; set; }
        public double TestTypeFees { get; set; }

        clsBassnisTestTypes(int testTypeID, string testTypeTitle, string testTypeDescription, double testTypeFees)
        {
            this.TestTypeID = testTypeID;
            this.TestTypeTitle = testTypeTitle;
            this.TestTypeDescription = testTypeDescription;
            this.TestTypeFees = testTypeFees;
            this.Mode = enMode.Update;
        }

        public clsBassnisTestTypes()
        {
            this.TestTypeID = -1;
            this.TestTypeTitle = "";
            this.TestTypeDescription = "";
            this.TestTypeFees = 0.0;
            this.Mode = enMode.AddNew;
        }

        static public clsBassnisTestTypes Find(int ID)
        {
            string TestTypeTitle = "";
            string TestTypeDescription = "";
            double TestTypeFees = 0.0;

            if (clsDataAccessTestTypes.GetTestTypesByID(ID, ref TestTypeTitle, ref TestTypeDescription, ref TestTypeFees))
                return new clsBassnisTestTypes(ID, TestTypeTitle, TestTypeDescription, TestTypeFees);
            else
                return null;
        }


        bool _AddNewTestTypes()
        {
            this.TestTypeID = (clsDataAccessTestTypes.AddNewTestTypes(
           this.TestTypeTitle,this.TestTypeDescription,this.TestTypeFees));

            return (this.TestTypeID != -1);
        }

        bool _UpdateTestTypes()
        {
            return (clsDataAccessTestTypes.UpdateTestTypes(
            this.TestTypeID,this.TestTypeTitle, this.TestTypeDescription, this.TestTypeFees));
        }

        public bool Save()
        {
            switch (this.Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTestTypes())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    if (_UpdateTestTypes())
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

        static public bool DeleteTestTypes(int ID)
        {
            return clsDataAccessTestTypes.DeleteTestTypes(ID);
        }

        static public DataTable GetAllTestTypes()
        {
            return clsDataAccessTestTypes.GetAllTestTypes();
        }

        public static bool IsTestTypesExist(int ID)
        {
            return clsDataAccessTestTypes.IsTestTypesExist(ID);
        }



    }
}
