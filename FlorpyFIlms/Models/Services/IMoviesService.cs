namespace FlorpyFIlms.Models.Services
{
	public interface IMoviesService
	{
		Task<IEnumerable<Movie>> GetAllAsync();
		Task<Movie> GetByIdAsync(int id);
		Task AddAsync(Movie movie);
		Task<Movie> UpdateAsync(int id, Movie newMovie);
		Task DeleteAsync(int id);
	}
}
