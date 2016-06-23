using ClassLibrary.Abstract;
using ClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSiteUI.Models;

namespace WebSiteUI.Controllers
{
    public class EventController : Controller
    {   
        private readonly IEventRepository repository;
        public int pageSize = 3;

        public EventController(IEventRepository repo)
        {
            repository = repo;
        }

        public ViewResult EventListView()
        {
            EventModel eventModel = new EventModel
            {
                Events = repository.Events.OrderBy(p=>p.eventName)
            };
            return View(eventModel);
        }

        public ViewResult EventPartialView(int page = 1)
        {
            EventModel eventModel = new EventModel
            {
                Events = repository.Events
                .OrderBy(p => p.eventName)
                .Skip((page - 1) * pageSize)
                .Take(pageSize),
                pageinfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = pageSize,
                    TotalItems = repository.Events.Count()
                }
            };
            return View(eventModel);
        }

        public ViewResult EventDetailsView(int id) {

            Event tempEvent = new Event();

            tempEvent = repository.Events.FirstOrDefault(e => e.ID == id);
            
            return View(tempEvent);
        }
    }
}