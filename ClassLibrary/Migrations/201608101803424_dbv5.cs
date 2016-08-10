namespace ClassLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbv5 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.bookings", "user_user_id", "dbo.users");
            DropForeignKey("dbo.users", "UserGroup_group_id", "dbo.groups");
            DropIndex("dbo.bookings", new[] { "user_user_id1" });
            DropIndex("dbo.bookings", new[] { "booking_assigned_user_user_id" });
            DropIndex("dbo.bookings", new[] { "user_user_id2" });
            DropIndex("dbo.users", new[] { "UserGroup_group_id" });
        //    DropColumn("dbo.booking_assigned_user", "booking_booking_id");
            DropColumn("dbo.bookings", "user_user_id");
            DropColumn("dbo.bookings", "user_user_id");
         //   RenameColumn(table: "dbo.booking_assigned_user", name: "booking_assigned_user_user_id", newName: "booking_booking_id");
            RenameColumn(table: "dbo.bookings", name: "user_user_id2", newName: "user_user_id");
            RenameColumn(table: "dbo.bookings", name: "user_user_id1", newName: "user_user_id");
            DropColumn("dbo.bookings", "booking_assigned_user_user_id");
            DropColumn("dbo.users", "UserGroup_group_id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.users", "UserGroup_group_id", c => c.Int());
            AddColumn("dbo.bookings", "booking_assigned_user_user_id", c => c.Int());
            RenameColumn(table: "dbo.bookings", name: "user_user_id", newName: "user_user_id1");
            RenameColumn(table: "dbo.bookings", name: "user_user_id", newName: "user_user_id2");
     //       RenameColumn(table: "dbo.booking_assigned_user", name: "booking_booking_id", newName: "booking_assigned_user_user_id");
            AddColumn("dbo.bookings", "user_user_id", c => c.Int());
            AddColumn("dbo.bookings", "user_user_id", c => c.Int());
         //   AddColumn("dbo.booking_assigned_user", "booking_booking_id", c => c.Int());
            CreateIndex("dbo.users", "UserGroup_group_id");
            CreateIndex("dbo.bookings", "user_user_id2");
            CreateIndex("dbo.bookings", "booking_assigned_user_user_id");
            CreateIndex("dbo.bookings", "user_user_id1");
            AddForeignKey("dbo.users", "UserGroup_group_id", "dbo.groups", "group_id");
            AddForeignKey("dbo.bookings", "user_user_id", "dbo.users", "user_id");
        }
    }
}
