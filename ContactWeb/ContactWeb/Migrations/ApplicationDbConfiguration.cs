namespace ContactWeb.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class ApplicationDbConfiguration : DbMigrationsConfiguration<ContactWeb.Models.ApplicationDbContext>
    {
        public ApplicationDbConfiguration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ContactWeb.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
