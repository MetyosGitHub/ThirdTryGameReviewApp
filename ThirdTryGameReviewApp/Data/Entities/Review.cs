using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThirdTryGameReviewApp.Data.Entities
{
    public class Review
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public decimal Score { get; set; }
        [Required]
        public int GameId { get; set; }
        [Required]
        [ForeignKey(nameof(GameId))]
        public Game Game { get; set; }
    }
}
