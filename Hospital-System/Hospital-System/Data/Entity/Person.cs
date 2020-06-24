using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System.Data.Entity
{
    [Table(("people"))]
    public abstract class Person : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        [Column("name")]
        public string Name { get; set; }

        
        [MaxLength(10)]
        [Column("egn")]
        public string Ucn { get; set; }

        [MaxLength(30)]
        [Column("phone")]
        public string Phone { get; set; }

        [Column("address_id")]
        public int? AddressId { get; set; }

        [Column("address")]
        public virtual Address Address { get; set; }

    }
}
