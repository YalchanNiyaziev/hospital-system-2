using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Hospital_System.Data.DbContext;

namespace Hospital_System.Data.Repository.Implementation
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private IHospitalSystemDbContext context;
        private DbSet<T> set;

        public GenericRepository(IHospitalSystemDbContext context)
        {
            this.context = context;
            this.set = context.Set<T>();
        }

        public IQueryable<T> All()
        {
            return this.set.AsQueryable();
        }

        public IQueryable<T> SearchFor(Expression<Func<T, bool>> condition)
        {
            return this.All().Where(condition);
        }

        public void Add(T entity)
        {

            this.set.Add(entity);
            context.SaveChanges();

        }

        public void Update(T entity)
        {
            this.set.Attach(entity);
            var entry = context.Entry(entity);
            entry.State = EntityState.Modified;
            context.SaveChanges();

        }
    }
}
