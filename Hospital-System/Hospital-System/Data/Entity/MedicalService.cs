using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System.Data.Entity
{
    public abstract class MedicalService : BaseEntity
    {
        [Column("date")]
        public DateTime MedicalServiceDate { get; set; }

        [Column("doctor_id")]
        public int? DoctorId { get; set; }

        public virtual Doctor Doctor { get; set; }

        [Column("patient_id")]
        public int? PatientId { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
