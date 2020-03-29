using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMS_DAL
{
    public static class UserDAO
    {
        private static string conString = @"Data Source=localhost\SQLEXPRESS; Initial Catalog=Assignment4;
                        User Id=sa; Password=asad226646";
       
        public static bool CreateUser(String Name, String Login, String Pass, String Mail,char Gender,
            String Address, int Age, String NIC, string Dob, bool isCricket, bool isHockey, bool isChess, string imagePath)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                String Query = String.Format(@"insert into dbo.Users(name, login, email, password, gender,
                        address, age, nic, dob, isCricket, hockey, chess, imagename, CreatedOn)
                        select '{0}','{1}','{2}','{3}','{4}','{5}',{6},'{7}','{8}','{9}','{10}','{11}','{12}',GETDATE()
                        where(select login from dbo.Users where Login = '{1}' or Email = '{2}') is null",Name,Login,
                        Mail,Pass,Gender,Address,Age,NIC,Dob,isCricket,isHockey,isChess, imagePath);
                SqlCommand com = new SqlCommand(Query, con);
                return com.ExecuteNonQuery()> 0;
            }
        }
        public static DataTable GetUser(String Login)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                String Query = String.Format(@"select * from dbo.Users where Login = '{0}'",Login);
                SqlCommand com = new SqlCommand(Query, con);
                SqlDataReader reader = com.ExecuteReader();
                DataTable user = new DataTable();
                user.Load(reader);
                reader.Close();
                return user;
            }
        }

        public static bool UpdateUser(String Name, String Login, String prevLogin, String Pass, String Mail, char Gender,
            String Address, int Age, String NIC, string Dob, bool isCricket, bool isHockey, bool isChess, string imagePath, bool isLgnChanged)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                String Query= String.Format(@"Update dbo.Users set Name='{0}',Login='{1}',Email ='{2}',Password='{3}',Gender ='{4}',
                        Address ='{5}',Age = {6},NIC='{7}',DOB='{8}',IsCricket='{9}',Hockey='{10}',Chess='{11}',ImageName='{12}'
                        where Login  = '{1}'", Name, Login, Mail, Pass, Gender, Address, Age, NIC, Dob,
                        isCricket, isHockey, isChess, imagePath);
                if (isLgnChanged)  // if login or email changed
                    Query = String.Format(@"Update dbo.Users set Name='{0}',Login='{1}',Email ='{2}',Password='{3}',Gender ='{4}',
                        Address ='{5}',Age = {6},NIC='{7}',DOB='{8}',IsCricket='{9}',Hockey='{10}',Chess='{11}',ImageName='{12}'
                        where(select COUNT(*) from Users where Login = '{1}' or Email = '{2}') = 0 and Login = '{13}'", Name, Login,
                        Mail, Pass, Gender, Address, Age, NIC, Dob, isCricket, isHockey, isChess, imagePath, prevLogin);

                SqlCommand com = new SqlCommand(Query, con);
                return com.ExecuteNonQuery() > 0;
            }
        }
        public static String ValidateUser(String Login, String Pass)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                String Query = String.Format(@"select * from dbo.Users where Login = '{0}' 
                                and Password = '{1}'", Login, Pass);
                SqlCommand com = new SqlCommand(Query, con);
                SqlDataReader reader = com.ExecuteReader();
                String result = "";
                if (reader.Read())
                    result = Login;
                reader.Close();
                return result;
            }
        }
         public static String VerifyEmail(String mail)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                String Query = String.Format(@"select Login from dbo.Users where Email = '{0}'",mail);
                SqlCommand com = new SqlCommand(Query, con);
                return (string)com.ExecuteScalar();
            }
        }

        public static bool UpdatePassword(string Login, string Pass)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                String Query = String.Format(@"Update dbo.Users set Password = '{0}' where 
                                Login = '{1}'", Pass, Login);
                SqlCommand com = new SqlCommand(Query, con);
                return com.ExecuteNonQuery() > 0;
            }
        }
        public static bool ValidateAdmin(string Login, string Pass)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                String Query = String.Format(@"select * from dbo.Admin where Login = '{0}' 
                                and Password = '{1}'", Login, Pass);
                SqlCommand com = new SqlCommand(Query, con);
                SqlDataReader reader = com.ExecuteReader();
                bool result = false;
                if (reader.Read())
                    result = true;
                reader.Close();
                return result;
            }
        }
        public static DataTable LoadAllUsers()
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                String Query = "select * from dbo.Users";
                SqlCommand com = new SqlCommand(Query, con);
                SqlDataReader reader = com.ExecuteReader();
                DataTable user = new DataTable();
                user.Load(reader);
                reader.Close();
                return user;
            }
        }
    }
}
