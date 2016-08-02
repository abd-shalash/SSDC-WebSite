using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entities.DB
{
   public class bookingABD
    {   
        
        int booking_id { get; set; }

        [Key]
        
        int user_id { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        DateTime booking_date { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        DateTime start_date { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        DateTime end_date {get;set;}
        
        //string topic { get; set; }
        //no_of_participant;
        //participant_level_id;
        //department_id;
        //organization_id;
        //code_no;
        //booking_status;
        //status_updated_by;
        //meeting_date;
        //dryrun_date;
        //notes;
        //event_needed;
        //additional_requirment;
            
    }
}
