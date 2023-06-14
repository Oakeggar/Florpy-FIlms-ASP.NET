using System.ComponentModel.DataAnnotations;
using FlorpyFIlms.Models.Data.Enum;

namespace FlorpyFIlms.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        public string FilmName { get; set; }
        public string FilmDescr { get; set; }
        public string FilmPictureURL{ get; set; }
        public int FilmPrice { get; set; }
        public FilmCategory FilmCategory { get; set; }
    }
}
