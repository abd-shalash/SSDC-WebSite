﻿using ClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Concrate
{
    class EF_DBContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Facility> Facilities { get; set; }

        //TESTING TEAM
     }
}
