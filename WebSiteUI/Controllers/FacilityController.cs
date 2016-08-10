using ClassLibrary.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSiteUI.Models;
using ClassLibrary.Entities;
using ClassLibrary.Concrate;

namespace WebSiteUI.Controllers
{
    public class FacilityController : Controller
    {
        private EF_DBContext repository = new EF_DBContext();
        public int PageSize = 3;

        //public FacilityController(IFacilityRepository facilityRepository)
        //{
        //    this.facilityRepository = facilityRepository;
        //}

        public ActionResult FacilityListView()
        {
            FacilityModel model = new FacilityModel
            {
                Facilities = repository.Facilities.OrderBy(p=>p.FaName)
            };
            return View(model);
        }

        public ViewResult FacilityPartialView(int page = 1)
        {
            FacilityModel model = new FacilityModel
            {
                Facilities = repository.Facilities.OrderBy(p => p.FaName)
                .Skip((page-1) * PageSize)
                .Take(PageSize),
                pageinfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                  //  TotalItems = repository.facilities.Count()
                }
            };
            return View(model);
        }

        public ViewResult FacilityDetailsView(int id)
        {

            Facility facility = new Facility();

            facility = repository.Facilities.FirstOrDefault(e => e.ID == id);

            return View(facility);
        }
    }
}