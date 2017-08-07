namespace ClassLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.booking_assigned_user", newName: "BookingUsers");
            RenameTable(name: "dbo.booking_object", newName: "BookingObjects");
            RenameTable(name: "dbo.object_property", newName: "ObjectProperties");
            RenameTable(name: "dbo.object_type", newName: "ObjectTypes");
            RenameTable(name: "dbo.field_option", newName: "FieldOptions");
            RenameTable(name: "dbo.field_result", newName: "FieldResults");
            RenameTable(name: "dbo.organization_type", newName: "OrganizationTypes");
            RenameTable(name: "dbo.group_operation", newName: "GroupOperations");
            RenameTable(name: "dbo.participant_level", newName: "ParticipantLevels");
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MyGender = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.property_type", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.users", "userGender_Id", c => c.Int());
            CreateIndex("dbo.users", "userGender_Id");
            AddForeignKey("dbo.users", "userGender_Id", "dbo.Genders", "Id");
            DropColumn("dbo.users", "gender");
        }
        
        public override void Down()
        {
            AddColumn("dbo.users", "gender", c => c.Int(nullable: false));
            DropForeignKey("dbo.users", "userGender_Id", "dbo.Genders");
            DropIndex("dbo.users", new[] { "userGender_Id" });
            DropColumn("dbo.users", "userGender_Id");
            DropColumn("dbo.property_type", "Discriminator");
            DropTable("dbo.Genders");
            RenameTable(name: "dbo.ParticipantLevels", newName: "participant_level");
            RenameTable(name: "dbo.GroupOperations", newName: "group_operation");
            RenameTable(name: "dbo.OrganizationTypes", newName: "organization_type");
            RenameTable(name: "dbo.FieldResults", newName: "field_result");
            RenameTable(name: "dbo.FieldOptions", newName: "field_option");
            RenameTable(name: "dbo.ObjectTypes", newName: "object_type");
            RenameTable(name: "dbo.ObjectProperties", newName: "object_property");
            RenameTable(name: "dbo.BookingObjects", newName: "booking_object");
            RenameTable(name: "dbo.BookingUsers", newName: "booking_assigned_user");
        }
    }
}
