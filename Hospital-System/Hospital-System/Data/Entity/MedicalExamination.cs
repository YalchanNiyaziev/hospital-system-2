using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System.Data.Entity
{
    public class MedicalExamination : MedicalService
    {
        [Column("disease")]
        [MaxLength(50)]
        public string Disease { get; set; }

        [Column("medical_opinion")]
        public string MedicalOpinion { get; set; }
    }
}
