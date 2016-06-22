using ClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSiteUI.Models
{
    public class UserModel
    {   
        public IEnumerable<Person> people { set; get; }
    }
}