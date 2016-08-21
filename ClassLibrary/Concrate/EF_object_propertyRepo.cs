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
    public class EF_object_propertyRepo : IObjectProperty
    {
        private readonly EF_DBContext context = new EF_DBContext();
        public IEnumerable<ObjectProperty> ObjectProperties
        {
            get
            {
                return context.object_propertyies;
            }
        }
    }
}
