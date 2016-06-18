using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entities
{
    class full_simulation_booking
    {
        public int booking_id { get; set; }
        public string scenario_authirship { get; set; }
        public DateTime dryrun_date { get; set; }
        public string current_state_of_ksa { get; set; }
        public string ideal_state_of_ksa { get; set; }
        public string resources_supporting_evidence { get; set; }
        public string broad_objetive { get; set; }
        public string case_name { get; set; }
        public string case_age { get; set; }
        public string case_gender { get; set; }
        public string case_history { get; set; }
    }
}
