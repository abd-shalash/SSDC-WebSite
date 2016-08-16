namespace ClassLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Nasser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "imagePath", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Events", "imagePath");
        }
    }
}
