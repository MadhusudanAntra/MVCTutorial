using ApplicationCore.Contracts.Repository;
using ApplicationCore.Entities;
using ApplicationCore.Helper;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class MovieRepository : BaseRepository<Movie>, IMovieRepository
    {
        public MovieRepository(MovieDbContext movieDbContext) : base(movieDbContext)
        {
        }

        public PageResultSet<Movie> GetMovies(int pageNumber = 1, int pageSize = 10)
        {
            int count = GetAll().Count();
            var collection = GetAll();
            PageResultSet<Movie> pageResultSet = new PageResultSet<Movie>();
            pageResultSet.PageSize = pageSize;
            pageResultSet.ItemCount = count;
            if (count % pageSize == 0)
                pageResultSet.PageCount = count / pageSize;   //100/10
            else
                pageResultSet.PageCount = (count / pageSize) + 1;  //107/10

            pageResultSet.Items = GetAll().Skip((pageNumber - 1) * pageSize).Take(pageSize);
            return pageResultSet;
        }
    }
}
