using SSDC_WebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Abstract
{
    /// <summary>
    /// Interface: Organization
    /// </summary>
    public interface IOrganization
    {
        /// <summary>
        /// Gets a collection of organizations.
        /// </summary>
        /// <value>
        /// A collection of organizations.
        /// </value>
        IEnumerable<Organization> Organizations { get; }
    }
}
