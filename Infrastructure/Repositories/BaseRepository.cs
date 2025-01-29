using ApplicationCore.Contracts.Repository;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        private readonly MovieDbContext movieDbContext;

        public BaseRepository(MovieDbContext movieDbContext)
        {
            this.movieDbContext = movieDbContext;
        }
        public int Delete(int id)
        {
            var result = GetById(id);
            if (result != null)

                movieDbContext.Set<T>().Remove(result);

            return movieDbContext.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return movieDbContext.Set<T>();
        }

        public T GetById(int id)
        {
            return movieDbContext.Set<T>().Find(id);
        }

        public int Insert(T entity)
        {
            movieDbContext.Set<T>().Add(entity);
            return movieDbContext.SaveChanges();
        }

        public IEnumerable<T> Search(Func<T, bool> predicate)
        {
            return movieDbContext.Set<T>().Where(predicate);
        }

        public int Update(T entity)
        {
            movieDbContext.Set<T>().Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return movieDbContext.SaveChanges();
        }
    }
}
