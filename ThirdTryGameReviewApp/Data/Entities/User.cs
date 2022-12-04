using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThirdTryGameReviewApp.Data.Entities
{
    public class User : IdentityUser
    {
        [Required]
        [MaxLength(25), MinLength(3)]
        public string Name { get; set; }


    }
}
