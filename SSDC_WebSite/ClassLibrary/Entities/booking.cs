﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entities
{
    public class booking
    {
        public int booking_id { get; set; }
        public int user_id { get; set; }
<<<<<<< HEAD
        public DateTime booking_date { get; set; } //should be of type time date 
=======
        public DateTime booking_date { get; set; }
>>>>>>> 7ad1d65ec373e1ff0f18ed4a168b96f667b18c16
        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; }
        public string topic { get; set; }
        public int no_of_participant { get; set; }
        public int participant_level_id { get; set; }
        public int department_id { get; set; }
        public int organization_id { get; set; }
        public bool it_support { get; set; }
        public string code_no { get; set; }
        public string booking_status { get; set; }
        public int status_updated_by { get; set; }
    }
}
