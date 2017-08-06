using SSDC_WebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Abstract
{
    /// <summary>
    /// Interface: Organization Type
    /// </summary>
    public interface IOrganizationType
    {
        /// <summary>
        /// Gets a collection of organization types.
        /// </summary>
        /// <value>
        /// A collection of organization types.
        /// </value>
        IEnumerable<OrganizationType> OrganizationTypes { get; }
    }
}
