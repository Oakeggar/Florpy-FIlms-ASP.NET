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
            var allMovies = await _service.GetAllAsync();
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
            await _service.AddAsync(movie);
            return RedirectToAction(nameof(Index));
        }

		//Movies Details
		public async Task<IActionResult> Details(int id)
		{
			var movieDetails = await _service.GetByIdAsync(id);
			return View(movieDetails);
		}

		//Movies Edit
		public async Task<IActionResult> Edit(int id)
		{
			var movieDetails = await _service.GetByIdAsync(id);
			return View(movieDetails);
		}

		[HttpPost]
		public async Task<IActionResult> Edit(int id, [Bind("Id, FilmName, FilmDescr, FilmPictureURL, FilmPrice, FilmCategory")] Movie movie)
		{
			if (!ModelState.IsValid)
			{
				return View(movie);
			}
			await _service.UpdateAsync(id, movie);
			return RedirectToAction(nameof(Index));
		}

		//Movie Delete
		public async Task<IActionResult> Delete(int id)
		{
			var movieDetails = await _service.GetByIdAsync(id);
			return View(movieDetails);
		}

		[HttpPost]
		public async Task<IActionResult> DeleteConfirmed(int id)
		{
			var movieDetails = await _service.GetByIdAsync(id);
			await _service.DeleteAsync(id);
			return RedirectToAction(nameof(Index));
		}
	}
}
