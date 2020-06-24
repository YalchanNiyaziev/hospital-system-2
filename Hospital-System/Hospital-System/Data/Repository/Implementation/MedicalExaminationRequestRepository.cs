using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_System.Data.DbContext;
using Hospital_System.Data.DbContext.Implementation;
using Hospital_System.Data.Entity;

namespace Hospital_System.Data.Repository.Implementation
{
    public class MedicalExaminationRequestRepository :GenericRepository<MedicalExaminationRequest>, IMedicalExaminationRequestRepository
    {
        private IHospitalSystemDbContext context;

        public MedicalExaminationRequestRepository(IHospitalSystemDbContext context) : base(context)
        {
            this.context = context;
        }

        public List<MedicalExaminationRequest> FindByDoctor(int doctorId)
        {
           

            List<MedicalExaminationRequest> examinationRequests
                = context.Set<MedicalExaminationRequest>()
                    .Include(e => e.Patient)
                    .Where(e => e.DoctorId == doctorId)
                    .Where(e=>e.Status==0).ToList();
         
            return examinationRequests;
        }

        public MedicalExaminationRequest FindById(int id)
        {

            MedicalExaminationRequest examinationRequest = context.Set<MedicalExaminationRequest>()
                .Include(e => e.Patient)
                .Include(e => e.Patient.Address)
                .Where(e => e.Id == id)
                .FirstOrDefault();

            return examinationRequest;

        }
    }
}
