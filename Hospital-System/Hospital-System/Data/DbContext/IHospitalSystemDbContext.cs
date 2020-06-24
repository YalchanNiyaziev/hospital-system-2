using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_System.Data.Entity;

namespace Hospital_System.Data.DbContext
{
    public interface IHospitalSystemDbContext
    {
        DbSet<Person> People { get; set; }
        DbSet<Address> Addresses { get; set; }
        DbSet<Admin> Admins { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<Doctor> Doctors { get; set; }
        DbSet<MedicalService> MedicalServices { get; set; }
        DbSet<Patient> Patients { get; set; }
        DbSet<MedicalExaminationRequest> MedicalExaminationRequests { get; set; }
        DbSet<T> Set<T>() where T : class;
        DbEntityEntry<T> Entry<T>(T entity) where T : class;
        void SaveChanges();
    }
}
