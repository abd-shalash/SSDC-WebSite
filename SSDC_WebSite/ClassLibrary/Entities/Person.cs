using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary.Entities
{
    public class Person
    {
        [Key]
        public int ID { get; set; }
        public string Fname { get; set; }
        public string Mname { get; set; }
        public string Lname { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
    }
}
