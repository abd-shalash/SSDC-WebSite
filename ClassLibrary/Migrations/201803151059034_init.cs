namespace ClassLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.additional_service",
                c => new
                    {
                        additional_service_id = c.Int(nullable: false, identity: true),
                        additional_sevice_name = c.String(),
                    })
                .PrimaryKey(t => t.additional_service_id);
            
            CreateTable(
                "dbo.BookingUsers",
                c => new
                    {
                        booking_assigned_user_id = c.Int(nullable: false, identity: true),
                        booking_booking_id = c.Int(),
                        user_user_id = c.Int(),
                    })
                .PrimaryKey(t => t.booking_assigned_user_id)
                .ForeignKey("dbo.Bookings", t => t.booking_booking_id)
                .ForeignKey("dbo.users", t => t.user_user_id)
                .Index(t => t.booking_booking_id)
                .Index(t => t.user_user_id);
            
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        booking_id = c.Int(nullable: false, identity: true),
                        booking_date = c.DateTime(nullable: false),
                        start_date = c.DateTime(nullable: false),
                        end_date = c.DateTime(nullable: false),
                        topic = c.String(),
                        no_of_participant = c.Int(nullable: false),
                        code_no = c.String(),
                        booking_status = c.String(),
                        meeting_date = c.DateTime(),
                        dryrun_date = c.DateTime(),
                        notes = c.String(),
                        event_type = c.String(),
                        staff_needed = c.String(),
                        additional_requirement = c.String(),
                        department_department_id = c.Int(),
                        organization_organization_id = c.Int(),
                        user_user_id = c.Int(),
                        participant_level_participant_level_id = c.Int(),
                    })
                .PrimaryKey(t => t.booking_id)
                .ForeignKey("dbo.Departments", t => t.department_department_id)
                .ForeignKey("dbo.Organizations", t => t.organization_organization_id)
                .ForeignKey("dbo.users", t => t.user_user_id)
                .ForeignKey("dbo.ParticipantLevels", t => t.participant_level_participant_level_id)
                .Index(t => t.department_department_id)
                .Index(t => t.organization_organization_id)
                .Index(t => t.user_user_id)
                .Index(t => t.participant_level_participant_level_id);
            
            CreateTable(
                "dbo.BookingObjects",
                c => new
                    {
                        booking_object_id = c.Int(nullable: false, identity: true),
                        booking_booking_id = c.Int(),
                        objectt_object_id = c.Int(),
                    })
                .PrimaryKey(t => t.booking_object_id)
                .ForeignKey("dbo.Bookings", t => t.booking_booking_id)
                .ForeignKey("dbo.Objectts", t => t.objectt_object_id)
                .Index(t => t.booking_booking_id)
                .Index(t => t.objectt_object_id);
            
            CreateTable(
                "dbo.Objectts",
                c => new
                    {
                        object_id = c.Int(nullable: false, identity: true),
                        object_name = c.String(),
                        object_capacity = c.Int(),
                        object_image = c.Binary(),
                        object_description = c.String(),
                        object_brand = c.String(),
                        object_location = c.String(),
                        object_type_object_type_id = c.Int(),
                        template_template_id = c.Int(),
                    })
                .PrimaryKey(t => t.object_id)
                .ForeignKey("dbo.ObjectTypes", t => t.object_type_object_type_id)
                .ForeignKey("dbo.templates", t => t.template_template_id)
                .Index(t => t.object_type_object_type_id)
                .Index(t => t.template_template_id);
            
            CreateTable(
                "dbo.ObjectProperties",
                c => new
                    {
                        object_property_id = c.Int(nullable: false, identity: true),
                        objectt_object_id = c.Int(),
                        property_property_id = c.Int(),
                    })
                .PrimaryKey(t => t.object_property_id)
                .ForeignKey("dbo.Objectts", t => t.objectt_object_id)
                .ForeignKey("dbo.properties", t => t.property_property_id)
                .Index(t => t.objectt_object_id)
                .Index(t => t.property_property_id);
            
            CreateTable(
                "dbo.properties",
                c => new
                    {
                        property_id = c.Int(nullable: false, identity: true),
                        property_name = c.String(),
                        property_description = c.String(),
                        property_brand = c.String(),
                        property_type_property_type_id = c.Int(),
                    })
                .PrimaryKey(t => t.property_id)
                .ForeignKey("dbo.property_type", t => t.property_type_property_type_id)
                .Index(t => t.property_type_property_type_id);
            
            CreateTable(
                "dbo.property_type",
                c => new
                    {
                        property_type_id = c.Int(nullable: false, identity: true),
                        property_type_name = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.property_type_id);
            
            CreateTable(
                "dbo.ObjectTypes",
                c => new
                    {
                        object_type_id = c.Int(nullable: false, identity: true),
                        object_type1 = c.String(),
                        quantity_of_object = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.object_type_id);
            
            CreateTable(
                "dbo.templates",
                c => new
                    {
                        template_id = c.Int(nullable: false, identity: true),
                        template_name = c.String(),
                    })
                .PrimaryKey(t => t.template_id);
            
            CreateTable(
                "dbo.Fields",
                c => new
                    {
                        field_id = c.Int(nullable: false, identity: true),
                        field_name = c.String(),
                        field_type = c.String(),
                        field_desc = c.String(),
                        template_template_id = c.Int(),
                    })
                .PrimaryKey(t => t.field_id)
                .ForeignKey("dbo.templates", t => t.template_template_id)
                .Index(t => t.template_template_id);
            
            CreateTable(
                "dbo.FieldOptions",
                c => new
                    {
                        field_option_id = c.Int(nullable: false, identity: true),
                        field_option_name = c.String(),
                        field_field_id = c.Int(),
                    })
                .PrimaryKey(t => t.field_option_id)
                .ForeignKey("dbo.Fields", t => t.field_field_id)
                .Index(t => t.field_field_id);
            
            CreateTable(
                "dbo.FieldResults",
                c => new
                    {
                        field_result_id = c.Int(nullable: false, identity: true),
                        result = c.String(),
                        booking_booking_id = c.Int(),
                        field_field_id = c.Int(),
                    })
                .PrimaryKey(t => t.field_result_id)
                .ForeignKey("dbo.Bookings", t => t.booking_booking_id)
                .ForeignKey("dbo.Fields", t => t.field_field_id)
                .Index(t => t.booking_booking_id)
                .Index(t => t.field_field_id);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        department_id = c.Int(nullable: false, identity: true),
                        department_name = c.String(),
                        organization_type_organization_type_id = c.Int(),
                    })
                .PrimaryKey(t => t.department_id)
                .ForeignKey("dbo.OrganizationTypes", t => t.organization_type_organization_type_id)
                .Index(t => t.organization_type_organization_type_id);
            
            CreateTable(
                "dbo.OrganizationTypes",
                c => new
                    {
                        organization_type_id = c.Int(nullable: false, identity: true),
                        organization_type_name = c.String(),
                    })
                .PrimaryKey(t => t.organization_type_id);
            
            CreateTable(
                "dbo.Organizations",
                c => new
                    {
                        organization_id = c.Int(nullable: false, identity: true),
                        organization_name = c.String(),
                        organization_type_organization_type_id = c.Int(),
                    })
                .PrimaryKey(t => t.organization_id)
                .ForeignKey("dbo.OrganizationTypes", t => t.organization_type_organization_type_id)
                .Index(t => t.organization_type_organization_type_id);
            
            CreateTable(
                "dbo.service_cost",
                c => new
                    {
                        service_cost_id = c.Int(nullable: false, identity: true),
                        additional_level = c.String(),
                        service_id = c.Int(nullable: false),
                        service_type = c.String(),
                        total_cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        user_cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        department_department_id = c.Int(),
                        organization_organization_id = c.Int(),
                    })
                .PrimaryKey(t => t.service_cost_id)
                .ForeignKey("dbo.Departments", t => t.department_department_id)
                .ForeignKey("dbo.Organizations", t => t.organization_organization_id)
                .Index(t => t.department_department_id)
                .Index(t => t.organization_organization_id);
            
            CreateTable(
                "dbo.users",
                c => new
                    {
                        user_id = c.Int(nullable: false, identity: true),
                        first_name = c.String(),
                        last_name = c.String(),
                        email = c.String(),
                        work_number = c.Int(),
                        mobile_number = c.Int(nullable: false),
                        id_number = c.Int(),
                        password = c.String(),
                        department_department_id = c.Int(),
                        organization_organization_id = c.Int(),
                        position_position_id = c.Int(),
                        userGender_Id = c.Int(),
                    })
                .PrimaryKey(t => t.user_id)
                .ForeignKey("dbo.Departments", t => t.department_department_id)
                .ForeignKey("dbo.Organizations", t => t.organization_organization_id)
                .ForeignKey("dbo.Positions", t => t.position_position_id)
                .ForeignKey("dbo.Genders", t => t.userGender_Id)
                .Index(t => t.department_department_id)
                .Index(t => t.organization_organization_id)
                .Index(t => t.position_position_id)
                .Index(t => t.userGender_Id);
            
            CreateTable(
                "dbo.Positions",
                c => new
                    {
                        position_id = c.Int(nullable: false, identity: true),
                        position_name = c.String(),
                    })
                .PrimaryKey(t => t.position_id);
            
            CreateTable(
                "dbo.user_group",
                c => new
                    {
                        user_group_id = c.Int(nullable: false, identity: true),
                        group_group_id = c.Int(),
                        user_user_id = c.Int(),
                    })
                .PrimaryKey(t => t.user_group_id)
                .ForeignKey("dbo.Groups", t => t.group_group_id)
                .ForeignKey("dbo.users", t => t.user_user_id)
                .Index(t => t.group_group_id)
                .Index(t => t.user_user_id);
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        group_id = c.Int(nullable: false, identity: true),
                        group_name = c.String(),
                    })
                .PrimaryKey(t => t.group_id);
            
            CreateTable(
                "dbo.GroupOperations",
                c => new
                    {
                        group_operation_id = c.Int(nullable: false, identity: true),
                        group_group_id = c.Int(),
                        operation_operation_id = c.Int(),
                    })
                .PrimaryKey(t => t.group_operation_id)
                .ForeignKey("dbo.Groups", t => t.group_group_id)
                .ForeignKey("dbo.Operations", t => t.operation_operation_id)
                .Index(t => t.group_group_id)
                .Index(t => t.operation_operation_id);
            
            CreateTable(
                "dbo.Operations",
                c => new
                    {
                        operation_id = c.Int(nullable: false, identity: true),
                        operation_name = c.String(),
                        form_form_id = c.Int(),
                    })
                .PrimaryKey(t => t.operation_id)
                .ForeignKey("dbo.Forms", t => t.form_form_id)
                .Index(t => t.form_form_id);
            
            CreateTable(
                "dbo.Forms",
                c => new
                    {
                        form_id = c.Int(nullable: false, identity: true),
                        form_name = c.String(),
                    })
                .PrimaryKey(t => t.form_id);
            
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MyGender = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ParticipantLevels",
                c => new
                    {
                        participant_level_id = c.Int(nullable: false, identity: true),
                        participant_type = c.String(),
                        participant_level_name = c.String(),
                    })
                .PrimaryKey(t => t.participant_level_id);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        eventName = c.String(),
                        eventDescription = c.String(),
                        imagePath = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Facilities",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FaName = c.String(),
                        FaDescription = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bookings", "participant_level_participant_level_id", "dbo.ParticipantLevels");
            DropForeignKey("dbo.users", "userGender_Id", "dbo.Genders");
            DropForeignKey("dbo.user_group", "user_user_id", "dbo.users");
            DropForeignKey("dbo.user_group", "group_group_id", "dbo.Groups");
            DropForeignKey("dbo.GroupOperations", "operation_operation_id", "dbo.Operations");
            DropForeignKey("dbo.Operations", "form_form_id", "dbo.Forms");
            DropForeignKey("dbo.GroupOperations", "group_group_id", "dbo.Groups");
            DropForeignKey("dbo.users", "position_position_id", "dbo.Positions");
            DropForeignKey("dbo.users", "organization_organization_id", "dbo.Organizations");
            DropForeignKey("dbo.users", "department_department_id", "dbo.Departments");
            DropForeignKey("dbo.Bookings", "user_user_id", "dbo.users");
            DropForeignKey("dbo.BookingUsers", "user_user_id", "dbo.users");
            DropForeignKey("dbo.service_cost", "organization_organization_id", "dbo.Organizations");
            DropForeignKey("dbo.service_cost", "department_department_id", "dbo.Departments");
            DropForeignKey("dbo.Organizations", "organization_type_organization_type_id", "dbo.OrganizationTypes");
            DropForeignKey("dbo.Bookings", "organization_organization_id", "dbo.Organizations");
            DropForeignKey("dbo.Departments", "organization_type_organization_type_id", "dbo.OrganizationTypes");
            DropForeignKey("dbo.Bookings", "department_department_id", "dbo.Departments");
            DropForeignKey("dbo.Objectts", "template_template_id", "dbo.templates");
            DropForeignKey("dbo.Fields", "template_template_id", "dbo.templates");
            DropForeignKey("dbo.FieldResults", "field_field_id", "dbo.Fields");
            DropForeignKey("dbo.FieldResults", "booking_booking_id", "dbo.Bookings");
            DropForeignKey("dbo.FieldOptions", "field_field_id", "dbo.Fields");
            DropForeignKey("dbo.Objectts", "object_type_object_type_id", "dbo.ObjectTypes");
            DropForeignKey("dbo.properties", "property_type_property_type_id", "dbo.property_type");
            DropForeignKey("dbo.ObjectProperties", "property_property_id", "dbo.properties");
            DropForeignKey("dbo.ObjectProperties", "objectt_object_id", "dbo.Objectts");
            DropForeignKey("dbo.BookingObjects", "objectt_object_id", "dbo.Objectts");
            DropForeignKey("dbo.BookingObjects", "booking_booking_id", "dbo.Bookings");
            DropForeignKey("dbo.BookingUsers", "booking_booking_id", "dbo.Bookings");
            DropIndex("dbo.Operations", new[] { "form_form_id" });
            DropIndex("dbo.GroupOperations", new[] { "operation_operation_id" });
            DropIndex("dbo.GroupOperations", new[] { "group_group_id" });
            DropIndex("dbo.user_group", new[] { "user_user_id" });
            DropIndex("dbo.user_group", new[] { "group_group_id" });
            DropIndex("dbo.users", new[] { "userGender_Id" });
            DropIndex("dbo.users", new[] { "position_position_id" });
            DropIndex("dbo.users", new[] { "organization_organization_id" });
            DropIndex("dbo.users", new[] { "department_department_id" });
            DropIndex("dbo.service_cost", new[] { "organization_organization_id" });
            DropIndex("dbo.service_cost", new[] { "department_department_id" });
            DropIndex("dbo.Organizations", new[] { "organization_type_organization_type_id" });
            DropIndex("dbo.Departments", new[] { "organization_type_organization_type_id" });
            DropIndex("dbo.FieldResults", new[] { "field_field_id" });
            DropIndex("dbo.FieldResults", new[] { "booking_booking_id" });
            DropIndex("dbo.FieldOptions", new[] { "field_field_id" });
            DropIndex("dbo.Fields", new[] { "template_template_id" });
            DropIndex("dbo.properties", new[] { "property_type_property_type_id" });
            DropIndex("dbo.ObjectProperties", new[] { "property_property_id" });
            DropIndex("dbo.ObjectProperties", new[] { "objectt_object_id" });
            DropIndex("dbo.Objectts", new[] { "template_template_id" });
            DropIndex("dbo.Objectts", new[] { "object_type_object_type_id" });
            DropIndex("dbo.BookingObjects", new[] { "objectt_object_id" });
            DropIndex("dbo.BookingObjects", new[] { "booking_booking_id" });
            DropIndex("dbo.Bookings", new[] { "participant_level_participant_level_id" });
            DropIndex("dbo.Bookings", new[] { "user_user_id" });
            DropIndex("dbo.Bookings", new[] { "organization_organization_id" });
            DropIndex("dbo.Bookings", new[] { "department_department_id" });
            DropIndex("dbo.BookingUsers", new[] { "user_user_id" });
            DropIndex("dbo.BookingUsers", new[] { "booking_booking_id" });
            DropTable("dbo.Facilities");
            DropTable("dbo.Events");
            DropTable("dbo.ParticipantLevels");
            DropTable("dbo.Genders");
            DropTable("dbo.Forms");
            DropTable("dbo.Operations");
            DropTable("dbo.GroupOperations");
            DropTable("dbo.Groups");
            DropTable("dbo.user_group");
            DropTable("dbo.Positions");
            DropTable("dbo.users");
            DropTable("dbo.service_cost");
            DropTable("dbo.Organizations");
            DropTable("dbo.OrganizationTypes");
            DropTable("dbo.Departments");
            DropTable("dbo.FieldResults");
            DropTable("dbo.FieldOptions");
            DropTable("dbo.Fields");
            DropTable("dbo.templates");
            DropTable("dbo.ObjectTypes");
            DropTable("dbo.property_type");
            DropTable("dbo.properties");
            DropTable("dbo.ObjectProperties");
            DropTable("dbo.Objectts");
            DropTable("dbo.BookingObjects");
            DropTable("dbo.Bookings");
            DropTable("dbo.BookingUsers");
            DropTable("dbo.additional_service");
        }
    }
}
