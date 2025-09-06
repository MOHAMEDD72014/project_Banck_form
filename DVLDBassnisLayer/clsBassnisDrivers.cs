using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DVLDDataAccsess;

namespace DVLDBassnisLayer
{
    public class clsBassnisDrivers
    {
        public enum enMode { Update = 0, AddNew = 1 }

        public enMode Mode = enMode.Update;
        public int DriverID { get; set; }
        public int PersonID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedDate { get; set; }
        clsBassnisDrivers(int DriverID, int PersonID,
            int CreatedByUserID,DateTime CreatedDate)
        {
            this.DriverID = DriverID;
            this.PersonID = PersonID;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedDate = CreatedDate;

            this.Mode = enMode.Update;
        }
        public clsBassnisDrivers()
        {
            this.DriverID = -1;
            this.PersonID = -1;
            this.CreatedByUserID = -1;
            this.CreatedDate = DateTime.Now;

            this.Mode = enMode.AddNew;
        }
        static public clsBassnisDrivers Find(int ID)
        {

         
           int PersonID = -1;
           int CreatedByUserID = -1;
           DateTime CreatedDate = DateTime.Now;

            if (clsDataAccessDrivers.GetDriversByID(ID,
                ref PersonID, ref CreatedByUserID,ref CreatedDate))
            {
                return new clsBassnisDrivers(ID,PersonID,CreatedByUserID,CreatedDate);
            }
            else
            {
                return null;
            }
        }

        bool _AddNewDrivers()
        {
            this.DriverID =(clsDataAccessDrivers.AddNewDrivers(this.PersonID,
                this.CreatedByUserID,CreatedDate));

            return (this.DriverID != -1);
        }

        bool _UpdateDrivers()
        {
            return (clsDataAccessDrivers.UpdateDrivers(this.DriverID, this.PersonID,
                this.CreatedByUserID,this.CreatedDate));
        }

        public bool Save()
        {
            switch (this.Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDrivers())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    if (_UpdateDrivers())
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

        static public bool DeleteDrivers(int ID)
        {
            return clsDataAccessDrivers.DeleteDrivers(ID);
        }

        static public DataTable GetAllDrivers()
        {
            return clsDataAccessDrivers.GetAllDrivers();
        }
        static public DataTable GetAllDriversVeiw()
        {
            return clsDataAccessDrivers.GetAllDriversVeiw();
        }

        public static bool IsDriversExist(int ID)
        {
            return clsDataAccessDrivers.IsDriversExist(ID);
        }


    }
}
