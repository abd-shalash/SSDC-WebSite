using ClassLibrary.Entities;
using SSDC_WebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSiteUI.Models
{
    public class UserModel
    {   
        public IEnumerable<user> people { set; get; }
        public string SelectedTab { set; get; }
    }
}