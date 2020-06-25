using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_System.Data.DbContext;
using Hospital_System.Data.Entity;

namespace Hospital_System.Data.Repository.Implementation
{
    public class MedicalServiceRepository : GenericRepository<MedicalService>, IMedicalServiceRepository
    {
        private IHospitalSystemDbContext context;
        public MedicalServiceRepository(IHospitalSystemDbContext context) : base(context)
        {
            this.context = context;
        }

        public List<MedicalService> GetAllMedicalRecordsByPatientUcn(string ucn)
        {
            List<MedicalService> resultList = context.MedicalServices
                .Include(s => s.Doctor)
                .Include(s => s.Patient)
                .Where(s => s.Patient.Ucn.Equals(ucn))
                .ToList();
            return resultList;
        }
    }
}
