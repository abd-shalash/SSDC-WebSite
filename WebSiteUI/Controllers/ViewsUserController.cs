using ClassLibrary.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebSiteUI.Controllers
{
    public class ViewsUserController : Controller
    {
        //private readonly IPersonRepository repository;
        //// GET: ViewsUser
        //public ViewsUserController(IPersonRepository repository)
        //{
        //    this.repository = repository;
        //}
        public PartialViewResult UserProfile()
        {
            return PartialView();
        }
        public PartialViewResult Calender()
        {
            return PartialView();
        }
        public PartialViewResult ViewRequest()
        {
            return PartialView();
        }
        public PartialViewResult SubmitForm()
        {
            return PartialView();
        }
    }
}