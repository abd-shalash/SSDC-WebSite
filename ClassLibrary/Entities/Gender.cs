using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SSDC_WebSite.Models
{
    public class Gender
    {
        [Key]
        public int Id { get; set; }
        public string MyGender { get; set; }

    }
}