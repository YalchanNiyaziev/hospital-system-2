using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_System.Data.DbContext.Implementation;
using Hospital_System.Data.Entity;

namespace Hospital_System.Data.Repository.Implementation
{
    public class DoctorRepository : GenericRepository<Doctor>, IDoctorRepository
    {
        public DoctorRepository() : base(new HospitalSystemDbContext())
        {
        }
    }
}
