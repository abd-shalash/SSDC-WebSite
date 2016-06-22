using ClassLibrary.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSiteUI.Models;

namespace WebSiteUI.Controllers
{
    public class UserListController : Controller
    {
        private readonly IPersonRepository repository;
        public UserListController(IPersonRepository repo)
        {
            repository = repo;
        }

        // GET: ListUser
        public ActionResult List()
        {
            UserModel model = new UserModel
            {
                people = repository.People
                .OrderBy(p => p.ID)
            };
            return View(model);
        }
    }
}