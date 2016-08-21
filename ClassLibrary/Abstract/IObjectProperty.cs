using SSDC_WebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Abstract
{
    /// <summary>
    /// Interface: Object Property
    /// </summary>
    public interface IObjectProperty
    {
        /// <summary>
        /// Gets a collection of object properties.
        /// </summary>
        /// <value>
        /// A collection of object properties.
        /// </value>
        IEnumerable<ObjectProperty> ObjectProperties { get; }
    }
}
