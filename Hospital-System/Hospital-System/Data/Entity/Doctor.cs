using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_System.Data.Entity.Enums;

namespace Hospital_System.Data.Entity
{
    [Table("doctors")]
    public class Doctor : User
    {
        public Doctor()
        {
            this.MedicalServices = new HashSet<MedicalService>();
        }

        [Column("ward")]
        public MedicalWardType WardType { get; set; }

        [Column("specialization")]
        public MedicalSpecializationType SpecializationType { get; set; }

        public ICollection<MedicalService> MedicalServices { get; set; }

    }
}
