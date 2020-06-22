using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System.View.Model
{
    class RegisterMedicalExaminationModel
    {
        public string PatientName { get; set; }
        public string Ucn { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string StreetNumber { get; set; }
        public string Date { get; set; }
        public string Disease { get; set; }
        public string MedicalOpinion { get; set; }
        public string Phone { get; set; }
        public int DoctorId { get; set; }
    }
}
