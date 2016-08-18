using ClassLibrary.Abstract;
using ClassLibrary.Concrate;
using ClassLibrary.Entities;
using SSDC_WebSite.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSiteUI.Models;


namespace WebSiteUI.Controllers
{
    public class SignupController : Controller
    {
        private EF_DBContext repository = new EF_DBContext();
      //  IuserRepo repository;
        //IpositionRepo posRepo;
        //IdepartmentRepo depRepo;
        //IorganizationRepo orgRepo;
         
        //public SignupController()
        //{
        //    this.repository = new EF_userRepo(new EF_DBContext());
        //}
      
        // GET: Signup
        public ActionResult Index(CreateUserModel model)
        {
            return View();
        }
        [AllowAnonymous]
        [HttpGet]
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
              
                    //  bool created = repository.addUser(newuser);
                    var tempBool = repository.users.FirstOrDefault(i => i.email == newuser.email);
                    if (tempBool != null) {
                        ModelState.AddModelError("", "ERROR a user with that email exsist ");
                        return View(model);
                    }
                        
                    
                    repository.users.Add(newuser);
                    //repository.users.Local.savesave();
                    repository.SaveChanges();
                    return RedirectToAction("Login", "Account");

             }
            catch (DataException /* dex */)
            {
                
                ModelState.AddModelError("", "error  ");

             
            }
            
            return View(model);
        }
    }
}