using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entities
{
    class booking_item
    {


        public int booking_item_id { get; set; }
        public int booking_id { get; set; }
        public int item_item_id { get; set; }
        public string item_status { get; set; }

    }
}
