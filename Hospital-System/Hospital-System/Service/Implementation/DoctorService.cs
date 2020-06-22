using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_System.View.Model;

namespace Hospital_System.Service.Implementation
{
    class DoctorService : IDoctorService
    {

        public void Save(RegisterDoctorModel doctorModel)
        {
        }

        public List<SampleDoctorModel> GetAllDoctorsAsSampleDoctorModels()
        {
            List<SampleDoctorModel> sampleDoctorModels = new List<SampleDoctorModel>();
            sampleDoctorModels.Add(new SampleDoctorModel
            {
                Name = "Ivan Belchev",
                Phone = "0656545",
                Ward = "Dental Medicine",
                Specialization = "Surgery",
                Id = 5
            });
            sampleDoctorModels.Add(new SampleDoctorModel
            {
                Name = "Ivan Belchev",
                Phone = "0656545",
                Ward = "Dental Medicine",
                Specialization = "Surgery",
                Id = 88
            });
            sampleDoctorModels.Add(new SampleDoctorModel
            {
                Name = "Ivan Belchev",
                Phone = "0656545",
                Ward = "Dental Medicine",
                Specialization = "Surgery",
                Id = 111
            });
            return sampleDoctorModels;

        }
    }
}
