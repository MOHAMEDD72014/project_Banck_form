using DVLDDataAccsess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBassnisLayer
{
    public class clsBassnisUsers
    {

        enum EnMode { AddNew = 0, Update = 1 }
        EnMode Mode= EnMode.Update;
       public int UsersID {  get; set; }
       public int PersonID {  get; set; }
        public string UserName { get; set; }
       public string Password {  get; set; }
       public bool IsActive {  get; set; }


      public clsBassnisUsers()
        {
            this.UsersID = -1;
            this.PersonID = -1;
            this.UserName = "";
            this.Password = "";
            this.IsActive = false;
            this.Mode= EnMode.AddNew;
        }

        clsBassnisUsers(int iD, int personID, string userName, string password, bool isActive)
        {
            
            this.UsersID = iD;
            this.PersonID = personID;
            this.UserName = userName;
            this.Password = password;
            this.IsActive = isActive;
            this.Mode= EnMode.Update;
        }

        static public clsBassnisUsers Find(int ID)
        {

            int personID = -1;
            string userName = "";
            string password = "";
            bool isActive = false;
            if (clsDataAccsessUsers.GetUsersById(ID,ref personID ,ref userName,
                ref password,ref isActive))
            {
                return new clsBassnisUsers(ID,personID,userName,password,isActive);
            }
            else
            {
                return null;
            }
        }


        static public clsBassnisUsers FindByUserAndPassword(string UserName, string Password)
        {
            int UserID = -1;
            int personID = -1;
            bool isActive = false;

            if (clsDataAccsessUsers.GetByUserNameAndPassword(ref UserID, ref personID, ref UserName,
                ref Password, ref isActive))

                return new clsBassnisUsers(UserID, personID, UserName, Password, isActive);
            else

                return null;
        }


        bool _AddNewUsers()
        {
            this.UsersID = (clsDataAccsessUsers.AddNewUsers(this.PersonID, this.UserName,
                this.Password, this.IsActive));

            return (this.UsersID != -1);
        }

        public bool Save()
        {
            switch (this.Mode)
            {
                case EnMode.AddNew:
                    if (_AddNewUsers())
                    {
                        Mode = EnMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case EnMode.Update:
                    if (_UpdateUsers())
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

        bool _UpdateUsers()
        {
            return (clsDataAccsessUsers.UpdateUsers(this.UsersID, this.PersonID, this.UserName
                , this.Password, this.IsActive));
            
        }

      static public bool DeleteUsers(int ID)
        {
            return clsDataAccsessUsers.DeleteUsers(ID);
        }

        static public DataTable GetAllDataUsers()
        {
            return clsDataAccsessUsers.GetAllDataUsers();
        }



    }
}
