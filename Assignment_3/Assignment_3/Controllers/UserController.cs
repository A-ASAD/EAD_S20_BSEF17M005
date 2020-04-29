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
            if(Session["user"] == null)
                return View("Login");
            Response.AddHeader("Cache-Control", "no-cache, no-store, must-revalidate");
            Response.AddHeader("Pragma", "no-cache");
            Response.AddHeader("Expires", "0");
            ViewData["token"] = Session["user"];
            return View();
        }

        [HttpPost]
        public JsonResult ValidateUser(string Login, string Pass)
        {
            if (Login.Trim() == "" || Pass.Trim() == "")
                return Json("Invalid Login or Password!", JsonRequestBehavior.AllowGet);
            string user = UserBAO.ValidateUser(Login, Pass);
            if(user != "Error")
            {
                Session["user"] = TokenHelper.TokenHelper.GetToken(user);
            }
            return Json(user, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult Logout()
        {
            Session.Abandon();
            return Redirect(Url.Content("~/User/Login"));
        }
    }
}