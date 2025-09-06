using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DVLDDataAccsess
{
    public class clsDataAccessDrivers
    {
        static public bool GetDriversByID(int ID, ref int PersonID,
         ref int CreatedByUserID, ref DateTime CreatedDate)
        {
            bool isFind = false;

            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string Qury = @"Select *From Drivers where DriverID = @DriverID;";

            SqlCommand command = new SqlCommand(Qury, connection);
            command.Parameters.AddWithValue("@DriverID", ID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {

                    PersonID = (int)reader["PersonID"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    CreatedDate = (DateTime)reader["CreatedDate"];

                    isFind = true;
                }
            }
            catch (Exception ex)
            {
                isFind = false;
            }
            finally
            {
                connection.Close();
            }

            return isFind;

        }




        static public int AddNewDrivers(int PersonID,
           int CreatedByUserID,DateTime CreatedDate)
        {
            int rows = -1;
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string Qury = @"insert into Drivers (PersonID,CreatedByUserID,CreatedDate)
                            values (@PersonID,@CreatedByUserID,@CreatedDate) 
                                         SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(Qury, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@CreatedDate", CreatedDate);

            try
            {
                connection.Open();
                object opj = command.ExecuteScalar();
                if (opj != null && int.TryParse(opj.ToString(), out int reslt))
                {
                    rows = reslt;
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

        static public bool UpdateDrivers(int DriverID, int PersonID,
           int CreatedByUserID, DateTime CreatedDate)
        {
            int rows = -1;
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string qury = @"Update  Drivers  
                            set PersonID = @PersonID, 
                                CreatedByUserID = @CreatedByUserID,
                                CreatedDate = @CreatedDate
                                where DriverID = @DriverID;";

            SqlCommand command = new SqlCommand(qury, connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@CreatedDate", CreatedDate);

            try
            {
                connection.Open();
                rows = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {



            }
            finally
            {
                connection.Close();
            }



            return (rows > 0);
        }

        static public bool DeleteDrivers(int ID)
        {
            int rows = -1;
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string qury = @" Delete Drivers
                          where DriverID=@DriverID";
            SqlCommand command = new SqlCommand(qury, connection);
            command.Parameters.AddWithValue("@DriverID", ID);
            try
            {
                connection.Open();
                rows = command.ExecuteNonQuery();

            }
            catch (Exception EX)
            {

            }
            finally
            {
                connection.Close();
            }
            return (rows > 0);
        }

        static public DataTable GetAllDrivers()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string qury = @"select *from Drivers;";

            SqlCommand command = new SqlCommand(qury, connection);
            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {

                    dt.Load(reader);
                }


            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        static public DataTable GetAllDriversVeiw()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string qury = @"select *from Drivers_View ;";

            SqlCommand command = new SqlCommand(qury, connection);
            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {

                    dt.Load(reader);
                }


            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return dt;
        }


        public static bool IsDriversExist(int ID)
        {
            bool isExist = false;
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string qury = @"select * from Drivers 
                            where DriverID = @DriverID;";

            SqlCommand command = new SqlCommand(qury, connection);

            command.Parameters.AddWithValue("@DriverID", ID);
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
            finally
            {
                connection.Close();
            }
            return isExist;
        }



    }
}
