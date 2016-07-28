using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Entities;
using ClassLibrary.Abstract;
using SSDC_WebSite.Models;

namespace ClassLibrary.Concrate
{
   public class EF_object_typeRepo : Iobject_typeRepo
    {
        private readonly EF_DBContext context = new EF_DBContext();

        public IEnumerable<object_type> object_types
        {
            get
            {
                return context.object_types;
            }
        }
    }
}
