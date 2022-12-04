using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThirdTryGameReviewApp.Data.Entities
{
    public class Game
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int YearOfCreation { get; set; }

        public List<Review> GameReviews { get; set; } = new List<Review>();

        public string? PictureURL { get; set; }

        public int GenreId { get; set; }
        [ForeignKey(nameof(GenreId))]
        public Genre Genre { get; set; }

        public int PublisherId { get; set; }
        [ForeignKey(nameof(PublisherId))]
        public Publisher Publisher { get; set; }
    }
}
