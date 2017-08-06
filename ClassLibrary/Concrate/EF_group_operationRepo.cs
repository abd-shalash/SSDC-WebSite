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
    public class EF_group_operationRepo : IGroupOperation
    {
        private readonly EF_DBContext context = new EF_DBContext();
        public IEnumerable<GroupOperation> GroupOperations { get { return context.group_operations; } }
    }
}
