using SSDC_WebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Abstract
{
    /// <summary>
    /// Interface: Field Option
    /// </summary>
    public interface IFieldOption
    {
        /// <summary>
        /// Gets a acollection field options.
        /// </summary>
        /// <value>
        /// A collection  field options.
        /// </value>
        IEnumerable<FieldOption> FieldOptions { get; }
    }
}
