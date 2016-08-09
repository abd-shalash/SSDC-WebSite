using ClassLibrary.Abstract;
using ClassLibrary.Concrate;
using SSDC_WebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace WebSiteUI.Controllers
{
    public class AdminController : Controller
    {
      //  user model = new user();
        private EF_DBContext repository = new EF_DBContext();


        // GET: Admin
        /// <summary>
        /// //////////////////////////////////
        /// </summary>
        /// <returns></returns>
        /// 
        public ActionResult Index()
        {
            return View(repository.operations);
        }
        public ActionResult AdminUserIndex()
        {
            return View(repository.users);
        }
        public ActionResult CreateUser()
        {
            return View();
        }
        public ViewResult EditUser(int? id)
        {

            if (id == null)
            {
                return View();
            }
            user student = repository.users.Find(id);
            if (student == null) { return View(); }
            
            return View(student);
        }
        [HttpPost]
        public ActionResult EditUser(user id)
        {
            repository.UpdateUser(id);
            if (ModelState.IsValid)
            {
                repository.UpdateUser(id);
                TempData["message"] = string.Format("{0} has been updated", id.first_name);
                return RedirectToAction("AdminUserIndex");
            }
            else
            {
                ///data values are wrong somewhow
                return RedirectToAction("AdminUserIndex");
            }
            return View(id);
        }
        public ActionResult DetailsUser(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            user student = repository.users.Find(id);
            if (student == null) { return HttpNotFound(); }
            return View(student);
         
        }
        [HttpPost]
        public ActionResult DeleteUser(int? id)
        {
            user Deleteduser = repository.users.Find(id);
            if (Deleteduser!=null)
            {
                repository.users.Remove(repository.users.Find(id));
                repository.SaveChanges();

                TempData["message"] = string.Format("{0} was deleted ", Deleteduser.first_name);
            }
            return RedirectToAction("AdminUserIndex");
        }
        public ActionResult Calender()
        {
            return View();
        }
        public ActionResult AdminProfile()
        {
            return View();
        }
        /// <summary>
        /// ///////////////////////////////////////////
        /// </summary>
        /// <returns></returns>
        public ActionResult AdminPositionIndex()
        {
            return View(repository.positions);
        }
        public ActionResult AdminOrganizationIndex()
        {
            return View(repository.organizations);
        }
        public ActionResult AdminObjecttIndex()
        {
            return View(repository.objectts);
        }
        public ActionResult AdminGroupIndex()
        {
            return View(repository.groups);

        }
        public ActionResult AdminFormIndex()
        {
            return View(repository.forms);

        }
        public ActionResult AdminFieldIndex()
        {
            return View(repository.fields);

        }
        public ActionResult AdminDepartmentIndex()
        {
            return View(repository.departments);

        }
        public ActionResult AdminBookingIndex()
        {
            return View(repository.bookings);

        }
        public ActionResult AdminUserGroupIndex()
        {
            return View(repository.user_groups);

        }
        public ActionResult AdminTemplateIndex()
        {
            return View();

        }
        public ActionResult AdminServiceCostIndex()
        {
            return View(repository.service_costs);

        }
        public ActionResult AdminPropertyTypeIndex()
        {
            return View();

        }
        public ActionResult AdminPropertyIndex()
        {
            return View();

        }
        public ActionResult AdminParticipantLevelIndex()
        {
            return View();

        }

        public ActionResult AdminOperationIndex()
        {
            return View();

        }
        public ActionResult AdminObjectTypeIndex()
        {
            return View();

        }
        public ActionResult AdminObjectPropertyIndex()
        {
            return View();

        }
        public ActionResult AdminObjectOperationIndex()
        {
            return View();

        }
        //public ActionResult AdminOrganizationTypeIndex()
        //{
        //    return View();

        //}

    }
}