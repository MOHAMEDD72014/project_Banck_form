using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DVLDDataAccsess
{
    public class clsDataAccessApplications
    {
        static public bool GetApplicationsByID(int ID, ref int ApplicantPersonID,
            ref DateTime ApplicationDate, ref int ApplicationTypeID, ref byte ApplicationStatus,
           ref DateTime LastStatusDate, ref double PaidFees, ref int CreatedByUserID)
        {
            bool isFind = false;

            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string Qury = @"Select *From Applications where ApplicationID = @ApplicationID;";

            SqlCommand command = new SqlCommand(Qury, connection);
            command.Parameters.AddWithValue("@ApplicationID", ID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {

                    ApplicantPersonID = (int)reader["ApplicantPersonID"];
                    ApplicationDate = (DateTime)reader["ApplicationDate"];
                    ApplicationTypeID = (int)reader["ApplicationTypeID"];
                    ApplicationStatus = (byte)reader["ApplicationStatus"];
                    LastStatusDate = (DateTime)reader["LastStatusDate"];
                    PaidFees = Convert.ToDouble(reader["PaidFees"]);
                    CreatedByUserID = (int)reader["CreatedByUserID"];

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

        static public bool GetApplicationsByApplicantPersonID(ref int ID, int ApplicantPersonID,
           ref DateTime ApplicationDate, ref int ApplicationTypeID, ref byte ApplicationStatus,
          ref DateTime LastStatusDate, ref double PaidFees, ref int CreatedByUserID)
        {
            bool isFind = false;

            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string Qury = @"Select *From Applications where ApplicantPersonID = @ApplicantPersonID;";

            SqlCommand command = new SqlCommand(Qury, connection);
            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {

                    ID = (int)reader["ApplicationID"];
                    ApplicationDate = (DateTime)reader["ApplicationDate"];
                    ApplicationTypeID = (int)reader["ApplicationTypeID"];
                    ApplicationStatus = (byte)reader["ApplicationStatus"];
                    LastStatusDate = (DateTime)reader["LastStatusDate"];
                    PaidFees = Convert.ToDouble(reader["PaidFees"]);
                    CreatedByUserID = (int)reader["CreatedByUserID"];

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


        static public int AddNewApplications(int ApplicantPersonID,
            DateTime ApplicationDate, int ApplicationTypeID, byte ApplicationStatus,
            DateTime LastStatusDate, double PaidFees, int CreatedByUserID)
        {
            int rows = -1;
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string Qury = @"insert into Applications (ApplicantPersonID,
            ApplicationDate,ApplicationTypeID,ApplicationStatus,
            LastStatusDate,PaidFees,CreatedByUserID)
            VALUES(@ApplicantPersonID,
            @ApplicationDate,@ApplicationTypeID,@ApplicationStatus,
            @LastStatusDate,@PaidFees,@CreatedByUserID)
                             SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(Qury, connection);


            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
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

        static public bool UpdateApplications(int ApplicationID, int ApplicantPersonID,
            DateTime ApplicationDate, int ApplicationTypeID, byte ApplicationStatus,
            DateTime LastStatusDate, double PaidFees, int CreatedByUserID)
        {
            int rows = -1;
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string qury = @"Update  Applications  
                            set ApplicantPersonID = @ApplicantPersonID, 
                                ApplicationDate = @ApplicationDate,
                                ApplicationTypeID = @ApplicationTypeID,
                                ApplicationStatus = @ApplicationStatus,
                                LastStatusDate = @LastStatusDate,
                                PaidFees = @PaidFees,
                                CreatedByUserID = @CreatedByUserID
                                where ApplicationID = @ApplicationID;";

            SqlCommand command = new SqlCommand(qury, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

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

        static public bool DeleteApplications(int ID)
        {
            int rows = -1;
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string qury = @" Delete Applications
                          where ApplicationID=@ApplicationID";
            SqlCommand command = new SqlCommand(qury, connection);
            command.Parameters.AddWithValue("@ApplicationID", ID);
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

      
        static public DataTable GetAllApplications()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string qury = @"select *from Applications;";

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


        public static bool IsApplicationsExist(int ID)
        {
            bool isExist = false;
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string qury = @"select * from Applications 
                            where ApplicationID = @ApplicationID;";

            SqlCommand command = new SqlCommand(qury, connection);

            command.Parameters.AddWithValue("@ApplicationID", ID);
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



        public static bool IsApplicationsExist(int ApplicantPersonID, int ApplicationTypeID)
        {
            bool isExist = false;
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string qury = @"SELECT       1 
                          FROM Applications INNER JOIN
                          LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
						  WHERE ApplicantPersonID=@ApplicantPersonID AND LicenseClassID=@ApplicationTypeID";

            SqlCommand command = new SqlCommand(qury, connection);

            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
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

        static public DataTable GetDataViueAppLicatin()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string qury = @"select * from dbo.LocalDrivingLicenseApplications_View;";

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












    }
}

    








