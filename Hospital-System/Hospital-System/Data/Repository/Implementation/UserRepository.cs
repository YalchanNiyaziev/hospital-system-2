using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_System.Data.DbContext;
using Hospital_System.Data.DbContext.Implementation;
using Hospital_System.Data.Entity;

namespace Hospital_System.Data.Repository.Implementation
{
    class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository() : base(new HospitalSystemDbContext())
        {
        }


        public User GetUser(string username, string password)
        {
            User user = null;
            user = SearchFor(u =>  (u.Username.Equals(username)) && (u.Password.Equals(password)) ).SingleOrDefault();
            return user;
        }
    }
}
