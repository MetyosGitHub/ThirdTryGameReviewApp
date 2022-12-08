using ThirdTryGameReviewApp.Models;

namespace ThirdTryGameReviewApp.Contracts
{
    public interface IGameService
    {
        Task<IEnumerable<GameListViewModel>> GetAllAsync();
    }
}
