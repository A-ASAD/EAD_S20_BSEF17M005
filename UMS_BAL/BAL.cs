using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using UMS_DAL;

namespace UMS_BAL
{
    public static class UserBO
    {
        private static string ImgFolderPath;
        public static String ValidateUser(String login, String pass)
        {
            return UserDAO.ValidateUser(login, pass);
        }

        public static bool CreateUser(String Name, String Login, String Pass, String Mail, char Gender,
            String Address, int Age, String NIC, DateTime Dob, bool isCricket, bool isHockey, bool isChess, string imagePath)
        {
            string imgPath = SaveImage(imagePath);
            return UserDAO.CreateUser(Name, Login, Pass, Mail, Gender, Address, Age, NIC, Dob.ToShortDateString(), isCricket,
                isHockey, isChess, imgPath);
        }

        public static void CreateImageFolder(string AppPath)
        {
            string imagePath = AppPath + @"\images";
            System.IO.Directory.CreateDirectory(imagePath);
            ImgFolderPath = imagePath;
        }

        public static string SaveImage(string ImagePath)
        {
            string uniqueName = Guid.NewGuid().ToString() + Path.GetExtension(ImagePath);
            string imgPath = ImgFolderPath + '\\' + uniqueName;
            System.IO.File.Copy(ImagePath, imgPath);
            return uniqueName;
        }

        public static DataTable GetUser(String Login)
        {
            DataTable user = UserDAO.GetUser(Login);
            return user;
        }

        public static bool UpdateUser(String Name, String Login, String prevLgn, String Pass, String Mail, char Gender,
            String Address, int Age, String NIC, DateTime Dob, bool isCricket, bool isHockey, bool isChess,
            string imagePath, bool isLgnChanged, bool isImageChanged)
        {
            string imgPath = imagePath;
            if(isImageChanged)
                imgPath = SaveImage(imagePath);
            return UserDAO.UpdateUser(Name, Login,prevLgn, Pass, Mail, Gender, Address, Age, NIC, Dob.ToShortDateString(), isCricket,
                isHockey, isChess, imgPath, isLgnChanged);
        }

        private static string RandomString(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        public static string SendMail(string toAddress)
        {
            MailAddress from = new MailAddress("EAD.SEMorning@gmail.com", "User Management System");
            MailAddress to = new MailAddress(toAddress);

            MailMessage mail = new MailMessage(from,to);
            mail.Subject = "Code For Password Reset";
            string code = RandomString(6);
            mail.Body = "Your code for Password Reset is:\n" + code;

            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("EAD.SEMorning@gmail.com", 
                "SEMorning2017");
            SmtpServer.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
            mail.Dispose();
            return code;
        }
        public static string VerifyEmail(String mail)
        {
            return UserDAO.VerifyEmail(mail);
        }

        public static bool UpdatePassword(string Login, string Pass)
        {
            return UserDAO.UpdatePassword(Login, Pass);
        }
        public static bool ValidateAdmin(string Login, string Pass)
        {
            return UserDAO.ValidateAdmin(Login, Pass);
        }
        public static DataTable LoadAllUsers()
        {
            return UserDAO.LoadAllUsers();
        }
    }
}
