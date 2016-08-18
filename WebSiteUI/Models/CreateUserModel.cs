using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using ClassLibrary.Entities;
using ClassLibrary.Concrate;
using SSDC_WebSite.Models;

namespace WebSiteUI.Models
{
    public class CreateUserModel
    {
                


        [Required(ErrorMessage = "Password is required.")]
        [StringLength(20, MinimumLength = 3)]
        public string Password { get; set; }
        [Required(ErrorMessage = "FirstName is required.")]
        public string Fname { get; set; }
        [Required(ErrorMessage = "mobile number is required.")]
        public int phone_number { get; set; }
        [Required(ErrorMessage = "LastName is required.")]
        public string Lname { get; set; }
        [Required(ErrorMessage = "Username is required.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Gender is required.")]
        public Gender Gender { get; set; }
   //     [Required(ErrorMessage = "Organization is required.")]
        public organization organization { get; set; }
   //     [Required(ErrorMessage = "department is required.")]
        public department department { get; set; }
     //   [Required(ErrorMessage = "title is required.")]
        public position title { get; set; }


        public int  PositionID { get; set; }
        public int DepartmentID { get; set; }
        public int OrganizationID { get; set; }

    }
}