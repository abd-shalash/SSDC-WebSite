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

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    public class EF_DBContext : DbContext
    {
        public EF_DBContext() : base("EF_DBContext"){}
        public DbSet<Gender> genders { set; get; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Facility> Facilities { get; set; }
        public DbSet<user> users { get; set; }
        public DbSet<user_group> user_groups { get; set; }
        public DbSet<template> templates { get; set; }
        public DbSet<service_cost> service_costs { get; set; }
        public DbSet<property> properties { get; set; }
        public DbSet<property_type> property_types { get; set; }
        public DbSet<Position> positions { get; set; }
        public DbSet<OrganizationType> organization_types { get; set; }
        public DbSet<Organization> organizations { get; set; }
        public DbSet<Operation> operations { get; set; }
        public DbSet<Objectt> objectts { get; set; }
        public DbSet<ObjectType> object_types { get; set; }
        public DbSet<ObjectProperty> object_propertyies { get; set; }
        public DbSet<ParticipantLevel> participant_levels { get; set; }
        public DbSet<GroupOperation> group_operations { get; set; }
        public DbSet<Group> groups { get; set; }
        public DbSet<Form> forms { get; set; }
        public DbSet<FieldResult> field_results { get; set; }
        public DbSet<FieldOption> field_options { get; set; }
        public DbSet<Field> fields { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<BookingObject> booking_objects { get; set; }
        public DbSet<BookingUsers> booking_assigned_users { get; set; }
        public DbSet<Booking> bookings { get; set; }
        public DbSet<additional_service> additional_services { get; set; }
        // public DbSet<additional_service> additional_services { get; set; }
    }
}
