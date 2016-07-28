using SSDC_WebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Abstract
{
    public interface Ibooking_assigned_userRepo
    {
        IEnumerable<booking_assigned_user> booking_assigned_users { get; }
    }
}
