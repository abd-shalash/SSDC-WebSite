namespace ClassLibrary.Migrations
{
    using Entities;
    using SSDC_WebSite.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ClassLibrary.Concrate.EF_DBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ClassLibrary.Concrate.EF_DBContext";
        }

        protected override void Seed(ClassLibrary.Concrate.EF_DBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //


            var organi_type = new List<organization_type>
            {
                new organization_type
                {
                 organization_type_id = 1,
                 organization_type_name = "outside univercity"
                },
                /////
                new organization_type
                {
                 organization_type_id = 2,
                 organization_type_name = "inside PNU"
                }
            };
            organi_type.ForEach(o => context.organization_types.AddOrUpdate(p => p.organization_type_id, o));
            context.SaveChanges();
            /////////////
            var organi = new List<organization>
            {
                new organization
                {
                    organization_id = 1,
                    organization_name ="alfaisal",    
                    organization_type = context.organization_types.FirstOrDefault(p=>p.organization_type_id ==1)
                }
                //////////////////

            };
            organi.ForEach(o => context.organizations.AddOrUpdate(p => p.organization_id, o));
            context.SaveChanges();
            /////////////
            var poositions = new List<position>
            {
                new position
                {
                    position_id = 1,
                    position_name = "student",
                },
                new position
                {
                    position_id = 2,
                    position_name = "instructor",
                },
                new position
                {
                    position_id = 3,
                    position_name = "engineer",
                }
            };
            poositions.ForEach(o => context.positions.AddOrUpdate(p => p.position_id, o));
            context.SaveChanges();
            ///
            /////////////
            var departs = new List<department>
            {
                new department
                {
                    department_id = 1,
                    department_name = "ssdc",
                    organization_type = context.organization_types.FirstOrDefault(p=>p.organization_type_id ==2)
                }

            };
            departs.ForEach(o => context.departments.AddOrUpdate(p => p.department_id, o));
            context.SaveChanges();
            //
            var users = new List<user>
            {
                new user
                {
                    user_id = 1,
                    id_number = 1,
                    work_number = 1234321,
                    mobile_number = 123123,
                    first_name = "abdulrahman",
                    last_name = "shalash",
                    email = "abd_shalash@hotmail.com",
                    password = "123",
                    gender = 1,
                    organization = context.organizations.FirstOrDefault(p=>p.organization_id==1),
                    position = context.positions.FirstOrDefault(u=>u.position_id==1),
                    department = context.departments.FirstOrDefault(d=>d.department_id==2)
                }
            };
            users.ForEach(o => context.users.AddOrUpdate(p => p.email, o));
            context.SaveChanges();
            ////
            var events = new List<Event>
            {
                new Event
                {
                    ID = 1,
                    eventDescription = "akjdakflakfgadlkjgdlfadkskg",
                    eventName = "test event 1"
                },
                                new Event
                {
                    ID = 2,
                    eventDescription = "lkdf;;;;234234234",
                    eventName = "test event 2"
                },                new Event
                {
                    ID = 3,
                    eventDescription = "23423423423",
                    eventName = "test event 3"
                }
            };
            events.ForEach(e => context.Events.AddOrUpdate(p => p.ID, e));
            context.SaveChanges();
            ////
            var facilitys = new List<Facility>
            {
                new Facility
                {
                    ID = 1,
                    FaDescription = "akjdakflakfgadlkjgdlfadkskg",
                    FaName = "test Facility 1"
                },
                                new Facility
                {
                    ID = 2,
                    FaDescription = "lkdf;;;;234234234",
                    FaName = "test Facility 2"
                },                new Facility
                {
                    ID = 3,
                    FaDescription = "23423423423",
                    FaName = "test Facility 3"
                }
            };
            facilitys.ForEach(e => context.Facilities.AddOrUpdate(p => p.ID, e));
            context.SaveChanges();

        }
    }
}
