using ClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSiteUI.Models
{
    public class EventModel
    {   
      public IEnumerable<Event> Events { get; set; }
      public PagingInfo pageinfo { set; get; }
    }
}