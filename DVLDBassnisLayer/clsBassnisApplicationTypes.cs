using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DVLDDataAccsess;
namespace DVLDBassnisLayer
{
   public class clsBassnisApplicationTypes
    {
        enum enMode {Update=0,AddNew=1}
        enMode Mode= enMode.Update;
       public int ApplicationTypeID {  get; set; }
       public string ApplicationTypeTitle {  get; set; }
       public double ApplicationFees {  get; set; }
        public clsBassnisApplicationTypes()
        {
            this.ApplicationTypeID = -1;
            this.ApplicationTypeTitle = "";
            this.ApplicationFees = 0;
            this.Mode= enMode.AddNew;
        }

        clsBassnisApplicationTypes( int applicationTypeID, string applicationTypeTitle, double applicationFees)
        {
            
           this.ApplicationTypeID = applicationTypeID;
            this.ApplicationTypeTitle = applicationTypeTitle;
            this.ApplicationFees = applicationFees;
            this.Mode= enMode.Update;
        }


        static public clsBassnisApplicationTypes Find(int ID)
        {

            string applicationTypeTitle = ""; double applicationFees = 0;
           if( clsDataAccessApplicationType.GetApplicationTypeByID(ID, ref applicationTypeTitle, ref applicationFees))
            {
                return new clsBassnisApplicationTypes(ID,applicationTypeTitle,applicationFees);
            }
            else
            {
                return null;
            }

        }




        bool _AddNewApplicationTypes()
        {
            this.ApplicationTypeID = (clsDataAccessApplicationType.AddNewApplicationTypes(
                this.ApplicationTypeTitle, this.ApplicationFees));

            return (this.ApplicationTypeID != -1);
        }

        bool _UpdateApplicationTypes()
        {
            return (clsDataAccessApplicationType.UpdateApplicationTypes(this.ApplicationTypeID,
                this.ApplicationTypeTitle, this.ApplicationFees));
        }

        public bool Save()
        {
            switch (this.Mode)
            {
                case enMode.AddNew:
                    if (_AddNewApplicationTypes())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                    case enMode.Update:
                    if (_UpdateApplicationTypes())
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

        static public bool DeleteApplicationTypes(int ID)
        {
            return clsDataAccessApplicationType.DeleteApplicationTypes(ID);
        }

        static public DataTable GetAllApplicationTypes()
        {
            return clsDataAccessApplicationType.GetAllApplicationTypes();
        }

        public static bool IsApplicationTypesExist(int ID)
        {
            return clsDataAccessApplicationType.IsApplicationTypesExist(ID);
        }



    }
}
