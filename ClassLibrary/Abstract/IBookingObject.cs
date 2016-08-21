using SSDC_WebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Abstract
{
    /// <summary>
    /// Interface: Booking Object
    /// </summary>
    public interface IBookingObject
    {
        /// <summary>
        /// Gets a collection of booking objects.
        /// </summary>
        /// <value>
        /// A collection of booking objects.
        /// </value>
        IEnumerable<BookingObject> BookingObjects { get; }
    }
}
