using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassLibrary.Abstract;


namespace WebSiteUI.Controllers
{
    public class AdminController : Controller
    {

        IPersonRepository personRepo;

        public AdminController(IPersonRepository repo)
        {
            personRepo = repo;
        }
         
        public ActionResult Index()
        {
            return View(personRepo.People);
        }
    }
}