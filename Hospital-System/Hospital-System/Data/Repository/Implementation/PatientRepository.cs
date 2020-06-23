using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_System.Data.DbContext;
using Hospital_System.Data.Entity;

namespace Hospital_System.Data.Repository.Implementation
{
    public class PatientRepository: GenericRepository<Patient>, IPatientRepository
    {
        public PatientRepository(IHospitalSystemDbContext context) : base(context)
        {
        }
    }
}
