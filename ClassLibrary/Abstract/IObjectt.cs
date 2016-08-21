using SSDC_WebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Abstract
{
    /// <summary>
    /// Interface: Objectt
    /// </summary>
    public interface IObjectt
    {
        /// <summary>
        /// Gets a collection of objectts.
        /// </summary>
        /// <value>
        /// A collection of objectts.
        /// </value>
        IEnumerable<Objectt> Objectts { get; }
    }
}
