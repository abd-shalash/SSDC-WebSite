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

        /// </summary>
        ///  This method will be called after migrating to the latest version.
        ///  You can use the DbSet<T>.AddOrUpdate() helper extension method
        ///  to avoid creating duplicate seed data. E.g.
        ///  
        ///  context.People.AddOrUpdate
        ///  (
        ///    p => p.FullName,
        ///    new Person { FullName = "Andrew Peters" },
        ///    new Person { FullName = "Brice Lambson" },
        ///    new Person { FullName = "Rowan Miller" }
        ///  );
        /// </summary>
        protected override void Seed(Concrate.EF_DBContext context)
        {

            var participant_level = new List<ParticipantLevel>
            {
                new ParticipantLevel
                {
                    participant_level_id = 1,
                    participant_level_name = "Level 1",
                    participant_type = "Type 1"
                }
            };
            participant_level.ForEach(o => context.participant_levels.AddOrUpdate(p => p.participant_level_id, o));
            context.SaveChanges();

            var gender_list = new List<Gender>
            {
                new Gender
                {
                    Id = 1,
                    MyGender = "Male"
                },

                new Gender
                {
                    Id = 2,
                    MyGender = "Female"
                }
            };
            gender_list.ForEach(o => context.genders.AddOrUpdate(p => p.Id, o));
            context.SaveChanges();

            var organi_type = new List<OrganizationType>
            {
                new OrganizationType
                {
                     organization_type_id = 1,
                     organization_type_name = "Outside PNU"
                },

                new OrganizationType
                {
                     organization_type_id = 2,
                     organization_type_name = "Inside PNU"
                }
            };
            organi_type.ForEach(o => context.organization_types.AddOrUpdate(p => p.organization_type_id, o));
            context.SaveChanges();

            var organi = new List<Organization>
            {
                new Organization
                {
                    organization_id = 1,
                    organization_name ="PNU",
                    organization_type = context.organization_types.FirstOrDefault(p=>p.organization_type_id ==1)
                },
                new Organization
                {
                    organization_id = 1,
                    organization_name ="KAAUH",
                    organization_type = context.organization_types.FirstOrDefault(p=>p.organization_type_id ==1)
                }
            };
            organi.ForEach(o => context.organizations.AddOrUpdate(p => p.organization_id, o));
            context.SaveChanges();

            var poositions = new List<Position>
            {
                new Position
                {
                    position_id = 1,
                    position_name = "Adminstration",
                },
                new Position
                {
                    position_id = 2,
                    position_name = "Student",
                },
                new Position
                {
                    position_id = 3,
                    position_name = "Instructor",
                },
                new Position
                {
                    position_id = 4,
                    position_name = "Engineer",
                },
                new Position
                {
                    position_id = 5,
                    position_name = "Technician",
                },
                new Position
                {
                    position_id = 6,
                    position_name = "Management",
                }
            };
            poositions.ForEach(o => context.positions.AddOrUpdate(p => p.position_id, o));
            context.SaveChanges();

            var departs = new List<Department>
            {
                new Department
                {
                    department_id = 1,
                    department_name = "SSDC",
                    organization_type = context.organization_types.FirstOrDefault(p=>p.organization_type_id ==2)
                }
            };
            departs.ForEach(o => context.departments.AddOrUpdate(p => p.department_id, o));
            context.SaveChanges();

            var users = new List<user>
            {
                new user
                {
                    user_id = 1,
                    id_number = 1,
                    work_number = 0123456789,
                    mobile_number = 0123456789,
                    first_name = "admin",
                    last_name = "admin",
                    email = "admin@admin.com",
                    password = "P@$$w0rd!",
                    userGender = gender_list[0],
                    position_id = 1,
                    organization = context.organizations.FirstOrDefault(p=>p.organization_id==1),
                    position = context.positions.FirstOrDefault(u=>u.position_id==1),
                    department = context.departments.FirstOrDefault(d=>d.department_id==1)
                }
            };
            users.ForEach(o => context.users.AddOrUpdate(p => p.email, o));
            context.SaveChanges();

            var groupsList = new List<Group>
            {
                new Group
                {
                    group_id = 1,
                    group_name = "User"
                },
                new Group
                {
                    group_id = 2,
                    group_name = "Admin"
                }
            };
            groupsList.ForEach(o => context.groups.AddOrUpdate(p => p.group_id, o));
            context.SaveChanges();

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

            var group_operationList = new List<GroupOperation>
            {
                new GroupOperation
                {
                    group_operation_id = 1,
                }
            };
            group_operationList.ForEach(o => context.group_operations.AddOrUpdate(p => p.group_operation_id, o));
            context.SaveChanges();

            var events = new List<Event>
            {
                new Event
                {
                    ID = 1,
                    eventDescription = "Description for Event 1",
                    eventName = "Event 1"
                },
                new Event
                {
                    ID = 2,
                    eventDescription = "Description for Event 2",
                    eventName = "Event 2"
                },
                new Event
                {
                    ID = 3,
                    eventDescription = "Description for Event 3",
                    eventName = "Event 3"
                }
            };
            events.ForEach(e => context.Events.AddOrUpdate(p => p.ID, e));
            context.SaveChanges();

            var facilitys = new List<Facility>
            {
                new Facility
                {
                    ID = 1,
                    FaDescription = "Description for Facility 1",
                    FaName = "Facility 1"
                },
                new Facility
                {
                    ID = 2,
                    FaDescription = "Description for Facility 2",
                    FaName = "Facility 2"
                },
                new Facility
                {
                    ID = 3,
                    FaDescription = "Description for Facility 3",
                    FaName = "Facility 3"
                }
            };
            facilitys.ForEach(e => context.Facilities.AddOrUpdate(p => p.ID, e));
            context.SaveChanges();

            var fromlist = new List<Form>
            {
                new Form
                {
                    form_id = 1,
                    form_name = "Form 1"
                },
                new Form
                {
                    form_id = 2,
                    form_name = "Form 2"
                }
            };
            fromlist.ForEach(e => context.forms.AddOrUpdate(p => p.form_id, e));
            context.SaveChanges();

            var operationslist = new List<Operation>
            {
                new Operation
                {
                    operation_id = 1,
                    operation_name = "User"
                },
                new Operation
                {
                    operation_id = 2,
                    operation_name = "Position"
                },
                new Operation
                {
                    operation_id = 3,
                    operation_name = "Organization"
                },
                new Operation
                {
                    operation_id = 4,
                    operation_name = "Department"
                },
                new Operation
                {
                    operation_id = 5,
                    operation_name = "Booking"
                },
            };
            operationslist.ForEach(o => context.operations.AddOrUpdate(p => p.operation_id, o));
            context.SaveChanges();

            var fieldlist = new List<Field>
            {
                new Field
                {
                    field_id = 1,
                    field_name = "Field 1",
                    field_type = "Field Type",
                    field_desc = "Field Description"
                }
            };
            fieldlist.ForEach(e => context.fields.AddOrUpdate(p => p.field_id, e));
            context.SaveChanges();

            var property_typelist = new List<property_type>
            {
                new property_type
                {
                    property_type_id = 1,
                    property_type_name = "Property Type"
                }
            };
            property_typelist.ForEach(e => context.property_types.AddOrUpdate(p => p.property_type_id, e));
            context.SaveChanges();

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

            var object_propertyList = new List<ObjectProperty>
            {
                new ObjectProperty
                {
                    object_property_id = 1

                }
            };
            object_propertyList.ForEach(o => context.object_propertyies.AddOrUpdate(p => p.object_property_id, o));
            context.SaveChanges();

            var booking_assigned_userList = new List<BookingUsers>
                {
                new BookingUsers
                {
                    booking_assigned_user_id = 1
                }
            };
            booking_assigned_userList.ForEach(o => context.booking_assigned_users.AddOrUpdate(p => p.booking_assigned_user_id, o));
            context.SaveChanges();

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

            var bookingsList = new List<Booking>
            {
                new Booking
                {
                    booking_id = 1,
                    booking_date = DateTime.Now,
                    start_date = DateTime.Now,
                    end_date = DateTime.Now,
                    topic = "sp",
                }
            };
            bookingsList.ForEach(o => context.bookings.AddOrUpdate(p => p.booking_id, o));
            context.SaveChanges();

            var booking_objectList = new List<BookingObject>
            {
                new BookingObject
                {
                    booking_object_id = 1
                }
            };
            booking_objectList.ForEach(o => context.booking_objects.AddOrUpdate(p => p.booking_object_id, o));
            context.SaveChanges();
        }
    }
}