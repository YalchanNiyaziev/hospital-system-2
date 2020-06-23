using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_System.Data.DbContext;
using Hospital_System.Data.Entity;

namespace Hospital_System.Data.Repository.Implementation
{
    class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(IHospitalSystemDbContext context) : base(context)
        {
        }
    }
}
