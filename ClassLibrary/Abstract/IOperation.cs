using SSDC_WebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Abstract
{
    /// <summary>
    /// Interface: Operation
    /// </summary>
    public interface IOperation
    {
        /// <summary>
        /// Gets a collection operations.
        /// </summary>
        /// <value>
        /// A collection operations.
        /// </value>
        IEnumerable<Operation> Operations { get; }
    }
}
