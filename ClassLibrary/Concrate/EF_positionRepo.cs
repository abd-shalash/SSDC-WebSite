using ClassLibrary.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSDC_WebSite.Models;

namespace ClassLibrary.Concrate
{
    public class EF_positionRepo : IpositionRepo
    {
        private readonly EF_DBContext context = new EF_DBContext();

        public IEnumerable<position> positions
        {
            get
            {
                return context.positions;
            }
        }
    }
}
