using Microsoft.EntityFrameworkCore;
using ThirdTryGameReviewApp.Contracts;
using ThirdTryGameReviewApp.Data;
using ThirdTryGameReviewApp.Models;

namespace ThirdTryGameReviewApp.Services
{
    public class GameService : IGameService
    {
        private readonly GameReviewDbContext context;

        public GameService(GameReviewDbContext _context)
        {
            this.context = _context;
        }

        public async Task<IEnumerable<GameListViewModel>> GetAllAsync()
        {
            return await context.Games
                 .Select(m => new GameListViewModel()
                 {
                     Id = m.Id,
                     Name = m.Name,
                     YearOfCreation = m.YearOfCreation,
                     PictureURL = m.PictureURL,
                     
                 }).ToListAsync();
        }
    }
}
