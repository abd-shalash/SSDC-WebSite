using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebSiteUI.Controllers
{
    public class UserController : Controller
    {
        // GET: UserView
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult UserProfile()
        {
            return View();
        }
        public ActionResult Calender()
        {
            return View();
        }
        public ActionResult ViewRequest()
        {
            return View();
        }
        public ActionResult SubmitForm()
        {
            return View();
        }
    }
}