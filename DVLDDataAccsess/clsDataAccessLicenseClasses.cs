using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DVLDDataAccsess
{
    public class clsDataAccessLicenseClasses
    {
        static public bool GetLicenseClassesByID(int ID, ref string ClassName,
         ref string ClassDescription, ref byte MinimumAllowedAge,
         ref byte DefaultValidityLength, ref double ClassFees)
        {
            bool isFind = false;

            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string Qury = @"Select *From LicenseClasses where LicenseClassID = @LicenseClassID;";

            SqlCommand command = new SqlCommand(Qury, connection);
            command.Parameters.AddWithValue("@LicenseClassID", ID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {

                    ClassName = (string)reader["ClassName"];
                    ClassDescription = (string)reader["ClassDescription"];
                    MinimumAllowedAge = (byte)reader["MinimumAllowedAge"];
                    DefaultValidityLength = (byte)reader["DefaultValidityLength"];
                    ClassFees = Convert.ToDouble(reader["ClassFees"]);

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


        static public int AddNewLicenseClasses(string ClassName,
           string ClassDescription, byte MinimumAllowedAge,
           byte DefaultValidityLength, double ClassFees)
        {
            int rows = -1;
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string Qury = @"insert into LicenseClasses (ClassName,
           ClassDescription,MinimumAllowedAge,DefaultValidityLength,
            ClassFees)
            VALUES(@ClassName,@ClassDescription
                  ,@MinimumAllowedAge,@DefaultValidityLength,@ClassFees)
                             SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(Qury, connection);


            command.Parameters.AddWithValue("@ClassName", ClassName);
            command.Parameters.AddWithValue("@ClassDescription", ClassDescription);
            command.Parameters.AddWithValue("@MinimumAllowedAge", MinimumAllowedAge);
            command.Parameters.AddWithValue("@DefaultValidityLength", DefaultValidityLength);
            command.Parameters.AddWithValue("@ClassFees", ClassFees);

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

        static public bool UpdateLicenseClasses(int LicenseClassID, string ClassName,
           string ClassDescription, byte MinimumAllowedAge,
           byte DefaultValidityLength, double ClassFees)
        {
            int rows = -1;
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string qury = @"Update  LicenseClasses  
                            set ClassName = @ClassName, 
                                ClassDescription = @ClassDescription,
                                MinimumAllowedAge = @MinimumAllowedAge,
                                DefaultValidityLength= @DefaultValidityLength,
                                ClassFees = @ClassFees                            
                                where LicenseClassID = @LicenseClassID;";

            SqlCommand command = new SqlCommand(qury, connection);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            command.Parameters.AddWithValue("@ClassName", ClassName);
            command.Parameters.AddWithValue("@ClassDescription", ClassDescription);
            command.Parameters.AddWithValue("@MinimumAllowedAge", MinimumAllowedAge);
            command.Parameters.AddWithValue("@DefaultValidityLength", DefaultValidityLength);
            command.Parameters.AddWithValue("@ClassFees", ClassFees);

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

        static public bool DeleteLicenseClasses(int ID)
        {
            int rows = -1;
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string qury = @" Delete LicenseClasses
                          where LicenseClassID=@LicenseClassID";
            SqlCommand command = new SqlCommand(qury, connection);
            command.Parameters.AddWithValue("@LicenseClassID", ID);
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

        static public DataTable GetAllLicenseClasses()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string qury = @"select *from LicenseClasses;";

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


        public static bool IsLicenseClassesExist(int ID)
        {
            bool isExist = false;
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string qury = @"select * from LicenseClasses 
                            where LicenseClassID = @LicenseClassID;";

            SqlCommand command = new SqlCommand(qury, connection);

            command.Parameters.AddWithValue("@LicenseClassID", ID);
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
