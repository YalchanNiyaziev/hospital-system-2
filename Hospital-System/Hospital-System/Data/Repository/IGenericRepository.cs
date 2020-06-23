using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System.Data.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> All();
        IQueryable<T> SearchFor(Expression<Func<T, bool>> condition);
        void Add(T entity);
        void Update(T entity);

    }
}
