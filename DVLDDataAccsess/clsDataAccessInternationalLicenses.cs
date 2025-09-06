using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DVLDDataAccsess
{
    public class clsDataAccessInternationalLicenses
    {
        static public bool GetInternationalLicensesByID(int ID, ref int ApplicationID,
            ref int DriverID,ref int IssuedUsingLocalLicenseID, ref DateTime IssueDate,
            ref DateTime ExpirationDate,ref bool IsActive, ref int CreatedByUserID)
        {
            bool isFind = false;

            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string Qury = @"Select *From InternationalLicenses where InternationalLicenseID = @InternationalLicenseID;";

            SqlCommand command = new SqlCommand(Qury, connection);
            command.Parameters.AddWithValue("@InternationalLicenseID", ID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IssuedUsingLocalLicenseID= (int)reader[" IssuedUsingLocalLicenseID"];
                    ApplicationID = (int)reader["ApplicationID"];
                    DriverID = (int)reader["DriverID"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];
                    IsActive = (bool)reader["IsActive"];
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

        static public bool GetInternationalLicensesByLicenseID(ref int ID, ref int ApplicationID,
           ref int DriverID, int IssuedUsingLocalLicenseID, ref DateTime IssueDate,
           ref DateTime ExpirationDate, ref bool IsActive, ref int CreatedByUserID)
        {
            bool isFind = false;

            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string Qury = @"Select *From InternationalLicenses where IssuedUsingLocalLicenseID = @IssuedUsingLocalLicenseID;";

            SqlCommand command = new SqlCommand(Qury, connection);
            command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ID = (int)reader["InternationalLicenseID"];
                    ApplicationID = (int)reader["ApplicationID"];
                    DriverID = (int)reader["DriverID"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];
                    IsActive = (bool)reader["IsActive"];
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


        static public int AddNewInternationalLicenses( int ApplicationID,
             int DriverID,  int IssuedUsingLocalLicenseID,  DateTime IssueDate,
             DateTime ExpirationDate,  bool IsActive, int CreatedByUserID)
        {
            int rows = -1;
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string Qury = @"insert into InternationalLicenses (ApplicationID,
            DriverID,IssuedUsingLocalLicenseID,IssueDate,
            ExpirationDate,IsActive,CreatedByUserID)
            VALUES(@ApplicationID,
            @DriverID,@IssuedUsingLocalLicenseID,@IssueDate,
            @ExpirationDate,@IsActive,@CreatedByUserID)
                             SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(Qury, connection);


            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
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

        static public bool UpdateInternationalLicenses(int InternationalLicenseID, 
            int ApplicationID,int DriverID,int IssuedUsingLocalLicenseID,DateTime IssueDate,
             DateTime ExpirationDate,bool IsActive,int CreatedByUserID)
        {
            int rows = -1;
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string qury = @"Update  InternationalLicenses  set 
                                ApplicationID = @ApplicationID,
                                DriverID = @DriverID,
                                IssuedUsingLocalLicenseID = @IssuedUsingLocalLicenseID,
                                IssueDate = @IssueDate,
                                ExpirationDate = @ExpirationDate,
                                IsActive = @IsActive,
                                CreatedByUserID = @CreatedByUserID
                                where InternationalLicenseID = @InternationalLicenseID;";

            SqlCommand command = new SqlCommand(qury, connection);
            command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
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

        static public bool DeleteInternationalLicenses(int ID)
        {
            int rows = -1;
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string qury = @" Delete InternationalLicenses
                          where InternationalLicenseID=@InternationalLicenseID";
            SqlCommand command = new SqlCommand(qury, connection);
            command.Parameters.AddWithValue("@InternationalLicenseID", ID);
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

        static public DataTable GetAllInternationalLicenses()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string qury = @"select *from InternationalLicenses;";

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


        static public DataTable GetAllInternationalLicensesByDriverID(int DriverID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string qury = @"SELECT InternationalLicenseID, ApplicationID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive
                           FROM  InternationalLicenses Where DriverID = @DriverID;";

            SqlCommand command = new SqlCommand(qury, connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);
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



        public static bool IsInternationalLicensesExist(int ID)
        {
            bool isExist = false;
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string qury = @"select * from InternationalLicenses 
                            where InternationalLicenseID = @InternationalLicenseID;";

            SqlCommand command = new SqlCommand(qury, connection);

            command.Parameters.AddWithValue("@InternationalLicenseID", ID);
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

        public static bool IsInternationalLicensesExistByDriverID(int DriverID)
        {
            bool isExist = false;
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string qury = @"select * from InternationalLicenses 
                            where DriverID = @DriverID;";

            SqlCommand command = new SqlCommand(qury, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);
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
