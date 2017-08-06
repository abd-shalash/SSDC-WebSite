using SSDC_WebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Abstract
{
    /// <summary>
    /// Interface: Form
    /// </summary>
    public interface IForm
    {
        /// <summary>
        /// Gets a collection of forms.
        /// </summary>
        /// <value>
        /// A collection of  forms.
        /// </value>
        IEnumerable<Form> Forms { get; }
    }
}
