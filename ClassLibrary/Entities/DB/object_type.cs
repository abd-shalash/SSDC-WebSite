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
    
    public partial class object_type
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public object_type()
        {
            this.objects = new HashSet<@object>();
        }
    
        public int object_type_id { get; set; }
        public string object_type1 { get; set; }
        public int quantity_of_object { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<@object> objects { get; set; }
    }
}
