using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSiteUI.Models;

namespace WebSiteUI.Controllers
{
    public class UserController : Controller
    {
        UserModel mod = new UserModel { SelectedTab = "Profile" };
        public UserController()
        {
            mod.SelectedTab = "Profile";
        }
        // GET: UserView

        //public ActionResult Index()
        //{
        //    return View(defaultmod);
        //}
      //  [HttpPost]
        public ActionResult Index( String id,UserModel model)
        {
            if (model.SelectedTab == "Profile" || id == "Profile")
            {
                mod.SelectedTab = "Profile";
                return View(mod);
            }
            else if (model.SelectedTab == "Calender" || id == "Calender")
            {
                mod.SelectedTab = "Calender";

                return View(mod);
            }
            else if (model.SelectedTab == "ViewRequest" || id == "ViewRequest")
            {
                mod.SelectedTab = "ViewRequest";

                return View(mod);
            }
            else if (model.SelectedTab == "Submitform" || id == "Submitform")
            {
                mod.SelectedTab = "Submitform";
              
                return View(mod);
            }
            else
            {
                mod.SelectedTab = "Profile";
                return View(mod);
            }
            return View();
        }

    }
}