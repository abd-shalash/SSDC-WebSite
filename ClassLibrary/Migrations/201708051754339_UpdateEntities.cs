namespace ClassLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateEntities : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.booking_assigned_user", newName: "BookingUsers");
            RenameTable(name: "dbo.booking_object", newName: "BookingItems");
            RenameTable(name: "dbo.object_property", newName: "ObjectProperties");
            RenameTable(name: "dbo.property_type", newName: "PropertyTypes");
            RenameTable(name: "dbo.object_type", newName: "ObjectTypes");
            RenameTable(name: "dbo.field_option", newName: "FieldOptions");
            RenameTable(name: "dbo.field_result", newName: "FieldResults");
            RenameTable(name: "dbo.organization_type", newName: "OrganizationTypes");
            RenameTable(name: "dbo.service_cost", newName: "ServiceCosts");
            RenameTable(name: "dbo.user_group", newName: "UserGroups");
            RenameTable(name: "dbo.group_operation", newName: "GroupOperations");
            RenameTable(name: "dbo.participant_level", newName: "ParticipantLevels");
            DropForeignKey("dbo.booking_assigned_user", "booking_booking_id", "dbo.bookings");
            DropForeignKey("dbo.booking_object", "booking_booking_id", "dbo.bookings");
            DropForeignKey("dbo.field_result", "booking_booking_id", "dbo.bookings");
            DropIndex("dbo.Bookings", new[] { "department_department_id" });
            DropIndex("dbo.Bookings", new[] { "organization_organization_id" });
            DropIndex("dbo.Bookings", new[] { "user_user_id" });
            DropIndex("dbo.Bookings", new[] { "participant_level_participant_level_id" });
            RenameColumn(table: "dbo.BookingUsers", name: "booking_booking_id", newName: "booking_Id");
            RenameColumn(table: "dbo.BookingItems", name: "booking_booking_id", newName: "booking_Id");
            RenameColumn(table: "dbo.FieldResults", name: "booking_booking_id", newName: "booking_Id");
            RenameIndex(table: "dbo.BookingItems", name: "IX_booking_booking_id", newName: "IX_booking_Id");
            RenameIndex(table: "dbo.BookingUsers", name: "IX_booking_booking_id", newName: "IX_booking_Id");
            RenameIndex(table: "dbo.FieldResults", name: "IX_booking_booking_id", newName: "IX_booking_Id");
            DropPrimaryKey("dbo.Bookings");
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        Service_Id = c.Int(nullable: false, identity: true),
                        Service_Name = c.String(),
                    })
                .PrimaryKey(t => t.Service_Id);
            
            AddColumn("dbo.Bookings", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Bookings", "Participants_Number", c => c.Int(nullable: false));
            AddColumn("dbo.Bookings", "Code_Number", c => c.String());
            AddColumn("dbo.Bookings", "Note", c => c.String());
            AddColumn("dbo.Bookings", "Staff_Need", c => c.Boolean(nullable: false));
            AddPrimaryKey("dbo.Bookings", "Id");
            CreateIndex("dbo.Bookings", "User_user_id");
            CreateIndex("dbo.Bookings", "Department_department_id");
            CreateIndex("dbo.Bookings", "Organization_organization_id");
            CreateIndex("dbo.Bookings", "Participant_Level_participant_level_id");
            AddForeignKey("dbo.BookingItems", "booking_Id", "dbo.Bookings", "Id");
            AddForeignKey("dbo.BookingUsers", "booking_Id", "dbo.Bookings", "Id");
            AddForeignKey("dbo.FieldResults", "booking_Id", "dbo.Bookings", "Id");
            DropColumn("dbo.Bookings", "booking_id");
            DropColumn("dbo.Bookings", "no_of_participant");
            DropColumn("dbo.Bookings", "code_no");
            DropColumn("dbo.Bookings", "notes");
            DropColumn("dbo.Bookings", "staff_needed");
            DropTable("dbo.additional_service");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.additional_service",
                c => new
                    {
                        additional_service_id = c.Int(nullable: false, identity: true),
                        additional_sevice_name = c.String(),
                    })
                .PrimaryKey(t => t.additional_service_id);
            
            AddColumn("dbo.Bookings", "staff_needed", c => c.String());
            AddColumn("dbo.Bookings", "notes", c => c.String());
            AddColumn("dbo.Bookings", "code_no", c => c.String());
            AddColumn("dbo.Bookings", "no_of_participant", c => c.Int(nullable: false));
            AddColumn("dbo.Bookings", "booking_id", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.FieldResults", "booking_Id", "dbo.Bookings");
            DropForeignKey("dbo.BookingUsers", "booking_Id", "dbo.Bookings");
            DropForeignKey("dbo.BookingItems", "booking_Id", "dbo.Bookings");
            DropIndex("dbo.Bookings", new[] { "Participant_Level_participant_level_id" });
            DropIndex("dbo.Bookings", new[] { "Organization_organization_id" });
            DropIndex("dbo.Bookings", new[] { "Department_department_id" });
            DropIndex("dbo.Bookings", new[] { "User_user_id" });
            DropPrimaryKey("dbo.Bookings");
            DropColumn("dbo.Bookings", "Staff_Need");
            DropColumn("dbo.Bookings", "Note");
            DropColumn("dbo.Bookings", "Code_Number");
            DropColumn("dbo.Bookings", "Participants_Number");
            DropColumn("dbo.Bookings", "Id");
            DropTable("dbo.Services");
            AddPrimaryKey("dbo.Bookings", "booking_id");
            RenameIndex(table: "dbo.FieldResults", name: "IX_booking_Id", newName: "IX_booking_booking_id");
            RenameIndex(table: "dbo.BookingUsers", name: "IX_booking_Id", newName: "IX_booking_booking_id");
            RenameIndex(table: "dbo.BookingItems", name: "IX_booking_Id", newName: "IX_booking_booking_id");
            RenameColumn(table: "dbo.FieldResults", name: "booking_Id", newName: "booking_booking_id");
            RenameColumn(table: "dbo.BookingItems", name: "booking_Id", newName: "booking_booking_id");
            RenameColumn(table: "dbo.BookingUsers", name: "booking_Id", newName: "booking_booking_id");
            CreateIndex("dbo.Bookings", "participant_level_participant_level_id");
            CreateIndex("dbo.Bookings", "user_user_id");
            CreateIndex("dbo.Bookings", "organization_organization_id");
            CreateIndex("dbo.Bookings", "department_department_id");
            AddForeignKey("dbo.field_result", "booking_booking_id", "dbo.bookings", "booking_id");
            AddForeignKey("dbo.booking_object", "booking_booking_id", "dbo.bookings", "booking_id");
            AddForeignKey("dbo.booking_assigned_user", "booking_booking_id", "dbo.bookings", "booking_id");
            RenameTable(name: "dbo.ParticipantLevels", newName: "participant_level");
            RenameTable(name: "dbo.GroupOperations", newName: "group_operation");
            RenameTable(name: "dbo.UserGroups", newName: "user_group");
            RenameTable(name: "dbo.ServiceCosts", newName: "service_cost");
            RenameTable(name: "dbo.OrganizationTypes", newName: "organization_type");
            RenameTable(name: "dbo.FieldResults", newName: "field_result");
            RenameTable(name: "dbo.FieldOptions", newName: "field_option");
            RenameTable(name: "dbo.ObjectTypes", newName: "object_type");
            RenameTable(name: "dbo.PropertyTypes", newName: "property_type");
            RenameTable(name: "dbo.ObjectProperties", newName: "object_property");
            RenameTable(name: "dbo.BookingItems", newName: "booking_object");
            RenameTable(name: "dbo.BookingUsers", newName: "booking_assigned_user");
        }
    }
}
