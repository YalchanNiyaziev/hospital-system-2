using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_System.Data.DbContext.Implementation;
using Hospital_System.Data.Entity;

namespace Hospital_System.Data.Repository.Implementation
{

    public class AdminRepository : GenericRepository<Admin>, IAdminRepository
    {
        public AdminRepository() : base(new HospitalSystemDbContext())
        {

        }

        public Admin FindById(int id)
        {
            var admin = SearchFor(a => a.Id == id).AsQueryable().First();
            return admin;
        }
    }
}
