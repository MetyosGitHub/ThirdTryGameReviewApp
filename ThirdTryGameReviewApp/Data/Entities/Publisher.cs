using System.ComponentModel.DataAnnotations;

namespace ThirdTryGameReviewApp.Data.Entities
{
    public class Publisher
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }


    }
}
