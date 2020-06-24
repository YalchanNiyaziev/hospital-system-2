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
            this.examinationRequestRepository= new MedicalExaminationRequestRepository();
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
                ToDate =DateTime.ParseExact(model.DateTo, "MM/dd/yyyy", null),
                ToTime = DateTime.ParseExact(model.TimeTo, "HH:mm:ss", null),
                DoctorId = model.DoctorId,
                Status = ExaminationRequestStatusType.Pending
            };
            
            this.examinationRequestRepository.Add(medicalExaminationRequest);
        }

        public List<SampleExaminationRequestModel> GetAllPendingRequestByDoctor(int doctorId)
        {

            List<SampleExaminationRequestModel> modelList = this.GetAllRequestByDoctor(doctorId);

            modelList.Add(new SampleExaminationRequestModel
            {
                Date = DateTime.Now.ToString(),
                Name = "Test"+modelList.Count,
                Status = "Pending",
                Id=modelList.Count
            });
            modelList.Add(new SampleExaminationRequestModel
            {
                Date = DateTime.Now.ToString(),
                Name = "Test" + modelList.Count,
                Status = "Pending",
                Id = modelList.Count
            });
            modelList.Add(new SampleExaminationRequestModel
            {
                Date = DateTime.Now.ToString(),
                Name = "Test" + modelList.Count,
                Status = "Pending",
                Id = modelList.Count
            });
            modelList.Add(new SampleExaminationRequestModel
            {
                Date = DateTime.Now.ToString(),
                Name = "Test" + modelList.Count,
                Status = "Pending",
                Id = modelList.Count
            });
            modelList.Add(new SampleExaminationRequestModel
            {
                Date = DateTime.Now.ToString(),
                Name = "Test" + modelList.Count,
                Status = "Pending",
                Id = modelList.Count
            });
            return modelList;
        }

        public ExaminationRequestDetailsModel GetMedicalExaminationRequestById(int id)
        {
            ExaminationRequestDetailsModel model = new ExaminationRequestDetailsModel
            {
                Name = "Ivan Penchev",
                City = "Varna",
                Street = "Anton Nedelchev",
                StreetNumber = "11A",
                Date = DateTime.Now.ToString(),
                Time = DateTime.Now.ToString(),
                Phone = "02545453",
                Email = "ivanco@abv.bg"
            };
            return model;
        }

        private List<SampleExaminationRequestModel> GetAllRequestByDoctor(int doctorId)
        {
            List<SampleExaminationRequestModel> modelList = new List<SampleExaminationRequestModel>();
            
            return modelList;
        }
    }
}
