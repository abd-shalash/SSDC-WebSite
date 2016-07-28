using ClassLibrary.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSDC_WebSite.Models;

namespace ClassLibrary.Concrate
{
    public class EF_booking_assigned_userRepo : Ibooking_assigned_userRepo
    {
        private readonly EF_DBContext context = new EF_DBContext();
        public IEnumerable<booking_assigned_user> booking_assigned_users
        {
            get
            {
                return context.booking_assigned_users;
            }
        }
    }
}
