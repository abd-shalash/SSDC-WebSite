using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebSiteUI.Controllers
{
    public class NAVUserController : Controller
    {
        // GET: NAVUser
        public PartialViewResult userNAV()
        {
            return PartialView();
        }
    }
}