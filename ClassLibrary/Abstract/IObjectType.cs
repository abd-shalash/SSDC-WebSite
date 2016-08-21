using SSDC_WebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Abstract
{
    /// <summary>
    /// Interface: Object Type
    /// </summary>
    public interface IObjectType
    {
        /// <summary>
        /// Gets a collection object types.
        /// </summary>
        /// <value>
        /// A collection object types.
        /// </value>
        IEnumerable<ObjectType> ObjectTypes { get; }
    }
}
