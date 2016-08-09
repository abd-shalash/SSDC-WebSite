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
                 organization_type_name = "outside PNU"
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
            var groupsList = new List<group>
            {
                new group
                {
                    group_id = 1,
                    group_name = "normal user"
                },
                                new group
                {
                    group_id = 2,
                    group_name = "admin"
                }
            };
            groupsList.ForEach(o => context.groups.AddOrUpdate(p => p.group_id, o));
            context.SaveChanges();
            ////
            var usergroupsList = new List<user_group>
            {
                    new user_group
                    {
                        user_group_id = 1,

                    },
                    new user_group
                    {
                        user_group_id = 2,

                    }
            };
            usergroupsList.ForEach(o => context.user_groups.AddOrUpdate(p => p.user_group_id, o));
            context.SaveChanges();
            /////
            var group_operationList = new List<group_operation>
            {
                new group_operation
                {
                    group_operation_id = 1,

                }
            };
            group_operationList.ForEach(o => context.group_operations.AddOrUpdate(p => p.group_operation_id, o));
            context.SaveChanges();
            /////
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
                },
                new Event
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
                },
                new Facility
                {
                    ID = 3,
                    FaDescription = "23423423423",
                    FaName = "test Facility 3"
                }
            };
            facilitys.ForEach(e => context.Facilities.AddOrUpdate(p => p.ID, e));
            context.SaveChanges();
            //////
            var fromlist = new List<form>
            {
                new form
                {
                    form_id = 1,
                    form_name = "test form"
                },
                new form
                {
                    form_id = 2,
                    form_name = "test form2"
                }
            };
            fromlist.ForEach(e => context.forms.AddOrUpdate(p => p.form_id, e));
            context.SaveChanges();
            /////
            var operationslist = new List<operation>
            {
                new operation
                {
                    operation_id = 1,
                    operation_name = "AdminUserIndex"
                }
            };
            operationslist.ForEach(o => context.operations.AddOrUpdate(p => p.operation_id, o));
            context.SaveChanges();
            /////
            var fieldlist = new List<field>
            {
                new field
                {
                    field_id = 1,
                    field_name = "field name1",
                    field_type = "field type1",
                    field_desc = "field desc1"
                             
        }
    };
    fieldlist.ForEach(e => context.fields.AddOrUpdate(p => p.field_id, e));
            context.SaveChanges();
            /////
            var property_typelist = new List<property_type>
            {
                new property_type
                {
                    property_type_id = 1,
                    property_type_name = "property type name1"

                }
   };
   property_typelist.ForEach(e => context.property_types.AddOrUpdate(p => p.property_type_id, e));
            context.SaveChanges();
            /////
            var propertieslist = new List<property>
            {
                new property
                {
                    property_id = 1,
                    property_name = "property name1",
                    property_description = "property description1",
                    property_brand = "property brand1"

                }
   };
   propertieslist.ForEach(e => context.properties.AddOrUpdate(p => p.property_id, e));
            context.SaveChanges();
            /////
            var object_propertyList = new List<object_property>
            {
                new object_property
                {
                    object_property_id = 1
                    
                }
            };
            object_propertyList.ForEach(o => context.object_propertyies.AddOrUpdate(p => p.object_property_id, o));
            context.SaveChanges();
            /////
            var booking_assigned_userList = new List<booking_assigned_user>
                {
                new booking_assigned_user
                {
                    booking_assigned_user_id = 1
                }
            };
            booking_assigned_userList.ForEach(o => context.booking_assigned_users.AddOrUpdate(p => p.booking_assigned_user_id, o));
            context.SaveChanges();
            /////
            var additional_service_idList = new List<additional_service>
            {
                new additional_service
                {
                    additional_service_id = 1,
                    additional_sevice_name = "additional service name1"
                }
            };
            additional_service_idList.ForEach(o => context.additional_services.AddOrUpdate(p => p.additional_service_id, o));
            context.SaveChanges();
            /////
            var bookingsList = new List<booking>
            {
                //new booking
                //{
                //    booking_id = 1,
                //    booking_date = DateTime.Now,
                //    start_date = DateTime.Now,
                //    end_date = DateTime.Now,
                //    topic = "sp",
                    
                //}
            };
            var booking_objectList = new List<booking_object>
            {
                new booking_object
                {
                    booking_object_id = 1

                }
            };
            booking_objectList.ForEach(o => context.booking_objects.AddOrUpdate(p => p.booking_object_id, o));
            context.SaveChanges();
        



        }
    }
}
