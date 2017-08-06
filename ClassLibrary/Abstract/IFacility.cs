using ClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Abstract
{
    /// <summary>
    /// Interface: Facility
    /// </summary>
    public interface IFacility
    {
        /// <summary>
        /// Gets a collection of facilities.
        /// </summary>
        /// <value>
        /// A colleciton of facilities.
        /// </value>
        IEnumerable<Facility> Facilities { get; }
    }
}
