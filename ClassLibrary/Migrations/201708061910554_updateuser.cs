namespace ClassLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateuser : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.users", "position_position_id", "dbo.Positions");
            DropIndex("dbo.users", new[] { "position_position_id" });
            RenameColumn(table: "dbo.users", name: "position_position_id", newName: "position_id");
            AlterColumn("dbo.users", "position_id", c => c.Int(nullable: false));
            CreateIndex("dbo.users", "position_id");
            AddForeignKey("dbo.users", "position_id", "dbo.Positions", "position_id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.users", "position_id", "dbo.Positions");
            DropIndex("dbo.users", new[] { "position_id" });
            AlterColumn("dbo.users", "position_id", c => c.Int());
            RenameColumn(table: "dbo.users", name: "position_id", newName: "position_position_id");
            CreateIndex("dbo.users", "position_position_id");
            AddForeignKey("dbo.users", "position_position_id", "dbo.Positions", "position_id");
        }
    }
}
