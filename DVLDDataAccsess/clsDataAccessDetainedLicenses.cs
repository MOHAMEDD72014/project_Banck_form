using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;
namespace DVLDDataAccsess
{
    public class clsDataAccessDetainedLicenses
    {
        static public bool GetDetainedLicensesByID(int ID,ref int LicenseID, ref int CreatedByUserID,
            ref DateTime DetainDate, ref bool IsReleased,ref DateTime ReleaseDate, 
            ref double FineFees,ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            bool isFind = false;

            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string Qury = @"Select *From DetainedLicenses where DetainID = @DetainID;";

            SqlCommand command = new SqlCommand(Qury, connection);
            command.Parameters.AddWithValue("@DetainID", ID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {

                    LicenseID = (int)reader["LicenseID"];
                    DetainDate = (DateTime)reader["DetainDate"];
                    IsReleased = (bool)reader["IsReleased"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    if (reader["ReleaseDate"] != DBNull.Value)
                    {
                        ReleaseDate = (DateTime)reader["ReleaseDate"];
                    }
                    else
                    {
                        ReleaseDate = DateTime.Now;
                    }
                    
                    FineFees = Convert.ToDouble(reader["FineFees"]);

                    if (reader["ReleasedByUserID"] != DBNull.Value)
                    {
                        ReleasedByUserID = (int)reader["ReleasedByUserID"];
                    }
                    else
                    {
                        ReleasedByUserID = -1;
                    }

                    if (reader["ReleaseApplicationID"] != DBNull.Value)
                    {
                        ReleaseApplicationID = (int)reader["ReleaseApplicationID"];
                    }
                    else
                    {
                        ReleaseApplicationID = -1;
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


        static public int AddNewDetainedLicenses(int LicenseID,int CreatedByUserID,
              DateTime DetainDate,bool IsReleased, DateTime ReleaseDate,
              double FineFees,int ReleasedByUserID,int ReleaseApplicationID)
        {
            int rows = -1;
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string Qury = @"insert into DetainedLicenses (LicenseID,
            CreatedByUserID,DetainDate,IsReleased,
            ReleaseDate,FineFees,ReleasedByUserID,ReleaseApplicationID)
            VALUES(@LicenseID,
            @CreatedByUserID,@DetainDate,@IsReleased,
            @ReleaseDate,@FineFees,@ReleasedByUserID,@ReleaseApplicationID)
                             SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(Qury, connection);


            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@DetainDate", DetainDate);
            command.Parameters.AddWithValue("@IsReleased", IsReleased);
            command.Parameters.AddWithValue("@FineFees", FineFees);
            if(ReleaseDate != DateTime.MinValue)
            {
                command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
            }
            else
            {
                command.Parameters.AddWithValue("@ReleaseDate", DBNull.Value);
            }
            if(ReleasedByUserID > 0)
            {
                command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            }
            else
            {
                command.Parameters.AddWithValue("@ReleasedByUserID", DBNull.Value);
            }
          if(ReleaseApplicationID > 0)
            {
                command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
            }
            else
            {
                command.Parameters.AddWithValue("@ReleaseApplicationID", DBNull.Value);
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

        static public bool UpdateDetainedLicenses(int DetainID, int LicenseID, int CreatedByUserID,
              DateTime DetainDate, bool IsReleased, DateTime ReleaseDate,
              double FineFees, int ReleasedByUserID, int ReleaseApplicationID)
        {
            int rows = -1;
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string qury = @"Update  DetainedLicenses  
                            set LicenseID = @LicenseID, 
                                CreatedByUserID = @CreatedByUserID,
                                DetainDate = @DetainDate,
                                IsReleased = @IsReleased,
                                ReleaseDate = @ReleaseDate,
                                FineFees = @FineFees,
                                ReleasedByUserID = @ReleasedByUserID,
                                ReleaseApplicationID = @ReleaseApplicationID
                                where DetainID = @DetainID;";

            SqlCommand command = new SqlCommand(qury, connection);
            command.Parameters.AddWithValue("@DetainID", DetainID);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@DetainDate", DetainDate);
            command.Parameters.AddWithValue("@IsReleased", IsReleased);
            command.Parameters.AddWithValue("@FineFees", FineFees);
            if (ReleaseDate != DateTime.MinValue)
            {
                command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
            }
            else
            {
                command.Parameters.AddWithValue("@ReleaseDate", DBNull.Value);
            }
            if (ReleasedByUserID > 0)
            {
                command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            }
            else
            {
                command.Parameters.AddWithValue("@ReleasedByUserID", DBNull.Value);
            }
            if (ReleaseApplicationID > 0)
            {
                command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
            }
            else
            {
                command.Parameters.AddWithValue("@ReleaseApplicationID", DBNull.Value);
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

        static public bool DeleteDetainedLicenses(int ID)
        {
            int rows = -1;
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string qury = @" Delete DetainedLicenses
                          where DetainID=@DetainID";
            SqlCommand command = new SqlCommand(qury, connection);
            command.Parameters.AddWithValue("@DetainID", ID);
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

        static public DataTable GetAllDetainedLicenses()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string qury = @"select *from DetainedLicenses;";

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


        public static bool IsDetainedLicensesExist(int ID)
        {
            bool isExist = false;
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            string qury = @"select * from DetainedLicenses 
                            where DetainID = @DetainID;";

            SqlCommand command = new SqlCommand(qury, connection);

            command.Parameters.AddWithValue("@DetainID", ID);
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
