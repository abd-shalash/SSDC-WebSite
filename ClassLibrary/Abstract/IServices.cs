using SSDC_WebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Abstract
{
    /// <summary>
    /// TODO
    /// </summary>
    public interface IServices
    {

        /// <summary>
        /// Gets the additional services.
        /// </summary>
        /// <value>
        /// The collection of Services.
        /// </value>
        IEnumerable<additional_service> AdditionalServices { get; }
    }
}
