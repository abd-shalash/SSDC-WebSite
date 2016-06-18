using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entities
{
    class booking_simulation
    {
        public int booking_id { get; set; }
        public int simulation_type_id { get; set; }
        public bool standardized_patient { get; set; }
        public string participant_assessment { get; set; }
        public bool moulage { get; set; }
        public bool av_recording { get; set; }
        public string meeting_status { get; set; }
        public DateTime meeting_date { get; set; }
        public string identified_need { get; set; }
        public string learning_objective { get; set; }
        public string outcome_level_addressed { get; set; }
        public string criteria_and_performance_indicators { get; set; }
    }
}
