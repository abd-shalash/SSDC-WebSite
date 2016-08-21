using ClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Abstract
{
    /// <summary>
    /// Interface: Event
    /// </summary>
    public interface IEvent
    {
        /// <summary>
        /// Gets a collection of events.
        /// </summary>
        /// <value>
        /// A collection of events.
        /// </value>
        IEnumerable<Event> Events { get; }
    }
}
