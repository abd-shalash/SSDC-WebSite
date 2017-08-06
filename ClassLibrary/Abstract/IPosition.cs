using SSDC_WebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Abstract
{
    /// <summary>
    /// Interface: Position
    /// </summary>
    public interface IPosition
    {
        /// <summary>
        /// Gets a collection of positions.
        /// </summary>
        /// <value>
        /// A collection positions.
        /// </value>
        IEnumerable<Position> Positions { get; }
    }
}
