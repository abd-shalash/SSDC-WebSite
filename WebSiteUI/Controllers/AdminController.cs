using ClassLibrary.Abstract;
using ClassLibrary.Concrate;
using SSDC_WebSite.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebSiteUI.Models;

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
            var model = new CreateUserModel();
            return View(model);
        }
        [HttpPost]
        [AllowAnonymous]
        public ActionResult CreateUser(CreateUserModel model)
        {


            position tempPos = new position();
            tempPos = repository.positions.FirstOrDefault(p => p.position_id == model.PositionID);

            department tempDep = new department();
            tempDep = repository.departments.FirstOrDefault(p => p.department_id == model.DepartmentID);

            organization tempOrg = new organization();
            tempOrg = repository.organizations.FirstOrDefault(p => p.organization_id == model.OrganizationID);
            user newuser = new user
            {
                email = model.Email,
                first_name = model.Fname,
                mobile_number = model.phone_number,
                last_name = model.Lname,
                password = model.Password,
                gender = model.Gender,
                organization = tempOrg,
                //new organization
                //{
                //    organization_id = tempOrg.organization_id,
                //    organization_name = tempOrg.organization_name,
                //    organization_type = tempOrg.organization_type

                //},
                department = tempDep,
                //new department
                //{
                //    department_id = tempDep.department_id,
                //    department_name = tempDep.department_name,
                //    organization_type = tempDep.organization_type

                //},

                position = tempPos,
                //new position
                //{
                //    position_id = tempPos.position_id,
                //    position_name = tempPos.position_name
                //}
            };
            try
            {
                if (ModelState.IsValid)
                {
                    //  bool created = repository.addUser(newuser);
                    var tempBool = repository.users.FirstOrDefault(i => i.email == newuser.email);
                    if (tempBool != null)
                    {
                        ModelState.AddModelError("", "ERROR a user with that email exsist ");
                        return View(model);
                    }


                    repository.users.Add(newuser);
                    //repository.users.Local.savesave();
                    repository.SaveChanges();
                    return View(model);


                }
                else { ModelState.AddModelError("", "error make sure that you have filled all the text boxes "); }
            }
            catch (DataException /* dex */)
            {

                ModelState.AddModelError("", "error  ");


            }

            return View(model);
        }
        public ActionResult EditUser(int? id)
        {

            if (id == null)
            {
                return View();
            }
            user student = repository.users.Find(id);
            if (student == null) { return View(); }

            return View(student);
        }
        [HttpPost, ActionName("EditUser")]
        [ValidateAntiForgeryToken]
        public ActionResult EditUserPost(int? id)
        {
            if (id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }
            var userUpdate = repository.users.Find(id);
            if (TryUpdateModel(userUpdate))
            {
                try
                {
                    
                    
                    repository.SaveChanges();
                    TempData["message"] = string.Format("{0} has been updated", userUpdate.first_name);
                    return RedirectToAction("AdminUserIndex");
                }
                catch (DataException)
                {
                    ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");

                    
                }
            }

            return View(userUpdate);
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
        
        public ActionResult DeleteUser(int? id)
        {
            if (id== null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            user Deleteduser = repository.users.Find(id);
            if (Deleteduser== null)
            {
                return HttpNotFound();
            }
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