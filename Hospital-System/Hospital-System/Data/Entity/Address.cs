using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System.Data.Entity
{
    [Table("addresses")]
    public class Address : BaseEntity
    {

        public Address()
        {
            this.People = new HashSet<Person>();
        }

        [Required]
        [MaxLength(70)]
        [Column("city")]
        public string City { get; set; }

        [Required]
        [MaxLength(70)]
        [Column("street")]
        public string Street { get; set; }

        [MaxLength(15)]
        [Column("street_number")]
        public string StreetNumber { get; set; }

        public ICollection<Person> People { get; set; }
    }
}
