using ClassLibrary.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSiteUI.Models;

namespace WebSiteUI.Controllers
{
    public class EventListController : Controller
    {   
        private readonly IEventRepository repository;
        public EventListController(IEventRepository repo)
        {
            repository = repo;
        }
        // GET: EventList
        public ViewResult List()
        {
            EventListViewModel model = new EventListViewModel
            {
                Events = repository.Events.OrderBy(p=>p.EvName)
            };
            return View(model);
        }
        public ViewResult ListPartal()
        {
            EventListViewModel model = new EventListViewModel
            {
                Events = repository.Events.OrderBy(p => p.EvName)
            };
            return View(model);
        }
    }
}