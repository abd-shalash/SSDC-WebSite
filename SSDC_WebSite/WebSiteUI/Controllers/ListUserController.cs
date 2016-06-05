using ClassLibrary.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebSiteUI.Controllers
{
    public class ListUserController : Controller
    {
        private readonly IPersonRepository repository;
        public ListUserController(IPersonRepository repo)
        {
            repository = repo;
        }
        // GET: ListUser
        public ActionResult List()
        {
            return View(repository.People);
        }
    }
}