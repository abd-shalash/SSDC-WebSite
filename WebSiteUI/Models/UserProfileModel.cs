using ClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSiteUI.Models
{
    public class UserProfileModel
    {
        public IEnumerable<Person> People { get; set; }

        public string Password { get; set; }

        public string Fname { get; set; }

        public string Mname { get; set; }

        public string Lname { get; set; }

        public string Username { get; set; }
    }
}