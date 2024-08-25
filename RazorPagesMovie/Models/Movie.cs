using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [StringLength(128, MinimumLength = 3)]
        public string Содержимое { get; set; } = string.Empty;
        //public string Время { get; set; } = string.Empty;
        [Display(Name = "Время отправки")]
        [DataType(DataType.DateTime)]
        public DateTime ReleaseDate { get; set; }
        
    }
}

