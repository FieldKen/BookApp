using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookApp.Models
{
    public class BookCreateViewModel
    {
        [Required, MaxLength(50)]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [MaxLength(250)]
        public string Description { get; set; }
        [Required]
        public int Rating { get; set; }
        [DisplayName("Publicatiedatum")]
        public DateTime PublishDate { get; set; }
    }
}