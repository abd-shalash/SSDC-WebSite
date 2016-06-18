using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entities
{
    class standardized_patient_request
    {
        public int sp_request_id { get; set; }
        public int booking_id { get; set; }
        public int no_of_sp { get; set; }
        public string specific_requirement { get; set; }
        public Boolean assistance { get; set; }
        public string payment_type { get; set; }
    }
}
