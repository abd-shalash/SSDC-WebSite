using ClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSiteUI.Models
{
    public class FacilityModel
    {
        public IEnumerable<Facility> Facilities { get; set; }
        public PagingInfo pageinfo { set; get; }
    }
}