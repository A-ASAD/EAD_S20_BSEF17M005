using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS_DAL;

namespace UMS_BAL
{
    public static class UserBO
    {
        public static String ValidateUser(String login, String pass)
        {
            return UserDAO.ValidateUser(login, pass);
        }

        public static bool CreateUser(String Name, String Login, String Pass, String Mail, char Gender,
            String Address, int Age, String NIC, DateTime Dob, bool isCricket, bool isHockey, bool isChess, string imagePath)
        {
            string dob = Dob.Date.ToString();
            return UserDAO.CreateUser(Name, Login, Pass, Mail, Gender, Address, Age, NIC, dob.Substring(0,10), isCricket,
                isHockey, isChess, imagePath);
        }
    }
}
