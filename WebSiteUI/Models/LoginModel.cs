using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebSiteUI.Models
{
    public class LoginModel
    {
        //annotation: required input rules and the error message
        [Required(ErrorMessage = "email is required.")]
        public string email { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        [StringLength(20, MinimumLength = 3)]
        public string password { get; set; }
    }
}