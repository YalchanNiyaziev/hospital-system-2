using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_System.Data.Entity;
using Hospital_System.Data.Entity.Enums;
using Hospital_System.Data.Repository;
using Hospital_System.Data.Repository.Implementation;
using Hospital_System.View.Model;

namespace Hospital_System.Service.Implementation
{
    class MedicalExaminationRequestService : IMedicalExaminationRequestService
    {
        private IMedicalExaminationRequestRepository examinationRequestRepository;

        public MedicalExaminationRequestService()
        {
            this.examinationRequestRepository = new MedicalExaminationRequestRepository();
        }

        public void Save(RequestMedicalExaminationModel model)
        {
            MedicalExaminationRequest medicalExaminationRequest = new MedicalExaminationRequest
            {
                Patient = new Patient
                {
                    Name = model.PatientName,
                    Address = new Address
                    {
                        City = model.City,
                        Street = model.Street,
                        StreetNumber = model.StreetNumber
                    },
                    Email = model.Email,
                    Phone = model.Phone,
                },
                ToDate = DateTime.ParseExact(model.DateTo, "MM/dd/yyyy", null),
                ToTime = DateTime.ParseExact(model.TimeTo, "HH:mm:ss", null),
                DoctorId = model.DoctorId,
                Status = ExaminationRequestStatusType.Pending
            };

            this.examinationRequestRepository.Add(medicalExaminationRequest);
        }

        public List<SampleExaminationRequestModel> GetAllPendingRequestByDoctor(int doctorId)
        {
            List<SampleExaminationRequestModel> modelList = new List<SampleExaminationRequestModel>(); ;
            List<MedicalExaminationRequest> medicalExaminationRequests
                = examinationRequestRepository.FindByDoctor(doctorId);

            if (medicalExaminationRequests.Count > 0)
            {
                foreach (var examinationRequest in medicalExaminationRequests)
                {
                    modelList.Add(new SampleExaminationRequestModel
                    {
                        Date = examinationRequest.ToTime.TimeOfDay+ " "+ examinationRequest.ToDate.ToShortDateString(),
                        Name = examinationRequest.Patient.Name,
                        Id = examinationRequest.Id,
                        Status = examinationRequest.Status.ToString()
                    });
                }
            }

            return modelList;
        }

        public ExaminationRequestDetailsModel GetMedicalExaminationRequestById(int id)
        {
            MedicalExaminationRequest examinationRequest = this.examinationRequestRepository.FindById(id);
            ExaminationRequestDetailsModel model = null;
            if (examinationRequest != null)
            {
                model = new ExaminationRequestDetailsModel
                {
                    Name = examinationRequest.Patient.Name,
                    City = examinationRequest.Patient.Address.City,
                    Street = examinationRequest.Patient.Address.Street,
                    StreetNumber = examinationRequest.Patient.Address.StreetNumber,
                    Date = examinationRequest.ToDate.ToShortDateString(),
                    Time = examinationRequest.ToTime.ToShortTimeString(),
                    Phone = examinationRequest.Patient.Phone,
                    Email = examinationRequest.Patient.Email
                };
            }
            return model;
        }
    }
}