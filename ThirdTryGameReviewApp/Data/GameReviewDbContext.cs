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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>()
                .Property(u => u.UserName)
                .HasMaxLength(25)
                .IsRequired();
            builder.Entity<User>()
               .Property(u => u.Email)
               .HasMaxLength(65)
               .IsRequired();
            builder
                .Entity<Genre>()
                .HasData(new Genre()
                {
                    Id = 1,
                    Name = "Action",
                },
                new Genre()
                {
                    Id = 2,
                    Name = "Strategy"
                },
                new Genre()
                {
                    Id = 3,
                    Name = "MOBA"
                },
                new Genre()
                {
                    Id = 4,
                    Name = "First Person Shooter"
                },
                new Genre()
                {
                    Id = 5,
                    Name = "Puzzle"
                });
            builder.Entity<Publisher>()
                .HasData(new Publisher()
                {
                    Id = 1,
                    Name = "Santa Monica Studio"
                },
                new Publisher()
                {
                    Id = 2,
                    Name = "Sid Meier"
                },
                new Publisher()
                {
                    Id = 3,
                    Name = "Riot Games"
                },
                new Publisher()
                {
                    Id = 4,
                    Name = "Treyarch"
                },
                new Publisher()
                {
                    Id = 5,
                    Name = "TG Studios"
                });
            builder.Entity<Game>()
                .HasData(new Game()
                {
                    Id = 1,
                    Name = "God Of War",
                    Description = "After destroying the Greek Pantheon Kratos is trying to teach his son how to not make the same mistakes again.",
                    YearOfCreation = 2018,
                    GenreId = 1,
                    PublisherId = 1,
                    PictureURL = "https://cdn1.epicgames.com/offer/3ddd6a590da64e3686042d108968a6b2/EGS_GodofWar_SantaMonicaStudio_S2_1200x1600-fbdf3cbc2980749091d52751ffabb7b7_1200x1600-fbdf3cbc2980749091d52751ffabb7b7",

                },
                new Game()
                {
                    Id = 2,
                    Name = "Civilization 6",
                    Description = "Play as one of Earth's most famous leaders on their quest to build the greatest country there is and will be.",
                    YearOfCreation = 2016,
                    GenreId = 2,
                    PublisherId = 2,
                    PictureURL = "https://cdn1.epicgames.com/cd14dcaa4f3443f19f7169a980559c62/offer/EGS_SidMeiersCivilizationVI_FiraxisGames_S1-2560x1440-2fcd1c150ac6d8cdc672ae042d2dd179.jpg",
                },
                 new Game()
                 {
                     Id = 3,
                     Name = "League Of Legends",
                     Description = "A team-based competitive game mode based on strategy and outplaying opponents. Players work with their team to break the enemy Nexus before the enemy team breaks theirs.",
                     YearOfCreation = 2009,
                     GenreId = 3,
                     PublisherId = 3,
                     PictureURL = "https://cdn1.epicgames.com/salesEvent/salesEvent/EGS_LeagueofLegends_RiotGames_S2_1200x1600-7fd64f0f7b674900bdd172967865d545",


                 },
                  new Game()
                  {
                      Id = 4,
                      Name = "Call Of Duty Modern Warfare 2",
                      Description = "A sequel to the 2019 reboot, and serves as the nineteenth installment in the overall Call of Duty series.",
                      YearOfCreation = 2022,
                      GenreId = 4,
                      PublisherId = 4,
                      PictureURL = "https://assets-prd.ignimgs.com/2022/05/24/call-of-duty-modern-warfare-2-button-02-1653417394041.jpg",
                  },
                   new Game()
                   {
                       Id = 5,
                       Name = "Time Enigma",
                       Description = "A mobile game where you play as a detective who investigates the death of his cat in order to go back in time and prevent it from happening.",
                       YearOfCreation = 2020,
                       GenreId = 5,
                       PublisherId = 5,
                       
                       PictureURL = "https://img.itch.zone/aW1nLzM2MDk2NDcucG5n/original/xat20B.png",
                   });
            builder.Entity<Review>()
                .HasData(new Review()
                {
                    Id = 1,
                    GameId = 1,
                    Title = "God of War a true masterpiece",
                    Description = "I expected great action from God of War, and it delivers that handily. But I didn’t expect it to be a thrilling journey in which every aspect of it complements the others to form what is nothing short of a masterpiece. It’s a game in which Kratos, a previously one-note character, becomes a complex father, warrior, and monster, embattled both on the field and within his own heart about how to treat his son; one in which the world opens up and shifts, offering rewards in both gameplay and knowledge of its lore that I treasured with each accomplishment. The obvious care that went into crafting its world, characters, and gameplay delivers by far the most stirring and memorable game in the series.",
                    Score = 10,

                });




            base.OnModelCreating(builder);
        }
    }
}