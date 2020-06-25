using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_System.Data.Entity;

namespace Hospital_System.Data.Repository
{
    public interface IMedicalServiceRepository :IGenericRepository<MedicalService>
    {
        List<MedicalService> GetAllMedicalRecordsByPatientUcn(string ucn);
    }
}
