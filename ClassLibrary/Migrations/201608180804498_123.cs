namespace ClassLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _123 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MyGender = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.users", "userGender_Id", c => c.Int());
            AddColumn("dbo.Events", "imagePath", c => c.String());
            CreateIndex("dbo.users", "userGender_Id");
            AddForeignKey("dbo.users", "userGender_Id", "dbo.Genders", "Id");
            DropColumn("dbo.users", "gender");
        }
        
        public override void Down()
        {
            AddColumn("dbo.users", "gender", c => c.Int(nullable: false));
            DropForeignKey("dbo.users", "userGender_Id", "dbo.Genders");
            DropIndex("dbo.users", new[] { "userGender_Id" });
            DropColumn("dbo.Events", "imagePath");
            DropColumn("dbo.users", "userGender_Id");
            DropTable("dbo.Genders");
        }
    }
}
