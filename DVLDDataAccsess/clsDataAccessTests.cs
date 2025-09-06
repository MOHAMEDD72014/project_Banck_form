using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DVLDDataAccsess
{
    public class clsDataAccessTests
    {
        static public bool GetTestsByID(int ID, ref int TestAppointmentID,
           ref bool TestResult, ref string Notes, ref int CreatedByUserID)
        {
            bool isFind = false;

            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string Qury = @"Select *From Tests where TestID = @TestID;";

            SqlCommand command = new SqlCommand(Qury, connection);
            command.Parameters.AddWithValue("@TestID", ID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {

                    TestAppointmentID = (int)reader["TestAppointmentID"];
                    TestResult = (bool)reader["TestResult"];
                    if (reader["Notes"] != DBNull.Value)
                        Notes = (string)reader["Notes"];
                    else
                    {
                        Notes = "";
                    }
                       
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

        static public bool GetTestsByTestAppointmentID(ref int ID, int TestAppointmentID,
           ref bool TestResult, ref string Notes, ref int CreatedByUserID)
        {
            bool isFind = false;

            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string Qury = @"select *from Tests where Tests.TestAppointmentID=@TestAppointmentID;";

            SqlCommand command = new SqlCommand(Qury, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {

                    ID = (int)reader["TestID"];
                    TestResult = (bool)reader["TestResult"];
                    if (reader["Notes"] != DBNull.Value)
                        Notes = (string)reader["Notes"];
                    else
                    {
                        Notes = "";
                    }

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


        static public int AddNewTests(int TestAppointmentID,
            bool TestResult,string Notes,int CreatedByUserID)
        {
            int rows = -1;
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string Qury = @"insert into Tests (TestAppointmentID,
            TestResult,Notes,CreatedByUserID)
            VALUES(@TestAppointmentID,
            @TestResult,@Notes,@CreatedByUserID)
                             SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(Qury, connection);


            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestResult", TestResult);
            if (string.IsNullOrWhiteSpace(Notes))
                command.Parameters.AddWithValue("@Notes", DBNull.Value);
            else
            {
                command.Parameters.AddWithValue("@Notes", Notes);
            }
               
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

        static public bool UpdateTests(int TestID, int TestAppointmentID,
            bool TestResult, string Notes, int CreatedByUserID)
        {
            int rows = -1;
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string qury = @"Update  Tests  
                            set TestAppointmentID = @TestAppointmentID, 
                                TestResult = @TestResult,
                                Notes = @Notes,
                                CreatedByUserID = @CreatedByUserID
                                where TestID = @TestID;";

            SqlCommand command = new SqlCommand(qury, connection);

            command.Parameters.AddWithValue("@TestID", TestID);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestResult", TestResult);
            if (string.IsNullOrWhiteSpace(Notes))
                command.Parameters.AddWithValue("@Notes", DBNull.Value);
            else
            {
                command.Parameters.AddWithValue("@Notes", Notes);
            }
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

        static public bool DeleteTests(int ID)
        {
            int rows = -1;
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string qury = @" Delete Tests
                          where TestID=@TestID";
            SqlCommand command = new SqlCommand(qury, connection);
            command.Parameters.AddWithValue("@TestID", ID);
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

        static public DataTable GetAllTests()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string qury = @"select *from Tests;";

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


        public static bool IsTestsExist(int ID)
        {
            bool isExist = false;
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string qury = @"select * from Tests 
                            where TestID = @TestID;";

            SqlCommand command = new SqlCommand(qury, connection);

            command.Parameters.AddWithValue("@TestID", ID);
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
