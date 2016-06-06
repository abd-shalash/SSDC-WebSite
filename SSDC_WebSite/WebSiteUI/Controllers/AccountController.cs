using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSiteUI.Models;
using ClassLibrary.Concrate;
using System.Web.Security;

namespace WebSiteUI.Controllers
{
    //To allow the authozied users to access the controller, prevents anyone from changing the behaviour of the system.
    [Authorize]
    public class AccountController : Controller
    {
        LoginAuthenticationProvider auth;

        public AccountController(LoginAuthenticationProvider auth)
        {
            this.auth = auth;
        }

        //create the login view

        //to allow everyone to use the login
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(LoginViewModel model, string returnUrl)
        {
            
            // if the model is loaded correctly
            if (ModelState.IsValid)
            {
                // if the correct username and password is valid
                if (auth.Authenticate(model.UserName, model.Password))
                {
                    FormsAuthentication.SetAuthCookie(model.UserName, false);
                    return Redirect(returnUrl ?? Url.Action("index", "Home"));
                }
                else
                {
                    ModelState.AddModelError("", "Incorrect username or passwrod");
                    return View();
                }
            }
            return View();
        }
    }
}