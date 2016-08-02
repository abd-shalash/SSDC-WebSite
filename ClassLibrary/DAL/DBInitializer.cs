using ClassLibrary.Concrate;
using ClassLibrary.Entities;
using SSDC_WebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DAL
{
    class DBInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<EF_DBContext>
    {
        protected override void Seed(EF_DBContext context)
        {
           
            var events = new List<Event>
            {
            new Event
            {
                eventDescription="asdasdasdasdasdasd",
                eventName="event 1",
                ID=1
            },
                        new Event
            {
                eventDescription="asdasdasdasdasdasd",
                eventName="event 2",
                ID=2
            },
                                    new Event
            {
                eventDescription="asdasdasdasdasdasd",
                eventName="event 3",
                ID=3
            }

            };
            events.ForEach(s => context.Events.Add(s));
            context.SaveChanges();
            //////////////////////////
            var faclities = new List<Facility>
            {
            new Facility
            {
                FaDescription="asdasdasdasdasdasd",
                FaName="event 1",
                ID=1
            },
                        new Facility
            {
                FaDescription="asdasdasdasdasdasd",
                FaName="event 2",
                ID=2
            },
                                    new Facility
            {
                FaDescription="asdasdasdasdasdasd",
                FaName="event 3",
                ID=3
            }

            };
            faclities.ForEach(s => context.Facilities.Add(s));
            context.SaveChanges();
        }
    }
}
