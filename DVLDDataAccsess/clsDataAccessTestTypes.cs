using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DVLDDataAccsess
{
    public class clsDataAccessTestTypes
    {

        static public bool GetTestTypesByID(int ID, ref string TestTypeTitle,
           ref string TestTypeDescription, ref Double TestTypeFees)
        {
            bool isFind = false;

            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string Qury = @"Select *From TestTypes where TestTypeID = @TestTypeID;";

            SqlCommand command = new SqlCommand(Qury, connection);
            command.Parameters.AddWithValue("@TestTypeID", ID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {

                    TestTypeTitle = (string)reader["TestTypeTitle"];
                    TestTypeDescription = (string)reader["TestTypeDescription"];
                    TestTypeFees =Convert.ToDouble(reader["TestTypeFees"]);
                   

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


        static public int AddNewTestTypes(string TestTypeTitle,
            string TestTypeDescription, Double TestTypeFees)
        {
            int rows = -1;
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string Qury = @"insert into TestTypes (TestTypeTitle,
            TestTypeDescription,TestTypeFees)
            VALUES(@TestTypeTitle,
            @TestTypeDescription,@TestTypeFees)
                             SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(Qury, connection);


            command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
            command.Parameters.AddWithValue("@TestTypeDescription", TestTypeDescription);
            command.Parameters.AddWithValue("@TestTypeFees", TestTypeFees);
         
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

        static public bool UpdateTestTypes(int TestTypeID, string TestTypeTitle,
            string TestTypeDescription, Double TestTypeFees)
        {
            int rows = -1;
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string qury = @"Update TestTypes  
                            set TestTypeTitle = @TestTypeTitle, 
                                TestTypeDescription = @TestTypeDescription,
                                TestTypeFees = @TestTypeFees
                                where TestTypeID = @TestTypeID;";

            SqlCommand command = new SqlCommand(qury, connection);
            command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
            command.Parameters.AddWithValue("@TestTypeDescription", TestTypeDescription);
            command.Parameters.AddWithValue("@TestTypeFees", TestTypeFees);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            

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

        static public bool DeleteTestTypes(int ID)
        {
            int rows = -1;
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string qury = @" Delete TestTypes
                          where TestTypeID=@TestTypeID";
            SqlCommand command = new SqlCommand(qury, connection);
            command.Parameters.AddWithValue("@TestTypeID", ID);
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

        static public DataTable GetAllTestTypes()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string qury = @"select *from TestTypes;";

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


        public static bool IsTestTypesExist(int ID)
        {
            bool isExist = false;
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string qury = @"select * from TestTypes 
                            where TestTypeID = @TestTypeID;";

            SqlCommand command = new SqlCommand(qury, connection);

            command.Parameters.AddWithValue("@TestTypeID", ID);
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
