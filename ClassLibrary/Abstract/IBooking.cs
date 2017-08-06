using SSDC_WebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Abstract
{
    /// <summary>
    /// Interface: Booking
    /// </summary>
    public interface IBooking
    {
        /// <summary>
        /// Gets a collection of bookings.
        /// </summary>
        /// <value>
        /// A collection of bookings.
        /// </value>
        IEnumerable<Booking> Bookings { get; }
    }
}
