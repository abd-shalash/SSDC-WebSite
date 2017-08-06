using SSDC_WebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Abstract
{
    /// <summary>
    /// Interface: Template
    /// </summary>
    public interface ITemplate
    {
        /// <summary>
        /// Gets the Templates.
        /// </summary>
        /// <value>
        /// The collection of Templates.
        /// </value>
        IEnumerable<Template> Templates { get; }
    }
}
