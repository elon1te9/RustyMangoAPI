using Microsoft.AspNetCore.Mvc;
using RustyMangoAPI.Interfaces;
using RustyMangoAPI.Requests;

namespace RustyMangoAPI.Controllers
{
    public class GameController : ControllerBase
    {
        private readonly IGameService _gameService;

        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }

        [HttpGet("getProgress")]
        public async Task<IActionResult> GetProgress(int userId)
        {
            return await _gameService.GetProgress(userId);
        }

        [HttpPost("completeLevel")]
        public async Task<IActionResult> CompleteLevel(CompleteLevelRequest request)
        {
            return await _gameService.CompleteLevel(request);
        }

        [HttpGet("getLeaderboard")]
        public async Task<IActionResult> GetLeaderboard()
        {
            return await _gameService.GetLeaderboard();
        }
    }
}

