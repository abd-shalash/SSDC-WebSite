using SSDC_WebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Abstract
{
    /// <summary>
    /// Interface: Department
    /// </summary>
    public interface IDepartment
    {
        /// <summary>
        /// Gets a collection of departments.
        /// </summary>
        /// <value>
        /// A collection of departments.
        /// </value>
        IEnumerable<Department> Departments { get; }
    }
}
