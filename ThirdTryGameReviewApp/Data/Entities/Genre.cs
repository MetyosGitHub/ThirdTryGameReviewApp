using System.ComponentModel.DataAnnotations;

namespace ThirdTryGameReviewApp.Data.Entities
{
    public class Genre
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }


    }
}
