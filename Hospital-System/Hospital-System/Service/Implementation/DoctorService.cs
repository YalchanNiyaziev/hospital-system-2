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
    class DoctorService : IDoctorService
    {
        private IDoctorRepository doctorRepository;

        public DoctorService()
        {
            this.doctorRepository= new DoctorRepository();
        }

        public void Save(RegisterDoctorModel doctorModel)
        {
            Doctor doctor = new Doctor
            {
                Name = doctorModel.Name,
                Ucn = doctorModel.Ucn,
                Address = new Address
                {
                    City = doctorModel.City,
                    Street = doctorModel.Street,
                    StreetNumber = doctorModel.StreetNumber
                },
                WardType = (MedicalWardType)doctorModel.Ward,
                SpecializationType = (MedicalSpecializationType)doctorModel.Specialization,
                Username = doctorModel.Username,
                Password = doctorModel.Password,
                Role = UserRoleType.Doctor,
                Phone = doctorModel.Phone
            };

                 this.doctorRepository.Add(doctor);
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
                Id = 88
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
                Id = 88
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
                Id = 88
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
                Id = 88
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
                Id = 88
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
                Id = 88
            });
            sampleDoctorModels.Add(new SampleDoctorModel
            {
                Name = "Ivan Belchev",
                Phone = "0656545",
                Ward = "Dental Medicine",
                Specialization = "Surgery",
                Id = 88
            }); sampleDoctorModels.Add(new SampleDoctorModel
            {
                Name = "Ivan Belchev",
                Phone = "0656545",
                Ward = "Dental Meddssssssssssssssssssssssssxxicine",
                Specialization = "Surgery",
                Id = 88
            });
            sampleDoctorModels.Add(new SampleDoctorModel
            {
                Name = "Ivan Belchev",
                Phone = "05",
                Ward = "Dedicine",
                Specialization = "Surgery",
                Id = 88
            });
            sampleDoctorModels.Add(new SampleDoctorModel
            {
                Name = "Ivan Belcddddddddddddddddddddddddddddddddhev",
                Phone = "0656fffffffffffffff545",
                Ward = "Dental Medicfffffffffffffine",
                Specialization = "Surgefffffffffffry",
                Id = 88
            });

            return sampleDoctorModels;

        }
    }
}
