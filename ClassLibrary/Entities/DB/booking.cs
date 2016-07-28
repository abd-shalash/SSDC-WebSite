//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SSDC_WebSite.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public partial class booking
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public booking()
        {
            this.booking_assigned_user = new HashSet<booking_assigned_user>();
            this.booking_object = new HashSet<booking_object>();
            this.field_result = new HashSet<field_result>();
        }
        [Key]
        public int booking_id { get; set; }
        public DateTime booking_date { get; set; }
        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; }
        public string topic { get; set; }
        public int no_of_participant { get; set; }
        public string code_no { get; set; }
        public string booking_status { get; set; }
        public Nullable<DateTime> meeting_date { get; set; }
        public Nullable<DateTime> dryrun_date { get; set; }
        public string notes { get; set; }
        public string event_type { get; set; }
        public string staff_needed { get; set; }
        public string additional_requirement { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<booking_assigned_user> booking_assigned_user { get; set; }
        public virtual department department { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<booking_object> booking_object { get; set; }
        public virtual organization organization { get; set; }
        public virtual participant_level participant_level { get; set; }
        public virtual user user { get; set; }
        
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<field_result> field_result { get; set; }
    }
}
