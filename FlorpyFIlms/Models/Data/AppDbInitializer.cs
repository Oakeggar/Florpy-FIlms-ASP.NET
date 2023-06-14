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
                            FilmName = "The Ritual",
                            FilmDescr = "Reuniting after the tragic death of their friend, four college pals set out to hike through the Scandinavian wilderness. A wrong turn leads them into the mysterious forests of Norse legend, where an ancient evil exists and stalks them at every turn.",
                            FilmPictureURL = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcQcPrzfxMfgHr_eB1Nn6aWjmGpauBKHb9z58DDRUgOZU88k-0U0",
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
