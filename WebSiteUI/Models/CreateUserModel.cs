using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using ClassLibrary.Entities;

namespace WebSiteUI.Models
{
    public class CreateUserModel
    {
        [Required(ErrorMessage = "Password is required.")]
        [StringLength(20, MinimumLength = 3)]
        public string Password { get; set; }
        [Required(ErrorMessage = "FirstName is required.")]
        public string Fname { get; set; }
        [Required(ErrorMessage = "M name is required.")]
        public string Mname { get; set; }
        [Required(ErrorMessage = "LastName is required.")]
        public string Lname { get; set; }
        [Required(ErrorMessage = "Username is required.")]
        public string Username { get; set; }
        
    }
}