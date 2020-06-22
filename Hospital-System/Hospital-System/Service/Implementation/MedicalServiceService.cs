using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_System.View.Model;

namespace Hospital_System.Service.Implementation
{
    class MedicalServiceService : IMedicalServiceSevice
    {
        public List<PatientMedicalServiceModel> GetMedicalServicesByPatient(string UCN)
        {
            List<PatientMedicalServiceModel> modelList = new List<PatientMedicalServiceModel>();
            modelList.Add(new PatientMedicalServiceModel
            {
                Date = DateTime.Now.ToString(),
                Description = "Big Operation With Big complexity",
                Doctor = "Ivan Petrov",
                Type = "Operation"
            });
            modelList.Add(new PatientMedicalServiceModel
            {
                Date = DateTime.Now.ToString(),
                Description = "Big Operation With Big complexity llalalala",
                Doctor = "Ivan Petrov",
                Type = "Examination"
            });
            modelList.Add(new PatientMedicalServiceModel
            {
                Date = DateTime.Now.ToString(),
                Description = "Big",
                Doctor = "Maria",
                Type = "Examination"
            });
            modelList.Add(new PatientMedicalServiceModel
            {
                Date = DateTime.Now.ToString(),
                Description = "Big Operation With Big complexity",
                Doctor = "Ivan Petrov",
                Type = "Operation"
            });
            modelList.Add(new PatientMedicalServiceModel
            {
                Date = DateTime.Now.ToString(),
                Description = "Big Operation With Big complexity llalalala",
                Doctor = "Ivan Petrov",
                Type = "Examination"
            });
            modelList.Add(new PatientMedicalServiceModel
            {
                Date = DateTime.Now.ToString(),
                Description = "Big",
                Doctor = "Maria",
                Type = "Examination"
            });
            modelList.Add(new PatientMedicalServiceModel
            {
                Date = DateTime.Now.ToString(),
                Description = "Big Operation With Big complexity",
                Doctor = "Ivan Petrov",
                Type = "Operation"
            });
            modelList.Add(new PatientMedicalServiceModel
            {
                Date = DateTime.Now.ToString(),
                Description = "Big Operation With Big complexity llalalala",
                Doctor = "Ivan Petrov",
                Type = "Examination"
            });
            modelList.Add(new PatientMedicalServiceModel
            {
                Date = DateTime.Now.ToString(),
                Description = "Big",
                Doctor = "Maria",
                Type = "Examination"
            });
            modelList.Add(new PatientMedicalServiceModel
            {
                Date = DateTime.Now.ToString(),
                Description = "Big Operation With Big complexity",
                Doctor = "Ivan Petrov",
                Type = "Operation"
            });
            modelList.Add(new PatientMedicalServiceModel
            {
                Date = DateTime.Now.ToString(),
                Description = "Big Operation With Big complexity llalalala",
                Doctor = "Ivan Petrov",
                Type = "Examination"
            });
            modelList.Add(new PatientMedicalServiceModel
            {
                Date = DateTime.Now.ToString(),
                Description = "Big",
                Doctor = "Maria",
                Type = "Examination"
            });
            return modelList;
        }
    }
}
