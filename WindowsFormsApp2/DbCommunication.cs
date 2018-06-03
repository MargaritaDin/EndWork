using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Properties;

namespace WindowsFormsApp2
{
    static class DbCommunication
    {
        // your method to pull data from database to datatable   
        public static DataTable PullData(string login)
        {
            DataTable tabeleResult = new DataTable();
            string connString = Settings.Default.SConnectionString;
            string query = "select password from [dbo].[User] where login = @login";

            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.Add("@login", SqlDbType.VarChar, 50).Value = login;
            conn.Open();

            // create data adapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            // this will query your database and return the result to your datatable
            da.Fill(tabeleResult);
            conn.Close();
            da.Dispose();
            cmd.Dispose();

            return tabeleResult;
        }

        // your method to pull data from database to datatable   
        public static string PullDataV2(string login)
        {
            string result = string.Empty;
            string connString = Settings.Default.SConnectionString;
            string query = "select password from Users where login = @login";

            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.Add("@login", SqlDbType.VarChar, 50).Value = login;
            conn.Open();

            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                result = reader["password"].ToString();
            }
            reader.Close();

            conn.Close();
            cmd.Dispose();

            return result;
        }

        public static User GetUser(string login)
        {
            // TODO: implement
            return null;
        }

        public static void CreateUser(string login, string password)
        {
            string connString = Settings.Default.SConnectionString;
            string query = "INSERT INTO [dbo].[User] ([login], [password]) VALUES (@login, @password)";

            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.Add("@login", SqlDbType.VarChar, 50).Value = login;
            cmd.Parameters.Add("@password", SqlDbType.BigInt).Value = password.GetHashCode();
            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
            cmd.Dispose();
        }

        public static DataTable GetTutu()
        {
            return null;
        }
    }
}
