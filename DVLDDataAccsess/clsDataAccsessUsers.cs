using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Policy;

namespace DVLDDataAccsess
{
    public class clsDataAccsessUsers
    {

        static public bool GetUsersById(int ID,ref int PersonID,
           ref string UserName,ref string Password,ref bool IsActive)
        {
            bool IsFind = false;
            string Qury = @"Select *From Users where UserID = @UserID;";
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);

            SqlCommand command=new SqlCommand(Qury, connection);
            command.Parameters.AddWithValue("@UserID", ID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    PersonID = (int)reader["PersonID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];
                    IsFind = true;
                }
            }
            catch (Exception ex)
            {

                IsFind = false;
            }
            finally
            {
                connection.Close();
            }



            return IsFind;
        }

        static public bool GetByUserNameAndPassword(ref int ID, ref int PersonID,
           ref string UserName, ref string Password, ref bool IsActive)
        {
            bool IsFind = false;
            string Qury = @"Select *From Users where UserName = @UserName AND Password=@Password;";
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);

            SqlCommand command = new SqlCommand(Qury, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("Password", Password);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ID = (int)reader["UserID"];
                    PersonID = (int)reader["PersonID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];
                    IsFind = true;
                }
            }
            catch (Exception ex)
            {

                IsFind = false;
            }
            finally
            {
                connection.Close();
            }



            return IsFind;
        }

        static public int AddNewUsers(int personID, string userName, string password, bool isActive)
        {
            int rows = -1;

            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string Qury = @"insert into Users (personID,userName,password,isActive)
                                    VALUES(@personID,@userName,@password,@isActive)
                                          SELECT SCOPE_IDENTITY();";


            SqlCommand command = new SqlCommand(Qury, connection);
            command.Parameters.AddWithValue("@personID", personID);
            command.Parameters.AddWithValue("@userName", userName);
            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@isActive", isActive);
          
            try
            {
                connection.Open();
              
                object opj=command.ExecuteScalar();
                if (opj != null && int.TryParse(opj.ToString(), out int reslt))
                {
                    rows= reslt;


                }

            }
            catch (Exception ex)
            {


            }finally {

                connection.Close();

            }
            return rows;
        }

        static public bool UpdateUsers(int UserID, int personID, string userName, string password, bool isActive)
        {
            int Row = -1;

            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string Qury = @"Update  Users  
                            set personID = @personID, 
                                userName = @userName, 
                                password = @password, 
                                isActive = @isActive 
                                where UserID = @UserID;";

            SqlCommand command = new SqlCommand( Qury, connection);
            command.Parameters.AddWithValue("@UserID"  ,UserID);
            command.Parameters.AddWithValue("@personID", personID);
            command.Parameters.AddWithValue("@userName", userName);
            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@isActive", isActive);
            try
            {
                connection.Open();
                Row = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                

            }
            finally
            {
                connection.Close();
            }

            return (Row > 0);
        }

        public static bool DeleteUsers(int ID)
        {
            int RowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string qury = @" Delete Users
                          where UserID=@UserID";
            SqlCommand command = new SqlCommand(qury, connection);

            command.Parameters.AddWithValue("@UserID", ID);
            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();


            }
            catch (Exception EX)
            {

            }
            finally
            {
                connection.Close();
            }
            return (RowsAffected > 0);
        }

        public static DataTable GetAllDataUsers()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string query = @"SELECT Users.UserID, Users.PersonID, Users.UserName, Users.Password, Users.IsActive,
                           Concat(People.FirstName,' ',People.SecondName,' ',People.ThirdName,' ',People.LastName) AS FullName
                           FROM  Users INNER JOIN
                           People ON Users.PersonID = People.PersonID";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dataTable.Load(reader);
                }
                reader.Close();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return dataTable;
        }

        public static bool IsUsersExist(int ID)
        {
            bool isExist = false;

            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string query = @"Select * from Users where UserID=@UserID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    isExist = true;
                }

            }
            catch (Exception EX)
            {
                isExist = false;
            }
            finally { connection.Close(); }


            return isExist;

        }





    }
}
