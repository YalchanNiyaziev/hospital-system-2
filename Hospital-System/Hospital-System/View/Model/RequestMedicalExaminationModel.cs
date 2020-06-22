using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System.View.Model
{
    class RequestMedicalExaminationModel
    {
        public string  PatientName { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string StreetNumber { get; set; }
        public string DateTo { get; set; }
        public string TimeTo { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int DoctorId { get; set; }
    }
}
