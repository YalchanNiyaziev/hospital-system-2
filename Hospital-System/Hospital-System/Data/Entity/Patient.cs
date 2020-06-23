using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System.Data.Entity
{
    [Table("patients")]
    public class Patient : Person
    {
        public Patient()
        {
            this.MedicalServices = new HashSet<MedicalService>();
        }

        [Column("email")]
        public string Email { get; set; }

        public ICollection<MedicalService> MedicalServices { get; set; }
    }
}
