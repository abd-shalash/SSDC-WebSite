using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entities
{
   public class user_group
    {
        public int user_group_id { get; set; }
        public int user_id { get; set; }
        public int group_id { get; set; }
    }
}
