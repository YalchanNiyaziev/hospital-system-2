using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_System.Data.Entity.Enums;

namespace Hospital_System.Data.Entity
{
    [Table("users")]
    public class User : Person
    {

        [Column("username")]
        public string Username { get; set; }

        [Column("password")]
        public string Password { get; set; }

        [Column("role")] 
        public UserRoleType Role { get; set; }
    }
}
