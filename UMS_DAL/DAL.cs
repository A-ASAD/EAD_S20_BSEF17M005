using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMS_DAL
{
    public static class UserDAO
    {
        public static String ValidateUser(String login, string pass)
        {
            if (login == "admin" && pass == "1234")
                return "Ali";
            return "";
        }
        public static bool CreateUser(String Name, String Login, String Pass, String Mail,char Gender,
            String Address, int Age, String NIC, string Dob, bool isCricket, bool isHockey, bool isChess, string imagePath)
        {
            string conString = @"Data Source=localhost\SQLEXPRESS; Initial Catalog=Assignment4;
                        User Id=sa; Password=asad226646";
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                String Query = String.Format(@"insert into dbo.Users(name, login, email, password, gender, address, age, nic, dob, isCricket, hockey, chess, imagename, CreatedOn)
                        select '{0}','{1}','{2}','{3}','{4}','{5}',{6},'{7}','{8}','{9}','{10}','{11}','asad',GETDATE()
                        where(select login from dbo.Users where Login = '{1}') is null",Name,Login,
                        Mail,Pass,Gender,Address,Age,NIC,Dob,isCricket,isHockey,isChess);
                SqlCommand com = new SqlCommand(Query, con);
                int res = com.ExecuteNonQuery();
                return res>0;
            }
        }
    }
}
