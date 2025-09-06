using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataAccsess
{
    public class clsDataAccsessCountries
    {
      

        static public bool GetByCountryId(int ID, ref string CountryName)
        {
            bool isFind = false;
            string Qury = @"select * from Countries where CountryID=@CountryID ;";
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            SqlCommand command=new SqlCommand(Qury, connection);
            command.Parameters.AddWithValue("@CountryID", ID);
            try
            {
               
                connection.Open();
               SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    

                    CountryName = (string)reader["CountryName"];
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
        static public bool GetByCountryName(ref int ID,string CountryName)
        {
            bool isFind = false;
            string Qury = @"select * from Countries where CountryName=@CountryName ;";
            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);
            SqlCommand command = new SqlCommand(Qury, connection);
            command.Parameters.AddWithValue("@CountryName", CountryName);
            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {

                    ID = (int)reader["CountryID"];
                    CountryName = (string)reader["CountryName"];
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
        static public DataTable GetAllCountry()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsConntionString.Conntion);

          string Qury= @"select * from Countries;";
            SqlCommand command= new SqlCommand(Qury, connection);

            try
            {
                connection.Open();
                SqlDataReader reader=command.ExecuteReader();
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
