using SSDC_WebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Abstract
{
    /// <summary>
    /// Interface: Service
    /// </summary>
    public interface IService
    {
        /// <summary>
        /// Gets the Services.
        /// </summary>
        /// <value>
        /// The collection of Service.
        /// </value>
        IEnumerable<Service> Services { get; }
    }
}
