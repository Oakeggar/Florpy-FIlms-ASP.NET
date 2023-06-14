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
    }
}
