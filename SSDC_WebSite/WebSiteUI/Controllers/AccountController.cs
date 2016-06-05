using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSiteUI.Models;
using ClassLibrary.Abstract;
using System.Web.Security;

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
                if (auth.Authenticate(model.UserName, model.Password))
                {
                    FormsAuthentication.SetAuthCookie(model.UserName, false);
                    return Redirect(returnUrl ?? Url.Action("Index","Admin"));
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