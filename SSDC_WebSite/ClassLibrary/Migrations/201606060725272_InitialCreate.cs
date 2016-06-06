namespace ClassLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    EvName = c.String(),
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
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Password = c.String(),
                        Fname = c.String(),
                        Mname = c.String(),
                        Lname = c.String(),
                        Username = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.People");
            DropTable("dbo.Facilities");
            DropTable("dbo.Events");
        }
    }
}
