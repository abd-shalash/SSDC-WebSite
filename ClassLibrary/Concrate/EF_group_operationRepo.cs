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
    public class EF_group_operationRepo : Igroup_operationRepo
    {
        private readonly EF_DBContext context = new EF_DBContext();
        public IEnumerable<group_operation> group_operations
        {
            get
            {
                return context.group_operations;
            }
        }
    }
}
