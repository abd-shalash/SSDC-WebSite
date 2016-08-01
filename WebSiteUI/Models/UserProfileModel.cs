using ClassLibrary.Entities;
using SSDC_WebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSiteUI.Models
{
    public class UserProfileModel
    {
        public IEnumerable<user> users { get; set; }

        public string Password { get; set; }

        public string Fname { get; set; }

        public int work_number { get; set; }

        public string Lname { get; set; }

        public string Email { get; set; }

        public int mobile_number { get; set; }

        public int gender { get; set; }

        public int id_number { get; set; }
    }
}