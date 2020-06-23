namespace Hospital_System.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Hospital_System.Data.DbContext.Implementation.HospitalSystemDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Hospital_System.Data.DbContext.Implementation.HospitalSystemDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            // if (context.AdminstrativeStaff.Any())
            // {
            //     return;
            // }
            // context.AdministrativeSta.Add
            // {
            //     Admin
            // }
        }
    }
}
