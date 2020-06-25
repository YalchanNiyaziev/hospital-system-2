using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_System.Data.Entity.Enums;

namespace Hospital_System.Data.Entity
{
    [Table("medical_service")]
    public  class MedicalService : BaseEntity
    {
        [Column("date")]
        public DateTime MedicalServiceDate { get; set; }

        [Column("doctor_id")]
        public int? DoctorId { get; set; }

        public virtual Doctor Doctor { get; set; }

        [Column("patient_id")]
        public int? PatientId { get; set; }
        public virtual Patient Patient { get; set; }

        [Column("disease")]
        [MaxLength(50)]
        public string Disease { get; set; }

        [Column("medical_opinion")]
        public string MedicalOpinion { get; set; }
        [Column("description")]
        public string OperationDescription { get; set; }

        [Column("result")]
        public string OperationResult { get; set; }

        [Column("type")]
        public MedicalServiceType MedicalServiceType { get; set; }
    }
}
