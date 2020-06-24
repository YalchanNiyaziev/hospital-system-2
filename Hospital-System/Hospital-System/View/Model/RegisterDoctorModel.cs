using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System.View.Model
{
    class RegisterDoctorModel
    {
        public string Name { get; set; }
        public string Ucn { get; set; }
        public string  City { get; set; }
        public string Street { get; set; }
        public string StreetNumber { get; set; }
        public int Ward { get; set; }
        public int Specialization { get; set; }
        public int Role { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
    }
}
