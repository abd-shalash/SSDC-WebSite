using SSDC_WebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Abstract
{
    /// <summary>
    /// Interface: Participant Level
    /// </summary>
    public interface IParticipantLevel
    {
        /// <summary>
        /// Gets a collection of participant levels.
        /// </summary>
        /// <value>
        /// A collection of participant levels.
        /// </value>
        IEnumerable<ParticipantLevel> ParticipantLevels { get; }
    }
}
