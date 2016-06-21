using ClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Abstract
{
    public interface IFacilityRepository
    {
        IEnumerable<Facility> facilities { get; }
    }
}
