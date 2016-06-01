using ClassLibrary.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Entities;

namespace ClassLibrary.Concrate
{
    class EF_PersonRepository : IPersonRepository
    {
        private EF_DBContext context = new EF_DBContext();
        public IEnumerable<Person> People
        {
            get { return context.People; }
        }
    }
}
