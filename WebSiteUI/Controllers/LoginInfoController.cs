using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebSiteUI.Controllers
{
    public class LoginInfoController : Controller
    {
        //string fName = "";
        //string lName = "";
        // GET: LoginInfo
        public PartialViewResult Index()
        {   

            return PartialView("Index");
        }
    }
}