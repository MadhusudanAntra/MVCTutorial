using ApplicationCore.Contracts.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVCTutorial.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieRepository movieRepository;
        private readonly IGenreRepository genreRepository;

        public MovieController(IMovieRepository movieRepository,IGenreRepository genreRepository)
        {
            this.movieRepository = movieRepository;
            this.genreRepository = genreRepository;
        }
        public IActionResult Index()
        {
            var result = movieRepository.GetMovies();
            return View(result);
        }
        public IActionResult Create() {
            //ViewData["Title"] = "This is demo title";
            //ViewBag.Genres =new List<string>(){ "Comedy","Horror", "Drama"};
           ViewBag.Genres=  new SelectList(genreRepository.GetAll(),"Id","Name");
            return View();
        }
    }
}
