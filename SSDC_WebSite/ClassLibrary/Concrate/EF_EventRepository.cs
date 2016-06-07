using ClassLibrary.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Entities;

namespace ClassLibrary.Concrate
{
    public class EF_EventRepository : IEventRepository
    {
        private readonly EF_DBContext context = new EF_DBContext();
        public IEnumerable<Event> Events
        {
            get
            {
                return context.Events;
            }
        }
    }
}
