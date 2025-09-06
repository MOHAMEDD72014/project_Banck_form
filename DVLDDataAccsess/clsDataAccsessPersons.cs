using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataAccsess
{
    public class clsDataAccsessPersons
    {
        public static bool GetPersonsById(ref int PersonID,ref string NationalNo, ref string FirstName,
            ref string SecondName,ref string ThirdName,ref string LastName, ref string Email,
            ref string Phone, ref DateTime DateOfBirth, ref byte Gendor, ref string Address,
            ref int NationalityCountryID,ref string ImagePath)
        {
            bool IsFind = false;

            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string Query = @"select *from People where PersonID=@PersonID";
            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFind = true;
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    ThirdName = (string)reader["ThirdName"];
                    LastName = (string)reader["LastName"];
                    if (reader["Email"] != DBNull.Value)
                    {
                        Email = (string)reader["Email"];
                    }
                    else
                    {
                        Email = "";
                    }
                   
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gendor = Convert.ToByte(reader["Gendor"]);
                    NationalNo = (string)reader["NationalNo"];
                    NationalityCountryID = (int)reader["NationalityCountryID"];
                    if(reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = "";
                    }
                   
                }

                reader.Close();

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

        public static bool GetPersonsByNationalNo(ref int PersonID, ref string NationalNo, ref string FirstName,
           ref string SecondName, ref string ThirdName, ref string LastName, ref string Email,
           ref string Phone, ref DateTime DateOfBirth, ref byte Gendor, ref string Address,
           ref int NationalityCountryID, ref string ImagePath)
        {
            bool IsFind = false;

            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string Query = @"select *from People where NationalNo=@NationalNo";
            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFind = true;
                    PersonID = (int)reader["PersonID"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    ThirdName = (string)reader["ThirdName"];
                    LastName = (string)reader["LastName"];
                    Email = (string)reader["Email"];
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gendor = Convert.ToByte(reader["Gendor"]);
                    NationalityCountryID = (int)reader["NationalityCountryID"];
                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = "";
                    }

                }

                reader.Close();

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
        public static int AddNewPersons(string NationalNo,  string FirstName,
             string SecondName,  string ThirdName,  string LastName,  string Email,
             string Phone, DateTime DateOfBirth,  byte Gendor,  string Address,
             int NationalityCountryID,  string ImagePath)
        {
            int rows = 0;
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string Query = @"insert into People (NationalNo,FirstName,
              SecondName,ThirdName,LastName,Email,
              Phone,DateOfBirth,Gendor,Address,
             NationalityCountryID,ImagePath)
             VALUES(@NationalNo,@FirstName,
              @SecondName,@ThirdName,@LastName,@Email,
              @Phone,@DateOfBirth,@Gendor,@Address,
             @NationalityCountryID,@ImagePath);
             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@NationalNo",NationalNo);
            command.Parameters.AddWithValue("@FirstName",FirstName);
            command.Parameters.AddWithValue("@SecondName",SecondName);
            command.Parameters.AddWithValue("@ThirdName",ThirdName);
            command.Parameters.AddWithValue("@LastName",LastName);
            command.Parameters.AddWithValue("@Email",Email);
            command.Parameters.AddWithValue("@Phone",Phone);
            command.Parameters.AddWithValue("@Address",Address);
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            command.Parameters.AddWithValue("@DateOfBirth",DateOfBirth);
            command.Parameters.AddWithValue("@Gendor",Gendor);
            if(!string.IsNullOrEmpty(ImagePath) && ImagePath != null)
            {
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
            {
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            }
            

            try
            {
                connection.Open();
                object obj = command.ExecuteScalar();
                if (obj != null && int.TryParse(obj.ToString(), out int NumberID))
                {
                    rows = NumberID;
                }
                else
                {
                    rows = -1;
                }


            }
            catch (Exception ex)
            {


            }
            finally
            {
                connection.Close();
            }

            return rows;
        }


        public static bool UpdatePersons(int PersonID, string NationalNo, string FirstName,
             string SecondName, string ThirdName, string LastName, string Email,
             string Phone, DateTime DateOfBirth, byte Gendor, string Address,
             int NationalityCountryID, string ImagePath)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);

            string query = @"Update People set 
             NationalNo=@NationalNo,
             FirstName=@FirstName,
             SecondName=@SecondName,
             ThirdName=@ThirdName,
             LastName=@LastName,
             Email=@Email,
             Phone=@Phone,
             Address=@Address,
             NationalityCountryID=@NationalityCountryID,
             DateOfBirth=@DateOfBirth,
             Gendor=@Gendor,
             ImagePath=@ImagePath
             where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            if (!string.IsNullOrEmpty(ImagePath) && ImagePath != null)
            {
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
            {
                command.Parameters.AddWithValue("@ImagePath",System.DBNull.Value);
            }
           


            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();


            }
            catch (Exception ex)
            {


            }
            finally
            {
                connection.Close();
            }
            return (rowsAffected > 0);
        }

        public static bool DeletePersons(int ID)
        {
            int RowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string qury = @" Delete People
                          where PersonID=@PersonID";
            SqlCommand command = new SqlCommand(qury, connection);

            command.Parameters.AddWithValue("@PersonID", ID);
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

        public static DataTable GetAllDataPersons()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string query = @"
                        select People.PersonID,People.NationalNo,People.FirstName
                        ,People.SecondName,People.ThirdName,People.LastName,
                         People.DateOfBirth,People.Gendor,CASE
                         WHEN People.Gendor=0 THEN'Male'
                         else 'Femle'
                         END as GendorCaption,People.Address,
                         People.Phone,People.Email,
                         People.NationalityCountryID,Countries.CountryName,
                         People.ImagePath from People INNER JOIN
                         Countries ON People.NationalityCountryID=Countries.CountryID 
                         Order BY People.FirstName;";
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

        public static bool IsPersonsExist(int ID)
        {
            bool isExist = false;

            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string query = @"Select * from People where PersonID=@PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", ID);

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

        public static bool IsPersonsExist(string NationalNo)
        {
            bool isExist = false;

            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string query = @"Select * from People where NationalNo=@NationalNo";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);

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
