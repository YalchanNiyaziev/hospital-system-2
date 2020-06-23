using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System.View.Model
{
    class RegisterMedicalOperationModel
    {
        public string PatientName { get; set; }
        public string Ucn { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string StreetNumber { get; set; }
        public string Date { get; set; }
        public string OperationDescription { get; set; }
        public string OperationResult { get; set; }
        public string Phone { get; set; }
        public int DoctorId { get; set; }
    }
}
