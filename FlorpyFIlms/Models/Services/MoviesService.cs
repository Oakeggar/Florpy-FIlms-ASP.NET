using FlorpyFIlms.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace FlorpyFIlms.Models.Services
{
	public class MoviesService : IMoviesService
	{
		private readonly AppDbContext _context;
		public MoviesService(AppDbContext context)
		{
			_context = context;
		}
		public async Task AddAsync(Movie movie)
		{
			await _context.Movies.AddAsync(movie);
			await _context.SaveChangesAsync();
		}

		public async Task DeleteAsync(int id)
		{
			var result = await _context.Movies.FirstOrDefaultAsync(x => x.Id == id);
			_context.Movies.Remove(result);
			await _context.SaveChangesAsync();
		}

		public async Task<IEnumerable<Movie>> GetAllAsync()
		{
			var results = await _context.Movies.ToListAsync();
			return results;
		}

		public async Task<Movie> GetByIdAsync(int id)
		{
			var results= await _context.Movies.FirstOrDefaultAsync(n => n.Id == id);
			return results;
		}

		public async Task<Movie> UpdateAsync(int id, Movie newMovie)
		{
			_context.Update(newMovie);
			await _context.SaveChangesAsync();
			return newMovie;
		}
	}
}
