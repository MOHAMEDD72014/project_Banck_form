using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DVLDDataAccsess
{
    public class clsDataAccessApplicationType
    {
        static public bool GetApplicationTypeByID(int ID, ref string ApplicationTypeTitle, ref double ApplicationFees)
        {
            bool isFind = false;

            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string Qury = @"Select *From ApplicationTypes where ApplicationTypeID= @ApplicationTypeID;";

            SqlCommand command = new SqlCommand(Qury, connection);
            command.Parameters.AddWithValue("@ApplicationTypeID", ID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {

                    ApplicationTypeTitle = (string)reader["ApplicationTypeTitle"];
                    ApplicationFees = Convert.ToDouble(reader["ApplicationFees"]);
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


        static public int AddNewApplicationTypes( string ApplicationTypeTitle, double ApplicationFees)
        {
            int rows = -1;
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string Qury = @"insert into ApplicationTypes (ApplicationTypeTitle,ApplicationFees)
                                    VALUES(@ApplicationTypeTitle,@ApplicationFees)
                                          SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(Qury, connection);

           
            command.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);
            command.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);
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

        static public bool UpdateApplicationTypes(int ApplicationTypeID, string ApplicationTypeTitle, double ApplicationFees)
        {
            int rows = -1;
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string qury= @"Update  ApplicationTypes  
                            set ApplicationTypeTitle = @ApplicationTypeTitle, 
                               ApplicationFees = @ApplicationFees 
                                where ApplicationTypeID = @ApplicationTypeID;";

            SqlCommand command = new SqlCommand(qury, connection);

            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);
            command.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);

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

        static public bool DeleteApplicationTypes(int ID)
        {
            int rows = -1;
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string qury = @" Delete ApplicationTypes
                          where ApplicationTypeID=@ApplicationTypeID";
            SqlCommand command = new SqlCommand(qury,connection);
            command.Parameters.AddWithValue("@ApplicationTypeID", ID);
            try
            {
                connection.Open();
                rows= command.ExecuteNonQuery();

            }catch(Exception EX)
            {

            }
            finally
            {
                connection.Close();
            }
            return (rows > 0);
        }

        static public DataTable GetAllApplicationTypes()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string qury = @"select *from ApplicationTypes;";

            SqlCommand command = new SqlCommand(qury, connection);
            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {

                    dt.Load(reader);
                }


            }catch(Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return dt;
        }


        public static bool IsApplicationTypesExist(int ID)
        {
            bool isExist = false;
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string qury = @"select * from ApplicationTypes 
                            where ApplicationTypeID = @ApplicationTypeID;";

            SqlCommand command = new SqlCommand(qury, connection);

            command.Parameters.AddWithValue("@ApplicationTypeID", ID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    isExist = true;

                }
            }catch(Exception EX)
            {
                isExist=false;
            }
            finally
            {
                connection.Close();
            }
            return isExist;
        }

    }

}
