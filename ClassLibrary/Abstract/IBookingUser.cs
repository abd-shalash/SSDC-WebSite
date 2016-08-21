using SSDC_WebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Abstract
{
    /// <summary>
    /// Interface: Booking User
    /// </summary>
    public interface IBookingUser
    {
        /// <summary>
        /// Gets a collection booking users.
        /// </summary>
        /// <value>
        /// A collection of booking users.
        /// </value>
        IEnumerable<BookingUsers> BookingUsers { get; }
    }
}
