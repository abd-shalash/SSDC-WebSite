namespace ClassLibrary.Migrations
{
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
            AutomaticMigrationsEnabled = true;
            ContextKey = "ClassLibrary.Concrate.EF_DBContext";
        }

        protected override void Seed(ClassLibrary.Concrate.EF_DBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            var organizationType = new List<organization_type>
        {
            new organization_type {organization_type_id=1,organization_type_name="test org 1" }
        };
            organizationType.ForEach(o => context.organization_types.Add(o));
            context.SaveChanges();
            var organizations = new List<organization>
            {
                new organization {organization_id=1, organization_name="alfaisal",organization_type=context.organization_types.FirstOrDefault(p=>p.organization_type_id==1), }
            };
            organizations.ForEach(o => context.organizations.Add(o));
            var objects = new List<objectt>
            {

            };
            context.SaveChanges();
        }
    }
}
