using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DVLDDataAccsess
{
    public class clsDataAccessLicenses
    {
        static public bool GetLicensesByID(int ID, ref int ApplicationID, ref int DriverID,
            ref int LicenseClass, ref DateTime IssueDate, ref DateTime ExpirationDate,
            ref string Notes, ref double PaidFees, 
            ref bool IsActive,ref byte IssueReason,ref int CreatedByUserID)
        {
            bool isFind = false;

            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string Qury = @"Select *From Licenses where LicenseID = @LicenseID;";

            SqlCommand command = new SqlCommand(Qury, connection);
            command.Parameters.AddWithValue("@LicenseID", ID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {

                    ApplicationID = (int)reader["ApplicationID"];
                    DriverID = (int)reader["DriverID"];
                    LicenseClass = (int)reader["LicenseClass"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];
                    if (reader["Notes"] != DBNull.Value)
                    {
                        Notes = (string)reader["Notes"];
                    }
                    else
                    {
                        Notes = "";
                    }
                       
                    PaidFees =Convert.ToDouble(reader["PaidFees"]);
                    IsActive = (bool)reader["IsActive"];
                    IssueReason = (byte)reader["IssueReason"];
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

        static public bool GetLicensesByApplicationID(ref int ID,int ApplicationID, ref int DriverID,
           ref int LicenseClass, ref DateTime IssueDate, ref DateTime ExpirationDate,
           ref string Notes, ref double PaidFees,
           ref bool IsActive, ref byte IssueReason, ref int CreatedByUserID)
        {
            bool isFind = false;

            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string Qury = @"Select *From Licenses where ApplicationID = @ApplicationID;";

            SqlCommand command = new SqlCommand(Qury, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {

                    ID = (int)reader["LicenseID"];
                    DriverID = (int)reader["DriverID"];
                    LicenseClass = (int)reader["LicenseClass"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];
                    if (reader["Notes"] != DBNull.Value)
                    {
                        Notes = (string)reader["Notes"];
                    }
                    else
                    {
                        Notes = "";
                    }

                    PaidFees = Convert.ToDouble(reader["PaidFees"]);
                    IsActive = (bool)reader["IsActive"];
                    IssueReason = (byte)reader["IssueReason"];
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
        static public int AddNewLicenses(int ApplicationID,int DriverID,
              int LicenseClass,DateTime IssueDate,DateTime ExpirationDate,
              string Notes,double PaidFees,
              bool IsActive,byte IssueReason, int CreatedByUserID)
        {
            int rows = -1;
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string Qury = @"insert into Licenses (ApplicationID,
            DriverID,LicenseClass,IssueDate,
            ExpirationDate,Notes,PaidFees,IsActive,IssueReason,CreatedByUserID)
            VALUES(@ApplicationID,
            @DriverID,@LicenseClass,@IssueDate,
            @ExpirationDate,@Notes,@PaidFees,@IsActive,@IssueReason,@CreatedByUserID)
                             SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(Qury, connection);


            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            if (!string.IsNullOrWhiteSpace(Notes))
            {
                command.Parameters.AddWithValue("@Notes", Notes);
            }
            else
            {
                command.Parameters.AddWithValue("@Notes",DBNull.Value);
            }
           
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@IssueReason", IssueReason);
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

        static public bool UpdateLicenses(int LicenseID, int ApplicationID, int DriverID,
              int LicenseClass, DateTime IssueDate, DateTime ExpirationDate,
              string Notes, double PaidFees,
              bool IsActive, byte IssueReason, int CreatedByUserID)
        {
            int rows = -1;
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string qury = @"Update  Licenses  set 
                                ApplicationID = @ApplicationID,
                                DriverID = @DriverID,
                                LicenseClass = @LicenseClass,
                                IssueDate = @IssueDate,
                                ExpirationDate = @ExpirationDate,
                                Notes = @Notes,
                                PaidFees = @PaidFees,
                                IsActive = @IsActive,
                                IssueReason = @IssueReason,
                                CreatedByUserID = @CreatedByUserID
                                where LicenseID = @LicenseID;";

            SqlCommand command = new SqlCommand(qury, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            if (!string.IsNullOrWhiteSpace(Notes))
            {
                command.Parameters.AddWithValue("@Notes", Notes);
            }
            else
            {
                command.Parameters.AddWithValue("@Notes", DBNull.Value);
            }

            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@IssueReason", IssueReason);
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

        static public bool DeleteLicenses(int ID)
        {
            int rows = -1;
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string qury = @" Delete Licenses
                          where LicenseID=@LicenseID";
            SqlCommand command = new SqlCommand(qury, connection);
            command.Parameters.AddWithValue("@LicenseID", ID);
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

        static public DataTable GetAllLicenses()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string qury = @"select *from Licenses  ;";

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


        static public DataTable GetAllLicensesByLocalID(int LocalID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string qury = @"select *from dbo.HistoryDriversLicenses
                           Where LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID  ;";

            SqlCommand command = new SqlCommand(qury, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalID);

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


        public static bool IsLicensesExist(int ID)
        {
            bool isExist = false;
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string qury = @"select * from Licenses 
                            where LicenseID = @LicenseID;";

            SqlCommand command = new SqlCommand(qury, connection);

            command.Parameters.AddWithValue("@LicenseID", ID);
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
