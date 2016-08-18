using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entities
{
   public class Event
    {
        public int ID { get; set; }
        public string eventName {get; set;}
        public string eventDescription { get; set; }
        public string imagePath { get; set; }
    }
}
