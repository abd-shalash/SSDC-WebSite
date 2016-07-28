using ClassLibrary.Entities;
using SSDC_WebSite.Models;
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
        public DbSet<user> users { get; set; }
        public DbSet<user_group> user_groups { get; set; }
        public DbSet<template> templates { get; set; }
        public DbSet<service_cost> service_costs { get; set; }
        public DbSet<property> properties { get; set; }
        public DbSet<property_type> property_types { get; set; }
        public DbSet<position> positions { get; set; }
        public DbSet<organization_type> organization_types { get; set; }
        public DbSet<organization> organizations { get; set; }
        public DbSet<operation> operations { get; set; }
        public DbSet<objectt> objectts { get; set; }
        public DbSet<object_type> object_types { get; set; }
        public DbSet<object_property> object_propertyies { get; set; }
        public DbSet<participant_level> participant_levels { get; set; }
        public DbSet<group_operation> group_operations { get; set; }
        public DbSet<group> groups { get; set; }
        public DbSet<form> forms { get; set; }
        public DbSet<field_result> field_results { get; set; }
        public DbSet<field_option> field_options { get; set; }
        public DbSet<field> fields { get; set; }
        public DbSet<department> departments { get; set; }
        public DbSet<booking_object> booking_objects { get; set; }
        public DbSet<booking_assigned_user> booking_assigned_users { get; set; }
        public DbSet<booking> bookings { get; set; }
        public DbSet<additional_service> additional_services { get; set; }
      //  public DbSet<additional_service> additional_services { get; set; }

        //TESTING TEAM
    }
}
