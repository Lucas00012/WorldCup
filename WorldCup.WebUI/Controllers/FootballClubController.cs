using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WorldCup.Application.Interfaces;
using WorldCup.Application.Services;

namespace WorldCup.WebUI.Controllers
{
    public class FootballClubController : Controller
    {
        private readonly ILogger<CupsTitlesController> _logger;
        private readonly IFootballClubService _footballClubService;

        public FootballClubController(ILogger<CupsTitlesController> logger, IFootballClubService footballClubService)
        {
            _logger = logger;
            _footballClubService = footballClubService;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var result = await _footballClubService.GetFootballClubAsync();

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

    }
}
