using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_System.View.Model;

namespace Hospital_System.Service.Implementation
{
    class MedicalExaminationRequestService : IMedicalExaminationRequestService
    {
        public void Save(RequestMedicalExaminationModel model)
        {
            
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
