using BAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment_3.Controllers
{
    public class UserController : Controller
    {
        
        public ActionResult Login()
        {
            Response.AddHeader("Cache-Control", "no-cache, no-store, must-revalidate");
            Response.AddHeader("Pragma", "no-cache");
            Response.AddHeader("Expires", "0");
            return View();
        }
        public ActionResult Home()
        {
            Response.AddHeader("Cache-Control", "no-cache, no-store, must-revalidate");
            Response.AddHeader("Pragma", "no-cache");
            Response.AddHeader("Expires", "0");
            return View();
        }

        public string ValidateUser(string Login, string Pass)
        {
            if (Login.Trim() == "" || Pass.Trim() == "")
                return "Invalid Login or Password!";
            string user = UserBAO.ValidateUser(Login, Pass);
            if(user != "Error")
                Session["user"] = user;
            return user;
        }

        public string AddUser(string Name, string Login, string Pass, string CPass)
        {
            if (Login.Trim() == "" || Pass.Trim() == "" || Name.Trim() == "" || CPass.Trim() == "")
                return "Invalid Input!";
            if (Pass != CPass)
                return "Both Passwords must match!";
            return UserBAO.AddUser(Login, Pass, Name);
        }

        public string AddFolder(string Name, string Parent)
        {
            if (Name.Trim() == "")
                return "Invalid Name!";
            return UserBAO.AddFolder(Name, Parent);
        }

        public string GetFolders(string Parent)
        {
            return UserBAO.GetFolders(Parent);
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return Redirect(Url.Content("~/User/Login"));
        }
    }
}