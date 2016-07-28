using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Abstract;
using SSDC_WebSite.Models;
using System.Runtime.Remoting.Contexts;

namespace ClassLibrary.Concrate
{
    public class EF_user_groupRepo : Iuser_groupRepo
    {
        private readonly EF_DBContext context = new EF_DBContext();
        public IEnumerable<user_group> user_groups
        {
            get
            {
                return context.user_groups;
            }
        }
    }
}
