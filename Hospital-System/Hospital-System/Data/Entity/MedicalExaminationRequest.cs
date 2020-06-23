using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_System.Data.Entity.Enums;

namespace Hospital_System.Data.Entity
{
    [Table("examination_requests")]
    public class MedicalExaminationRequest : BaseEntity
    {
        [Column("patient_id")]
        public int? PatientId { get; set; }
        public Patient Patient { get; set; }

        [Column("doctor_id")]
        public int? DoctorId { get; set; }
        public Doctor Doctor { get; set; }

        [Column("to_date")]
        public DateTime ToDate { get; set; }

        [Column("to_time")]
        public DateTime ToTime { get; set; }

        [Column("status")]
        public ExaminationRequestStatusType Status { get; set; }
    }
}
