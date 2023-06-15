using FlorpyFIlms.Models;
using FlorpyFIlms.Models.Data;
using FlorpyFIlms.Models.Services;
using Microsoft.AspNetCore.Mvc;

namespace FlorpyFIlms.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMoviesService _service;

        public MoviesController(IMoviesService service)
        {
			_service = service;
        }

        public async Task<IActionResult> Index()
        {
            var allMovies = await _service.GetAll();
            return View(allMovies);
        }
        //Movies Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FilmName, FilmDescr, FilmPictureURL, FilmPrice, FilmCategory")]Movie movie)
        {
            if(!ModelState.IsValid)
            {
                return View(movie);
            }
            _service.Add(movie);
            return RedirectToAction(nameof(Index));
        }
    }
}
