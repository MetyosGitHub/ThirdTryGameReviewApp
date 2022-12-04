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

        public DbSet<Game> Games { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Publisher> Publishers { get; set; }

        public DbSet<Review> Reviews { get; set; }
    }
}