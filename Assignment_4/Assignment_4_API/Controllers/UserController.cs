using BAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Assignment_4_API.Controllers
{
    [EnableCors(origins: "https://localhost:44351", headers: "*", methods: "*")]
    public class UserController : ApiController
    {
        [HttpPost]
        public string AddUser(AddUserParamHelper User)
        {
            if (User.Login.Trim() == "" || User.Pass.Trim() == "" || User.Name.Trim() == "" || User.CPass.Trim() == "")
                return "Invalid Input!";
            if (User.Pass != User.CPass)
                return "Both Passwords must match!";
            return UserBAO.AddUser(User.Login, User.Pass, User.Name);
        }

        [Authorize]
        [HttpPost]
        public string AddFolder(AddFolderParamHelper Folder)
        {
            if (Folder.Name.Trim() == "")
                return "Invalid Name!";
            return UserBAO.AddFolder(Folder.Name, Folder.Parent);
        }

        [Authorize]
        [HttpPost]
        public string GetFolders(GetFolderParamHelper Param)
        {
            return UserBAO.GetFolders(Param.Parent);
        }
    }


    public class GetFolderParamHelper //Helper classes for passing string arguments..
    {
        public string Parent { get; set; }
    }
    public class AddUserParamHelper
    {
        public string Name { get; set; }
        public string Login { get; set; }
        public string Pass { get; set; }
        public string CPass { get; set; }

    }
    public class AddFolderParamHelper
    {
        public string Name { get; set; }
        public string Parent { get; set; }
    }
}
