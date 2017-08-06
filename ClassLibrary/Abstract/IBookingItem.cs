using SSDC_WebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Abstract
{
    /// <summary>
    /// Interface: Booking Items
    /// </summary>
    public interface IBookingItem
    {
        /// <summary>
        /// Gets a collection of booking items.
        /// </summary>
        /// <value>
        /// A collection of booking items.
        /// </value>
        IEnumerable<BookingItem> BookingItems { get; }
    }
}
