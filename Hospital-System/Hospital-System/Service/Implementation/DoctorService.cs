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
            List<Doctor> doctors = doctorRepository.All().ToList();
            foreach (Doctor doctor in doctors)
            {
                sampleDoctorModels.Add(new SampleDoctorModel
                {
                    Id = doctor.Id,
                    Name=doctor.Name,
                    Phone = doctor.Phone,
                    Specialization = doctor.SpecializationType.ToString(),
                    Ward = doctor.WardType.ToString()
                });
            }

            return sampleDoctorModels;

        }
    }
}
