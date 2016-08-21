using SSDC_WebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Abstract
{
    /// <summary>
    /// 
    /// </summary>
    public interface IGroupOperation
    {
        /// <summary>
        /// Gets a collection of group operations.
        /// </summary>
        /// <value>
        /// A collection of group operations.
        /// </value>
        IEnumerable<GroupOperation> GroupOperations { get; }
    }
}
