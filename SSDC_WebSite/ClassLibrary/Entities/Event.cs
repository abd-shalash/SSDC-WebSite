using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entities
{
   public class Event
    {
        [Key]
        public int ID { get; set; }
        public string EvName {get; set;}
        public string eventDescription { get; set; }
    }
}
