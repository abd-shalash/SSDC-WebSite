using SSDC_WebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Abstract
{
    /// <summary>
    /// Interface: UserGroup
    /// </summary>
    public interface IUserGroup
    {
        /// <summary>
        /// Gets the Templates.
        /// </summary>
        /// <value>
        /// The collection of Templates.
        /// </value>
        IEnumerable<UserGroup> UserGroups { get; }
    }
}
