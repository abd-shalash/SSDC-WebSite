using ClassLibrary.Abstract;
using ClassLibrary.Concrate;
using ClassLibrary.Entities.DB;
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
        /// <summary>
        /// //////////
        /// </summary>
        /// <returns></returns>
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


            Position tempPos = new Position();
            tempPos = repository.positions.FirstOrDefault(p => p.position_id == model.PositionID);

            Department tempDep = new Department();
            tempDep = repository.departments.FirstOrDefault(p => p.department_id == model.DepartmentID);

            Organization tempOrg = new Organization();
            tempOrg = repository.organizations.FirstOrDefault(p => p.organization_id == model.OrganizationID);
            user newuser = new user
            {
                email = model.Email,
                first_name = model.Fname,
                mobile_number = model.phone_number,
                last_name = model.Lname,
                password = model.Password,
                userGender = model.Gender,
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
        [HttpPost, ActionName("EditUser")]
        [ValidateAntiForgeryToken]
        public ActionResult EditUserPost(int? id)
        {
            if (id == null)
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
    
        
        /// <summary>
        /// ///////////////////////////////////////////
        /// </summary>
        /// <returns></returns>
        public ActionResult AdminPositionIndex()
        {
            return View(repository.positions);
        }
        public ActionResult DetailsPosition(int? id)
        {
            if (id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Position newpos = repository.positions.Find(id);
            if (newpos==null)
            {
                return HttpNotFound();
            }
            return View(newpos);
        }
        public ActionResult DeletePosition(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Position DeletedPos = repository.positions.Find(id);
            if (DeletedPos == null)
            {
                return HttpNotFound();
            }
            if (DeletedPos != null)
            {
                repository.positions.Remove(repository.positions.Find(id));
                repository.SaveChanges();

                TempData["message"] = string.Format("{0} was deleted ", DeletedPos.position_name);
            }
            return RedirectToAction("AdminUserIndex"); 
        }
        public ActionResult EditPosition(int? id)
        {

            if (id == null)
            {
                return View();
            }
            Position EditPos = repository.positions.Find(id);
            if (EditPos == null) { return View(); }

            return View(EditPos);
            
        }
        [HttpPost, ActionName("EditPosition")]
        [ValidateAntiForgeryToken]
        public ActionResult EditPositionPost(int? id)
        {

            var EditPos = repository.positions.Find(id);
            if (TryUpdateModel(EditPos))
            {
                try
                {
                    repository.SaveChanges();
                    //var EditPos = repository.positions.Find(id);
                    TempData["message"] = string.Format("{0} has been updated", EditPos.position_name);
                 //   return RedirectToAction("AdminUserIndex");
                }
                catch (DataException)
                {
                    ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
                    return View(id);
                }
            }


                return RedirectToAction("AdminPositionIndex");
            

           
        }
        public ActionResult CreatePosition()
        {
            var model = new Position();
            return View(model);
        }
        [HttpPost]
        [AllowAnonymous]
        public ActionResult CreatePosition(Position model)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    


                    repository.positions.Add(model);
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

        /// <summary>
        /// /
        /// </summary>
        /// <returns></returns>
        public ActionResult AdminOrganizationIndex()
        {
            return View(repository.organizations);
        }
        public ActionResult CreateOrganization(int? id)
        {
            var model = new Organization();
            return View(model);
        }
        [HttpPost, ActionName("CreateOrganization")]
        [ValidateAntiForgeryToken]
        public ActionResult CreateOrganizationPost(Organization id)
        {
            try
            {
                if (ModelState.IsValid)
                {



                    repository.organizations.Add(id);
                    //repository.users.Local.savesave();
                    repository.SaveChanges();
                    return View(id);


                }
                else { ModelState.AddModelError("", "error make sure that you have filled all the text boxes "); }
            }
            catch (DataException /* dex */)
            {

                ModelState.AddModelError("", "error  ");


            }

            return View(id);
        }
        public ActionResult DetailsOrganization(int? id)

        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Organization detailsOrg = repository.organizations.Find(id);
            if (detailsOrg == null)
            {
                return HttpNotFound();
            }
            return View(detailsOrg);

        }
        public ActionResult EditOrganization(int? id)
        {

            if (id == null)
            {
                return View();
            }
            Organization EditOrg = repository.organizations.Find(id);
            if (EditOrg == null) { return View(); }

            return View(EditOrg);
        }
        [HttpPost, ActionName("EditOrganization")]
        [ValidateAntiForgeryToken]
        public ActionResult EditOrganizationPost(int? id)
        {

            if (id == null) { return View(); }
            var EditOrg = repository.organizations.Find(id);
            if (TryUpdateModel(EditOrg))
            {
                try
                {
                    repository.SaveChanges();
                    //var EditPos = repository.positions.Find(id);
                    TempData["message"] = string.Format("{0} has been updated", EditOrg.organization_name);
                    //   return RedirectToAction("AdminUserIndex");
                }
                catch (DataException)
                {
                    ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
                    return View(id);
                }
            }


            return RedirectToAction("AdminOrganizationIndex");



        }
        public ActionResult DeleteOrganization(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Organization DeletedOrg = repository.organizations.Find(id);
            if (DeletedOrg == null)
            {
                return HttpNotFound();
            }
            if (DeletedOrg != null)
            {
                repository.organizations.Remove(repository.organizations.Find(id));
                repository.SaveChanges();

                TempData["message"] = string.Format("{0} was deleted ", DeletedOrg.organization_name);
            }
            return RedirectToAction("AdminOrganizationIndex");

        }

        /// <summary>
        /// /
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// /
        /// </summary>
        /// <returns></returns>
        public ActionResult AdminDepartmentIndex()
        {
            return View(repository.departments);

        }
        public ActionResult CreateDepartment(int? id)
        {
            var model = new Department();
            return View(model);
        }
        [HttpPost, ActionName("CreateDepartment")]
        [ValidateAntiForgeryToken]
        public ActionResult CreateDepartment(Department id)
        {
            try
            {
                if (ModelState.IsValid)
                {



                    repository.departments.Add(id);
                    //repository.users.Local.savesave();
                    repository.SaveChanges();
                    return View(id);


                }
                else { ModelState.AddModelError("", "error make sure that you have filled all the text boxes "); }
            }
            catch (DataException /* dex */)
            {

                ModelState.AddModelError("", "error  ");


            }

            return View(id);
        }
        public ActionResult DetailsDepartment(int? id)

        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Department detailsDep = repository.departments.Find(id);
            if (detailsDep == null)
            {
                return HttpNotFound();
            }
            return View(detailsDep);

        }
        public ActionResult EditDepartment(int? id)
        {

            if (id == null)
            {
                return View();
            }
            Department EditDep= repository.departments.Find(id);
            if (EditDep == null) { return View(); }

            return View(EditDep);
        }
        [HttpPost, ActionName("EditDepartment")]
        [ValidateAntiForgeryToken]
        public ActionResult EditDepartmentPost(int? id)
        {

            if (id == null) { return View(); }
            var EditDep = repository.departments.Find(id);
            if (TryUpdateModel(EditDep))
            {
                try
                {
                    repository.SaveChanges();
                    //var EditPos = repository.positions.Find(id);
                    TempData["message"] = string.Format("{0} has been updated", EditDep.department_name);
                    //   return RedirectToAction("AdminUserIndex");
                }
                catch (DataException)
                {
                    ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
                    return View(id);
                }
            }


            return RedirectToAction("AdminDepartmentIndex");



        }
        public ActionResult DeleteDepartment(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Department DeletedDep = repository.departments.Find(id);
            if (DeletedDep == null)
            {
                return HttpNotFound();
            }
            if (DeletedDep != null)
            {
                repository.departments.Remove(DeletedDep);
                repository.SaveChanges();

                TempData["message"] = string.Format("{0} was deleted ", DeletedDep.department_name);
            }
            return RedirectToAction("AdminDepartmentIndex");

        }
        /// <summary>
        /// /
        /// </summary>
        /// <returns></returns>
        public ActionResult AdminBookingIndex()
        {
            return View(repository.bookings);

        }
        public ActionResult CreateBooking(int? id)
        {
            var model = new Booking();
            return View(model);
        }
        [HttpPost, ActionName("CreateBooking")]
        [ValidateAntiForgeryToken]
        public ActionResult CreateBooking(Booking id)
        {
            try
            {
                if (ModelState.IsValid)
                {



                    repository.bookings.Add(id);
                    //repository.users.Local.savesave();
                    repository.SaveChanges();
                    return View(id);


                }
                else { ModelState.AddModelError("", "error make sure that you have filled all the text boxes "); }
            }
            catch (DataException /* dex */)
            {

                ModelState.AddModelError("", "error  ");


            }

            return View(id);
        }
        public ActionResult DetailsBooking(int? id)

        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Booking detailsBooking = repository.bookings.Find(id);
            if (detailsBooking == null)
            {
                return HttpNotFound();
            }
            return View(detailsBooking);

        }
        public ActionResult EditBooking(int? id)
        {

            if (id == null)
            {
                return View();
            }
            Booking EditBooking = repository.bookings.Find(id);
            if (EditBooking == null) { return View(); }

            return View(EditBooking);
        }
        [HttpPost, ActionName("EditBooking")]
        [ValidateAntiForgeryToken]
        public ActionResult EditBookingPost(int? id)
        {

            if (id == null) { return View(); }
            var EditBooking = repository.bookings.Find(id);
            if (TryUpdateModel(EditBooking))
            {
                try
                {
                    repository.SaveChanges();
                    //var EditPos = repository.positions.Find(id);
                    TempData["message"] = string.Format("{0} has been updated", EditBooking.booking_id);
                    //   return RedirectToAction("AdminUserIndex");
                }
                catch (DataException)
                {
                    ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
                    return View(id);
                }
            }


            return RedirectToAction("AdminDepartmentIndex");



        }
        public ActionResult DeleteBooking(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Booking DeletedBooking = repository.bookings.Find(id);
            if (DeletedBooking == null)
            {
                return HttpNotFound();
            }
            if (DeletedBooking != null)
            {
                repository.bookings.Remove(DeletedBooking);
                repository.SaveChanges();

                TempData["message"] = string.Format("{0} was deleted ", DeletedBooking.booking_id);
            }
            return RedirectToAction("AdminDepartmentIndex");

        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
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