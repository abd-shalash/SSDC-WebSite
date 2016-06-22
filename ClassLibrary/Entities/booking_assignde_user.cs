using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entities
{
    public class booking_assigned_user
    {
        public int booking_assignded_user_id { get; set; }
        public int booking_id { get; set; }
        public int user_id { get; set; }
    }
}
