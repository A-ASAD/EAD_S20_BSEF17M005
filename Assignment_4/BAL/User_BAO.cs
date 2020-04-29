using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public static class UserBAO
    {
        public static string ValidateUser(string Login, string Pass)
        {
            return UserDAO.ValidateUser(Login, Pass);
        }

        public static string AddUser(string Login, string Pass, string Name)
        {
            return UserDAO.AddUser(Login, Pass, Name);
        }

        public static string AddFolder(string Name, string Parent)
        {
            return UserDAO.AddFolder(Name, Parent);
        }
        public static string GetFolders(string Parent)
        {
            return UserDAO.GetFolders(Parent);
        }
    }
}
