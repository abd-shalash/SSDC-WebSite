namespace ClassLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
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
                "dbo.booking_assigned_user",
                c => new
                    {
                        booking_assigned_user_id = c.Int(nullable: false, identity: true),
                        booking_booking_id = c.Int(),
                        user_user_id = c.Int(),
                    })
                .PrimaryKey(t => t.booking_assigned_user_id)
                .ForeignKey("dbo.bookings", t => t.booking_booking_id)
                .ForeignKey("dbo.users", t => t.user_user_id)
                .Index(t => t.booking_booking_id)
                .Index(t => t.user_user_id);
            
            CreateTable(
                "dbo.bookings",
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
                .ForeignKey("dbo.departments", t => t.department_department_id)
                .ForeignKey("dbo.organizations", t => t.organization_organization_id)
                .ForeignKey("dbo.users", t => t.user_user_id)
                .ForeignKey("dbo.participant_level", t => t.participant_level_participant_level_id)
                .Index(t => t.department_department_id)
                .Index(t => t.organization_organization_id)
                .Index(t => t.user_user_id)
                .Index(t => t.participant_level_participant_level_id);
            
            CreateTable(
                "dbo.booking_object",
                c => new
                    {
                        booking_object_id = c.Int(nullable: false, identity: true),
                        booking_booking_id = c.Int(),
                        objectt_object_id = c.Int(),
                    })
                .PrimaryKey(t => t.booking_object_id)
                .ForeignKey("dbo.bookings", t => t.booking_booking_id)
                .ForeignKey("dbo.objectts", t => t.objectt_object_id)
                .Index(t => t.booking_booking_id)
                .Index(t => t.objectt_object_id);
            
            CreateTable(
                "dbo.objectts",
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
                .ForeignKey("dbo.object_type", t => t.object_type_object_type_id)
                .ForeignKey("dbo.templates", t => t.template_template_id)
                .Index(t => t.object_type_object_type_id)
                .Index(t => t.template_template_id);
            
            CreateTable(
                "dbo.object_property",
                c => new
                    {
                        object_property_id = c.Int(nullable: false, identity: true),
                        objectt_object_id = c.Int(),
                        property_property_id = c.Int(),
                    })
                .PrimaryKey(t => t.object_property_id)
                .ForeignKey("dbo.objectts", t => t.objectt_object_id)
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
                    })
                .PrimaryKey(t => t.property_type_id);
            
            CreateTable(
                "dbo.object_type",
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
                "dbo.fields",
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
                "dbo.field_option",
                c => new
                    {
                        field_option_id = c.Int(nullable: false, identity: true),
                        field_option_name = c.String(),
                        field_field_id = c.Int(),
                    })
                .PrimaryKey(t => t.field_option_id)
                .ForeignKey("dbo.fields", t => t.field_field_id)
                .Index(t => t.field_field_id);
            
            CreateTable(
                "dbo.field_result",
                c => new
                    {
                        field_result_id = c.Int(nullable: false, identity: true),
                        result = c.String(),
                        booking_booking_id = c.Int(),
                        field_field_id = c.Int(),
                    })
                .PrimaryKey(t => t.field_result_id)
                .ForeignKey("dbo.bookings", t => t.booking_booking_id)
                .ForeignKey("dbo.fields", t => t.field_field_id)
                .Index(t => t.booking_booking_id)
                .Index(t => t.field_field_id);
            
            CreateTable(
                "dbo.departments",
                c => new
                    {
                        department_id = c.Int(nullable: false, identity: true),
                        department_name = c.String(),
                        organization_type_organization_type_id = c.Int(),
                    })
                .PrimaryKey(t => t.department_id)
                .ForeignKey("dbo.organization_type", t => t.organization_type_organization_type_id)
                .Index(t => t.organization_type_organization_type_id);
            
            CreateTable(
                "dbo.organization_type",
                c => new
                    {
                        organization_type_id = c.Int(nullable: false, identity: true),
                        organization_type_name = c.String(),
                    })
                .PrimaryKey(t => t.organization_type_id);
            
            CreateTable(
                "dbo.organizations",
                c => new
                    {
                        organization_id = c.Int(nullable: false, identity: true),
                        organization_name = c.String(),
                        organization_type_organization_type_id = c.Int(),
                    })
                .PrimaryKey(t => t.organization_id)
                .ForeignKey("dbo.organization_type", t => t.organization_type_organization_type_id)
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
                .ForeignKey("dbo.departments", t => t.department_department_id)
                .ForeignKey("dbo.organizations", t => t.organization_organization_id)
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
                        gender = c.Int(nullable: false),
                        id_number = c.Int(),
                        password = c.String(),
                        department_department_id = c.Int(),
                        organization_organization_id = c.Int(),
                        position_position_id = c.Int(),
                    })
                .PrimaryKey(t => t.user_id)
                .ForeignKey("dbo.departments", t => t.department_department_id)
                .ForeignKey("dbo.organizations", t => t.organization_organization_id)
                .ForeignKey("dbo.positions", t => t.position_position_id)
                .Index(t => t.department_department_id)
                .Index(t => t.organization_organization_id)
                .Index(t => t.position_position_id);
            
            CreateTable(
                "dbo.positions",
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
                .ForeignKey("dbo.groups", t => t.group_group_id)
                .ForeignKey("dbo.users", t => t.user_user_id)
                .Index(t => t.group_group_id)
                .Index(t => t.user_user_id);
            
            CreateTable(
                "dbo.groups",
                c => new
                    {
                        group_id = c.Int(nullable: false, identity: true),
                        group_name = c.String(),
                    })
                .PrimaryKey(t => t.group_id);
            
            CreateTable(
                "dbo.group_operation",
                c => new
                    {
                        group_operation_id = c.Int(nullable: false, identity: true),
                        group_group_id = c.Int(),
                        operation_operation_id = c.Int(),
                    })
                .PrimaryKey(t => t.group_operation_id)
                .ForeignKey("dbo.groups", t => t.group_group_id)
                .ForeignKey("dbo.operations", t => t.operation_operation_id)
                .Index(t => t.group_group_id)
                .Index(t => t.operation_operation_id);
            
            CreateTable(
                "dbo.operations",
                c => new
                    {
                        operation_id = c.Int(nullable: false, identity: true),
                        operation_name = c.String(),
                        form_form_id = c.Int(),
                    })
                .PrimaryKey(t => t.operation_id)
                .ForeignKey("dbo.forms", t => t.form_form_id)
                .Index(t => t.form_form_id);
            
            CreateTable(
                "dbo.forms",
                c => new
                    {
                        form_id = c.Int(nullable: false, identity: true),
                        form_name = c.String(),
                    })
                .PrimaryKey(t => t.form_id);
            
            CreateTable(
                "dbo.participant_level",
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
            DropForeignKey("dbo.bookings", "participant_level_participant_level_id", "dbo.participant_level");
            DropForeignKey("dbo.user_group", "user_user_id", "dbo.users");
            DropForeignKey("dbo.user_group", "group_group_id", "dbo.groups");
            DropForeignKey("dbo.group_operation", "operation_operation_id", "dbo.operations");
            DropForeignKey("dbo.operations", "form_form_id", "dbo.forms");
            DropForeignKey("dbo.group_operation", "group_group_id", "dbo.groups");
            DropForeignKey("dbo.users", "position_position_id", "dbo.positions");
            DropForeignKey("dbo.users", "organization_organization_id", "dbo.organizations");
            DropForeignKey("dbo.users", "department_department_id", "dbo.departments");
            DropForeignKey("dbo.bookings", "user_user_id", "dbo.users");
            DropForeignKey("dbo.booking_assigned_user", "user_user_id", "dbo.users");
            DropForeignKey("dbo.service_cost", "organization_organization_id", "dbo.organizations");
            DropForeignKey("dbo.service_cost", "department_department_id", "dbo.departments");
            DropForeignKey("dbo.organizations", "organization_type_organization_type_id", "dbo.organization_type");
            DropForeignKey("dbo.bookings", "organization_organization_id", "dbo.organizations");
            DropForeignKey("dbo.departments", "organization_type_organization_type_id", "dbo.organization_type");
            DropForeignKey("dbo.bookings", "department_department_id", "dbo.departments");
            DropForeignKey("dbo.objectts", "template_template_id", "dbo.templates");
            DropForeignKey("dbo.fields", "template_template_id", "dbo.templates");
            DropForeignKey("dbo.field_result", "field_field_id", "dbo.fields");
            DropForeignKey("dbo.field_result", "booking_booking_id", "dbo.bookings");
            DropForeignKey("dbo.field_option", "field_field_id", "dbo.fields");
            DropForeignKey("dbo.objectts", "object_type_object_type_id", "dbo.object_type");
            DropForeignKey("dbo.properties", "property_type_property_type_id", "dbo.property_type");
            DropForeignKey("dbo.object_property", "property_property_id", "dbo.properties");
            DropForeignKey("dbo.object_property", "objectt_object_id", "dbo.objectts");
            DropForeignKey("dbo.booking_object", "objectt_object_id", "dbo.objectts");
            DropForeignKey("dbo.booking_object", "booking_booking_id", "dbo.bookings");
            DropForeignKey("dbo.booking_assigned_user", "booking_booking_id", "dbo.bookings");
            DropIndex("dbo.operations", new[] { "form_form_id" });
            DropIndex("dbo.group_operation", new[] { "operation_operation_id" });
            DropIndex("dbo.group_operation", new[] { "group_group_id" });
            DropIndex("dbo.user_group", new[] { "user_user_id" });
            DropIndex("dbo.user_group", new[] { "group_group_id" });
            DropIndex("dbo.users", new[] { "position_position_id" });
            DropIndex("dbo.users", new[] { "organization_organization_id" });
            DropIndex("dbo.users", new[] { "department_department_id" });
            DropIndex("dbo.service_cost", new[] { "organization_organization_id" });
            DropIndex("dbo.service_cost", new[] { "department_department_id" });
            DropIndex("dbo.organizations", new[] { "organization_type_organization_type_id" });
            DropIndex("dbo.departments", new[] { "organization_type_organization_type_id" });
            DropIndex("dbo.field_result", new[] { "field_field_id" });
            DropIndex("dbo.field_result", new[] { "booking_booking_id" });
            DropIndex("dbo.field_option", new[] { "field_field_id" });
            DropIndex("dbo.fields", new[] { "template_template_id" });
            DropIndex("dbo.properties", new[] { "property_type_property_type_id" });
            DropIndex("dbo.object_property", new[] { "property_property_id" });
            DropIndex("dbo.object_property", new[] { "objectt_object_id" });
            DropIndex("dbo.objectts", new[] { "template_template_id" });
            DropIndex("dbo.objectts", new[] { "object_type_object_type_id" });
            DropIndex("dbo.booking_object", new[] { "objectt_object_id" });
            DropIndex("dbo.booking_object", new[] { "booking_booking_id" });
            DropIndex("dbo.bookings", new[] { "participant_level_participant_level_id" });
            DropIndex("dbo.bookings", new[] { "user_user_id" });
            DropIndex("dbo.bookings", new[] { "organization_organization_id" });
            DropIndex("dbo.bookings", new[] { "department_department_id" });
            DropIndex("dbo.booking_assigned_user", new[] { "user_user_id" });
            DropIndex("dbo.booking_assigned_user", new[] { "booking_booking_id" });
            DropTable("dbo.Facilities");
            DropTable("dbo.Events");
            DropTable("dbo.participant_level");
            DropTable("dbo.forms");
            DropTable("dbo.operations");
            DropTable("dbo.group_operation");
            DropTable("dbo.groups");
            DropTable("dbo.user_group");
            DropTable("dbo.positions");
            DropTable("dbo.users");
            DropTable("dbo.service_cost");
            DropTable("dbo.organizations");
            DropTable("dbo.organization_type");
            DropTable("dbo.departments");
            DropTable("dbo.field_result");
            DropTable("dbo.field_option");
            DropTable("dbo.fields");
            DropTable("dbo.templates");
            DropTable("dbo.object_type");
            DropTable("dbo.property_type");
            DropTable("dbo.properties");
            DropTable("dbo.object_property");
            DropTable("dbo.objectts");
            DropTable("dbo.booking_object");
            DropTable("dbo.bookings");
            DropTable("dbo.booking_assigned_user");
            DropTable("dbo.additional_service");
        }
    }
}
