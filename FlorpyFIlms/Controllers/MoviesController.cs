using FlorpyFIlms.Models.Data;
using Microsoft.AspNetCore.Mvc;

namespace FlorpyFIlms.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _context;

        public MoviesController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allMovies = _context.Movies.ToList();
            return View(allMovies);
        }
    }
}
