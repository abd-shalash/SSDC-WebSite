using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entities
{
   public class User
    {
        public int user_id { get; set; }
        public string full_name { get; set; }
        public string email { get; set; }
        public int organization_id { get; set; }
        public int department_id { get; set; }
        public int work_number { get; set; }
        public int mobile_number { get; set; }
        public int gender { get; set; }
        public int id_number { get; set; }
        public string password { get; set; }
        public string position { get; set; }
    }
}
