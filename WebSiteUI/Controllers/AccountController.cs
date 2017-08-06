using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSiteUI.Models;
using ClassLibrary.Concrate;
using System.Web.Security;
using ClassLibrary.Entities;

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
        public ActionResult Login(LoginModel model, string returnUrl)
        {
            
            // if the model is loaded correctly
            if (ModelState.IsValid)
            {
                // if the correct username and password is valid
                if (auth.Login(model.email, model.password))
                {
                    Session["user"] = (string)model.email;
                        //new Person() { Fname = model.UserName };
                    FormsAuthentication.SetAuthCookie(model.email, false);
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

        public ActionResult SignUp()
        {
            return RedirectToAction("Index", "SignUp");
        }
        

        
        public ActionResult Logout()
        {

            Request.Cookies.Remove("user");
            FormsAuthentication.SignOut();
            Session.Abandon();
            Session.Clear();
            Response.Cookies.Clear();
            Session.RemoveAll();
            Session["user"] = null;
            return RedirectToAction("Index", "Home");
        }
    }
}