using FlorpyFIlms.Models.Data.Enum;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
namespace FlorpyFIlms.Models.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScore = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScore.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();
                
                if(!context.Movies.Any()) 
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            FilmName = "Shining",
                            FilmDescr = "Jack and his family move into an isolated hotel with a violent past. Living in isolation, Jack begins to lose his sanity, which affects his family members.",
                            FilmPictureURL = "https://m.media-amazon.com/images/I/81nwnHTcV2L._AC_UF1000,1000_QL80_.jpg",
                            FilmPrice = 20,
                            FilmCategory = FilmCategory.Horror
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
