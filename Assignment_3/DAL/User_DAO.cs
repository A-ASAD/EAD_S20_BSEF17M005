
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class UserDAO
    {
        private static string conString = @"Data Source=localhost\SQLEXPRESS; Initial Catalog=mydb;
                        User Id=sa; Password=asad226646";

        public static string ValidateUser(string Login, string Pass)
        {
            using(SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                string query = String.Format(@"select name from dbo.[user] where login = '{0}' and password = '{1}'",Login, Pass);
                SqlCommand com = new SqlCommand(query, con);
                if (com.ExecuteScalar() == null)
                    return "Error";
                return (string)com.ExecuteScalar();
            }
        }

        public static string AddUser(string Login, string Pass, string Name)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                string query = String.Format(@"insert into dbo.[user] select '{0}','{1}','{2}' where (select login from dbo.[user] where
                                                lower(login) = lower('{0}')) is null", Login, Pass, Name);
                SqlCommand com = new SqlCommand(query, con);
                if ((int)com.ExecuteNonQuery() != 0)
                    return "Success";
                return "Error";
            }
        }

        public static string AddFolder(string Name, string Parent)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                string query = String.Format(@"insert into dbo.[folder](folderName, parentFolderId) select '{0}', {1} where ( select folderName 
                from dbo.[folder] where lower(folderName) = lower('{0}') and parentFolderId = {1}) is null", Name, Parent);
                SqlCommand com = new SqlCommand(query, con);
                if ((int)com.ExecuteNonQuery() != 0)
                {
                    com = new SqlCommand("select SCOPE_IDENTITY()", con);
                    return ((Decimal)com.ExecuteScalar()).ToString();
                }
                return "Error";
            }
        }

        public static string GetFolders(string Parent)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                string query = String.Format(@"select folderId,folderName from dbo.[folder] where parentFolderId = {0}", Parent);
                SqlCommand com = new SqlCommand(query, con);
                SqlDataReader reader = com.ExecuteReader();
                string result="";
                if (reader.Read())
                {
                    result += "[["+reader.GetInt32(0)+",";
                    result += "\""+reader.GetString(1)+"\"]";
                    while (reader.Read())
                    {
                        result += ",["+reader.GetInt32(0) + ",";
                        result += "\""+reader.GetString(1) + "\"]";
                    }
                    result += "]";
                }
                reader.Close();
                if (result != "")
                    return result;
                return "Error";
            }
        }
    }
}
