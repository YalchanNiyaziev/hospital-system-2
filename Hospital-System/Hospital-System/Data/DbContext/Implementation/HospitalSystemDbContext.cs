using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_System.Data.Entity;
using Hospital_System.Migrations;

// using Hospital_System.Data.Migrations;

namespace Hospital_System.Data.DbContext.Implementation
{
    public class HospitalSystemDbContext : System.Data.Entity.DbContext, IHospitalSystemDbContext
    {
        public HospitalSystemDbContext() : base("HospitalSystemDB")
        {
            Database.SetInitializer<HospitalSystemDbContext>(new MigrateDatabaseToLatestVersion<HospitalSystemDbContext, Configuration>());
            // Database.Initialize(true);
        }

        public DbSet<Person> People { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<MedicalService> MedicalServices { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<MedicalExaminationRequest> MedicalExaminationRequests { get; set; }

        public new DbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }

        public new void SaveChanges()
        {
            base.SaveChanges();
        }

        // public new DbEntityEntry<T> Entry<T>(T entity) where T : class
        // {
        //     return base.Entry(entity);
        // }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
          
        }
    }
}
