using SSDC_WebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Abstract
{    
    /// <summary>
    /// Interface: ServiceCost
    /// </summary>
    public interface IServiceCost
    {
        /// <summary>
        /// Gets a collection of ServiceCosts.
        /// </summary>
        /// <value>
        /// A collection ServiceCosts.
        /// </value>
        IEnumerable<ServiceCost> ServiceCosts { get; }
    }
}
