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
    public partial class BookingUsers
    {
        [Key]
        public int booking_assigned_user_id { get; set; }
    
        public virtual Booking booking { get; set; }
        public virtual user user { get; set; }
    }
}
