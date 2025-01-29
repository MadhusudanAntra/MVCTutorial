using ApplicationCore.Entities;
using ApplicationCore.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Repository
{
    public interface IMovieRepository:IRepository<Movie>
    {
        PageResultSet<Movie> GetMovies(int pageNumber=0, int pageSize=10);
    }
}
