using ClassLibrary.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSiteUI.Models;

namespace WebSiteUI.Controllers
{
    public class FacilityListController : Controller
    {
        private readonly IFacilityRepository repository;
        public FacilityListController(IFacilityRepository repo)
        {
            repository = repo;
        }
        // GET: FacilityList
        public ActionResult ListFacilities()
        {
            ListFacilityViewModel model = new ListFacilityViewModel
            {
                Facilities = repository.facilities.OrderBy(p=>p.FaName)
            };
            return View(model);
        }
        public ViewResult ListPartal()
        {
            ListFacilityViewModel model = new ListFacilityViewModel
            {
                Facilities = repository.facilities.OrderBy(p => p.FaName)
            };
            return View(model);
        }
    }
}