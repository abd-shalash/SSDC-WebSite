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
    public partial class service_cost
    {
        [Key]
        public int service_cost_id { get; set; }
        public string additional_level { get; set; }
        public int service_id { get; set; }
        public string service_type { get; set; }
        public decimal total_cost { get; set; }
        public decimal user_cost { get; set; }
    
        public virtual department department { get; set; }
        public virtual organization organization { get; set; }
    }
}