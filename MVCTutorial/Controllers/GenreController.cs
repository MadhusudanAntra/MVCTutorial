using ApplicationCore.Contracts.Repository;
using ApplicationCore.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MVCTutorial.Controllers
{
    public class GenreController : Controller
    {
        private readonly IGenreRepository genreRepository;

        public GenreController(IGenreRepository genreRepository)
        {
            this.genreRepository = genreRepository;
        }
        public IActionResult Index(int pageNumber = 1, int pageSize = 10)
        {
            var result = genreRepository.GetGenresByPages(pageNumber,pageSize);
            return View(result);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Genre genre)
        {
            if (ModelState.IsValid)
            {
                genreRepository.Insert(genre);
                return RedirectToAction("Index");
            }
            return View(genre);
        }
        //http://localhost:port/Controller/Action/{id}
        //http://localhost:port/Genre/Edit/2
        [HttpGet]
        public IActionResult Edit(int id)
        {

            var result = genreRepository.GetById(id);
            return View(result);
        }

        [HttpPost]
        public IActionResult Edit(Genre genre)
        {
            if (ModelState.IsValid)
            {
                genreRepository.Update(genre);
                return RedirectToAction("Index");
            }
            return View(genre);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var result = genreRepository.GetById(id);
            return View(result);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var result = genreRepository.GetById(id);
            return View(result);
        }
        [HttpPost]
        public IActionResult Delete(Genre genre)
        {
            if (ModelState.IsValid)
            {
                genreRepository.Delete(genre.Id); return RedirectToAction("Index");
            }
            return View(genre);
        }

    }
}
