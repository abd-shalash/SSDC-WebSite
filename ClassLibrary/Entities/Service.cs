//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a Template.
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
    public partial class Service
    {
        [Key]
        public int Service_Id { get; set; }
        public string Service_Name { get; set; }
    }
}