using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSiteUI.Models;
using ClassLibrary.Abstract;

namespace WebSiteUI.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        IAuthentication auth;

        public AccountController(IAuthentication auth)
        {
            this.auth = auth;
        }

        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                if (true)
                {

                }
                else
                {
                    ModelState.AddModelError("", "Incorrect username or passwrod");
                    return View();
                }
            }
            else
            {
                return View();
            }
            return View();
        }
    }
}