using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace DVLDDataAccsess
{
    public class clsDataAccessLocalDrivingLicenseApplications
    {
        static public bool GetLocalDrivingLicenseApplicationsByID(int ID, ref int ApplicationID,
         ref int LicenseClassID)
        {
            bool isFind = false;

            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string Qury = @"Select *From LocalDrivingLicenseApplications where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;";

            SqlCommand command = new SqlCommand(Qury, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", ID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {

                    ApplicationID = (int)reader["ApplicationID"];
                    LicenseClassID = (int)reader["LicenseClassID"];
                   
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


        static public bool GetLocalDrivingLicenseApplicationsByApplicationID(ref int ID,  int ApplicationID,
        ref int LicenseClassID)
        {
            bool isFind = false;

            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string Qury = @"Select *From LocalDrivingLicenseApplications where ApplicationID = @ApplicationID;";

            SqlCommand command = new SqlCommand(Qury, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {

                    ID = (int)reader["LocalDrivingLicenseApplicationID"];
                    LicenseClassID = (int)reader["LicenseClassID"];

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

        static public int AddNewLocalDrivingLicenseApplications(int ApplicationID,
           int LicenseClassID)
        {
            int rows = -1;
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string Qury = @"insert into LocalDrivingLicenseApplications (ApplicationID, LicenseClassID)
                            values (@ApplicationID, @LicenseClassID);";

            SqlCommand command = new SqlCommand(Qury, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();
                rows = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                rows = -1;
            }
            finally
            {
                connection.Close();
            }
            return rows;
        }

        static public bool UpdateLocalDrivingLicenseApplications(int LocalDrivingLicenseApplicationID, 
            int ApplicationID, int LicenseClassID)
        {
            int rows = -1;
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string qury = @"Update  LocalDrivingLicenseApplications  
                            set ApplicationID = @ApplicationID, 
                                LicenseClassID = @LicenseClassID                           
                                where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;";

            SqlCommand command = new SqlCommand(qury, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            

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

        static public bool DeleteLocalDrivingLicenseApplications(int ID)
        {
            int rows = -1;
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string qury = @" Delete LocalDrivingLicenseApplications
                          where LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID";
            SqlCommand command = new SqlCommand(qury, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", ID);
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

        static public DataTable GetAllLocalDrivingLicenseApplications()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string qury = @"select *from LocalDrivingLicenseApplications;";

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


        public static bool IsLocalDrivingLicenseApplicationsExist(int ID)
        {
            bool isExist = false;
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string qury = @"select * from LocalDrivingLicenseApplications 
                            where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;";

            SqlCommand command = new SqlCommand(qury, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", ID);
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
