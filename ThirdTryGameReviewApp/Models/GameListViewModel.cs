using System.ComponentModel.DataAnnotations;

namespace ThirdTryGameReviewApp.Models
{
    public class GameListViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public int YearOfCreation { get; set; }
        [Required]
        public string PictureURL { get; set; }
        
        
    }
}
