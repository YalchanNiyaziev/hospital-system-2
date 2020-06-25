using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_System.Data.DbContext.Implementation;
using Hospital_System.Data.Entity;
using Hospital_System.Data.Entity.Enums;
using Hospital_System.Data.Repository;
using Hospital_System.Data.Repository.Implementation;
using Hospital_System.View.Model;

namespace Hospital_System.Service.Implementation
{
    class MedicalServiceService : IMedicalServiceService
    {
        private IMedicalServiceRepository medicalServiceRepository;

        public MedicalServiceService()
        {
            this.medicalServiceRepository = new MedicalServiceRepository(new HospitalSystemDbContext());
        }

        public List<PatientMedicalServiceModel> GetMedicalServicesByPatient(string ucn)
        {
            List<PatientMedicalServiceModel> modelList = new List<PatientMedicalServiceModel>();
            List<MedicalService> medicalServiceList = medicalServiceRepository.GetAllMedicalRecordsByPatientUcn(ucn);
            foreach (var record in medicalServiceList)
            {
                PatientMedicalServiceModel model = new PatientMedicalServiceModel();
                model.Date = record.MedicalServiceDate.ToShortDateString();
                model.Doctor = record.Doctor.Name;
                if (record.MedicalServiceType==MedicalServiceType.Examination)
                {
                    model.Description = record.Disease + "\n" + record.MedicalOpinion;
                    model.Type = "Medical Examination";
                }
                else
                {
                    model.Description = record.OperationDescription + "\n" + record.OperationResult;
                    model.Type = "Medical Operation";
                }
                modelList.Add(model);

            }
            return modelList;
        }

        public void Save(RegisterMedicalExaminationModel model, int type)
        {
            MedicalService medicalExamination = null;

            Patient patient = new Patient
            {
                Name = model.PatientName,
                Address = new Address
                {
                    City = model.City,
                    Street = model.Street,
                    StreetNumber = model.StreetNumber
                },
                Phone = model.Phone,
                Ucn = model.Ucn,
            };

            medicalExamination = new MedicalService
            {
                Patient = patient,
                Disease = model.Disease,
                DoctorId = model.DoctorId,
                MedicalOpinion = model.MedicalOpinion,
                MedicalServiceDate = DateTime.ParseExact(model.Date, "MM/dd/yyyy", null),
                MedicalServiceType = (MedicalServiceType)type
            };
            medicalServiceRepository.Add(medicalExamination);
        }

        public void Save(RegisterMedicalOperationModel model, int type)
        {
            MedicalService medicalOperation = null;

            Patient patient = new Patient
            {
                Name = model.PatientName,
                Address = new Address
                {
                    City = model.City,
                    Street = model.Street,
                    StreetNumber = model.StreetNumber
                },
                Phone = model.Phone,
                Ucn = model.Ucn,
            };

            medicalOperation = new MedicalService
            {
                Patient = patient,
                OperationDescription = model.OperationDescription,
                DoctorId = model.DoctorId,
                OperationResult = model.OperationResult,
                MedicalServiceDate = DateTime.ParseExact(model.Date, "MM/dd/yyyy", null),
                MedicalServiceType = (MedicalServiceType)type
            };
            medicalServiceRepository.Add(medicalOperation);
        }
    }
}
