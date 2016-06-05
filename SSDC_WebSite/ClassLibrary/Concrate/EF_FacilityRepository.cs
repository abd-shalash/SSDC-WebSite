using ClassLibrary.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Entities;

namespace ClassLibrary.Concrate
{

    public class EF_FacilityRepository: IFacilityRepository
    {
        private readonly EF_DBContext context = new EF_DBContext();
 

        IEnumerable<Facility> IFacilityRepository.facilities
        {
            get
            {
                return context.Facilities;
            }
        }
    }
}
