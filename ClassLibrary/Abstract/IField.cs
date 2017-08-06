using SSDC_WebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Abstract
{
    /// <summary>
    /// Interface: Field
    /// </summary>
    public interface IField
    {
        /// <summary>
        /// Gets a collection of fields.
        /// </summary>
        /// <value>
        /// A collection of  fields.
        /// </value>
        IEnumerable<Field> Fields { get; }
    }
}
