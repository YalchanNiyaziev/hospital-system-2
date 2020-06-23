using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System.Data.Entity
{
    public class MedicalOperation : MedicalService
    {
        [Column("description")]
        public string OperationDescription { get; set; }

        [Column("result")]
        public string OperationResult { get; set; }
    }
}
