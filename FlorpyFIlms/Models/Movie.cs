using System.ComponentModel.DataAnnotations;
using FlorpyFIlms.Models.Data.Enum;

namespace FlorpyFIlms.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string FilmName { get; set; }
		[Required(ErrorMessage = "Description is required")]
		public string FilmDescr { get; set; }
		[Required(ErrorMessage = "Picture is required")]
		public string FilmPictureURL{ get; set; }
		[Required(ErrorMessage = "Price is required")]
		public int FilmPrice { get; set; }
		[Required(ErrorMessage = "Category is required")]
		public FilmCategory FilmCategory { get; set; }
    }
}
