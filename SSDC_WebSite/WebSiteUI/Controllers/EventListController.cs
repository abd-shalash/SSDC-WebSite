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
    public class EventListController : Controller
    {   
        private readonly IEventRepository repository;
        public int PageSize = 2;
        public EventListController(IEventRepository repo)
        {
            repository = repo;
        }
        // GET: EventList
        public ViewResult List()
        {
            EventListViewModel model = new EventListViewModel
            {
                Events = repository.Events.OrderBy(p=>p.eventName)
            };
            return View(model);
        }
        public ViewResult ListPartal(int page = 1)
        {
            EventListViewModel model = new EventListViewModel
            {
                Events = repository.Events
                .OrderBy(p => p.eventName)
                .Skip((page - 1) * PageSize)
                .Take(PageSize),
                pageinfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Events.Count()
                }
            };
            return View(model);
        }
        public ViewResult details(int id) {

            Event tempEvent = new Event();



            tempEvent = repository.Events.FirstOrDefault(e => e.ID == id);

           
            
        
            return View(tempEvent);
        }
    }
}