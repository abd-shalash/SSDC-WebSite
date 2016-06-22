using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entities
{
    class room
    {
        public int room_id { get; set; }
        public int room_type_id { get; set; }
        public string room_name { get; set; }
        public int room_capacity { get; set; }
        public string room_image { get; set; }
        public string room_description { get; set; }
    }
}
