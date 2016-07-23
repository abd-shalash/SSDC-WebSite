using ClassLibrary.Concrate;
using ClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSiteUI.Models;


namespace WebSiteUI.Controllers
{
    public class SignupController : Controller
    {
        // GET: Signup
        public ActionResult Index(CreateUserModel model)
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult CreateUser()
        {
    
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult CreateUser(CreateUserModel model)
        {
            EF_PersonRepository repository = new EF_PersonRepository();
            Person newuser = new Person
            {
                Username = model.Username,
                Fname = model.Fname,
                Mname = model.Mname,
                Lname = model.Lname,
                Password = model.Password
            };
          //  newuser.Fname = model.Fname;
             
          //  repository.SaveUser(model.);
            if (ModelState.IsValid)
            {
                
                // search DB to see if a user already has the inputted new user acount name
                if (repository.SaveUser(newuser)==true)
                {
                    return RedirectToAction("Login", "Account");
                }
            }
            ModelState.AddModelError("","error user name already taken try another one ");
            //model.Lname.
            return View(model);
        }
    }
}