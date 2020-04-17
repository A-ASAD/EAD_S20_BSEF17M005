using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class UserDAO
    {
        private static string conString = "server=localhost; uid=root; pwd=; database=mydb";

        public static string ValidateUser(string Login, string Pass)
        {
            using(MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();
                string query = String.Format(@"select name from user where login = '{0}' and password = '{1}'",Login, Pass);
                MySqlCommand com = new MySqlCommand(query, con);
                if (com.ExecuteScalar() == null)
                    return "Error";
                return (string)com.ExecuteScalar();
            }
        }

        public static string AddUser(string Login, string Pass, string Name)
        {
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();
                string query = String.Format(@"insert into user select '{0}','{1}','{2}' where (select login from user where
                                                lower(login) = lower('{0}')) is null", Login, Pass, Name);
                MySqlCommand com = new MySqlCommand(query, con);
                if ((int)com.ExecuteNonQuery() != 0)
                    return "Success";
                return "Error";
            }
        }

        public static string AddFolder(string Name, string Parent)
        {
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();
                string query = String.Format(@"insert into folder(folderName, parentFolderId) select '{0}', {1} where ( select folderName 
                from folder where lower(folderName) = lower('{0}') and parentFolderId = {1}) is null", Name, Parent);
                MySqlCommand com = new MySqlCommand(query, con);
                if ((int)com.ExecuteNonQuery() != 0)
                    return com.LastInsertedId+"";
                return "Error";
            }
        }

        public static string GetFolders(string Parent)
        {
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();
                string query = String.Format(@"select folderId,folderName from folder where parentFolderId = {0}", Parent);
                MySqlCommand com = new MySqlCommand(query, con);
                MySqlDataReader reader = com.ExecuteReader();
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
                if (result != "")
                    return result;
                return "Error";
            }
        }
    }
}
