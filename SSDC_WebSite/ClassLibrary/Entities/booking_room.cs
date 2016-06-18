using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entities
{
    public class booking_room
    {
        public int booking_room_id { get; set; }
        public int booking_id { get; set; }
        public int room_id { get; set; }
    }
}
