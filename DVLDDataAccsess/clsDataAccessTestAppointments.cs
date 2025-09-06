using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DVLDDataAccsess
{
    public class clsDataAccessTestAppointments
    {
        static public bool GetTestAppointmentsByID(int ID, ref int TestTypeID,
           ref int LocalDrivingLicenseApplicationID, ref DateTime AppointmentDate,
           ref Double PaidFees, ref int CreatedByUserID, 
           ref bool IsLocked,ref int RetakeTestApplicationID)
        {
            bool isFind = false;

            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string Qury = @"Select *From TestAppointments where TestAppointmentID = @TestAppointmentID;";

            SqlCommand command = new SqlCommand(Qury, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", ID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {

                    TestTypeID = (int)reader["TestTypeID"];
                    LocalDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    AppointmentDate = (DateTime)reader["AppointmentDate"];
                    IsLocked = (bool)reader["IsLocked"];
                    PaidFees =Convert.ToDouble(reader["PaidFees"]);
                    if (reader["RetakeTestApplicationID"] != DBNull.Value)
                        RetakeTestApplicationID = (int)reader["RetakeTestApplicationID"];
                    else
                    {
                        RetakeTestApplicationID = -1;
                    }

                   
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

        static public bool GetTestAppointmentsByLocalDrivingLicenseApplicationID(ref int ID, ref int TestTypeID,
           int LocalDrivingLicenseApplicationID, ref DateTime AppointmentDate,
           ref Double PaidFees, ref int CreatedByUserID,
           ref bool IsLocked, ref int RetakeTestApplicationID)
        {
            bool isFind = false;

            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string Qury = @"Select *From TestAppointments where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;";

            SqlCommand command = new SqlCommand(Qury, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ID = (int)reader["TestAppointmentID"];
                    TestTypeID = (int)reader["TestTypeID"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    AppointmentDate = (DateTime)reader["AppointmentDate"];
                    IsLocked = (bool)reader["IsLocked"];
                    PaidFees = Convert.ToDouble(reader["PaidFees"]);
                    if (reader["RetakeTestApplicationID"] != DBNull.Value)
                        RetakeTestApplicationID = (int)reader["RetakeTestApplicationID"];
                    else
                    {
                        RetakeTestApplicationID = -1;
                    }


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


        static public int AddNewTestAppointments(int TestTypeID,
             int LocalDrivingLicenseApplicationID,DateTime AppointmentDate,
             Double PaidFees,int CreatedByUserID,
             bool IsLocked,int RetakeTestApplicationID)
        {
            int rows = -1;
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string Qury = @"insert into TestAppointments (TestTypeID,
            LocalDrivingLicenseApplicationID,AppointmentDate,PaidFees,
            CreatedByUserID,IsLocked,RetakeTestApplicationID)
            VALUES(@TestTypeID,@LocalDrivingLicenseApplicationID
                  ,@AppointmentDate,@PaidFees,@CreatedByUserID,@IsLocked,@RetakeTestApplicationID)
                             SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(Qury, connection);


            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@IsLocked", IsLocked);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            if (RetakeTestApplicationID <=0)
                command.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);
            else
            {
                command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);
            }



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

        static public bool UpdateTestAppointments(int TestAppointmentID, int TestTypeID,
             int LocalDrivingLicenseApplicationID, DateTime AppointmentDate,
             Double PaidFees, int CreatedByUserID,
             bool IsLocked, int RetakeTestApplicationID)
        {
            int rows = -1;
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string qury = @"Update  TestAppointments  
                            set TestTypeID = @TestTypeID, 
                                LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID,
                                AppointmentDate = @AppointmentDate,
                                PaidFees = @PaidFees,
                                CreatedByUserID = @CreatedByUserID,
                                IsLocked = @IsLocked,
                                RetakeTestApplicationID = @RetakeTestApplicationID
                                where TestAppointmentID = @TestAppointmentID;";

            SqlCommand command = new SqlCommand(qury, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@IsLocked", IsLocked);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            if (RetakeTestApplicationID <=0)
                command.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);
            else
            {
                command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);
            }

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

        static public bool DeleteTestAppointments(int ID)
        {
            int rows = -1;
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string qury = @" Delete TestAppointments
                          where TestAppointmentID=@TestAppointmentID";
            SqlCommand command = new SqlCommand(qury, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", ID);
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
        static public DataTable GetAllTestAppointments()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string qury = @"select *from TestAppointments;";

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
        static public DataTable GetAllTestAppointments(int LocalID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string qury = @"select *from TestAppointments Where LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID;";

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


        static public DataTable GetAllTestAppointments(int LocalID, int TestTypeID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string qury = @"select *from TestAppointments Where LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID and TestAppointments.TestTypeID=@TestTypeID;";

            SqlCommand command = new SqlCommand(qury, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
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


        public static bool IsTestAppointmentsExist(int ID)
        {
            bool isExist = false;
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string qury = @"select * from TestAppointments 
                            where TestAppointmentID = @TestAppointmentID;";

            SqlCommand command = new SqlCommand(qury, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", ID);
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
