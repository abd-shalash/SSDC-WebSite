using SSDC_WebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Abstract
{
    /// <summary>
    /// Interface: Group
    /// </summary>
    public interface IGroup
    {
        /// <summary>
        /// Gets a colleciton of groups.
        /// </summary>
        /// <value>
        /// A collection of groups.
        /// </value>
        IEnumerable<Group> Groups { get; }
    }
}
