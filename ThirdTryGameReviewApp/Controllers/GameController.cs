using Microsoft.AspNetCore.Mvc;
using ThirdTryGameReviewApp.Contracts;

namespace ThirdTryGameReviewApp.Controllers
{
    public class GameController : Controller
    {
        private readonly IGameService gameService;
        public GameController(IGameService _gameService)
        {
            gameService = _gameService;
        }
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var model = await gameService.GetAllAsync();
            return View(model);
        }
    }
}
