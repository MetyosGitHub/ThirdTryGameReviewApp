using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ThirdTryGameReviewApp.Data.Entities;

namespace ThirdTryGameReviewApp.Data
{
    public class GameReviewDbContext : IdentityDbContext<User>
    {
        public GameReviewDbContext(DbContextOptions<GameReviewDbContext> options)
            : base(options)
        {
        }
    }
}