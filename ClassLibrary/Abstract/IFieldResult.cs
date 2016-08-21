using SSDC_WebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Abstract
{
    /// <summary>
    /// Interface: Field Result
    /// </summary>
    public interface IFieldResult
    {
        /// <summary>
        /// Gets a field result.
        /// </summary>
        /// <value>
        /// A field result.
        /// </value>
        IEnumerable<FieldResult> FieldResult { get; }
    }
}
