using Microsoft.AspNetCore.Mvc;
using WorldCup.Application.DTOs;
using WorldCup.Application.Interfaces;

namespace WorldCup.WebUI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Consumes("application/json")]
    [Produces("application/json")]
    public class FootballClubController : Controller
    {
        private readonly ILogger<FootballClubController> _logger;
        private readonly IFootballClubService _footballClubService;

        public FootballClubController(ILogger<FootballClubController> logger, IFootballClubService footballClubService)
        {
            _logger = logger;
            _footballClubService = footballClubService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<FootballClubDTO>>> GetAll()
        {
            var result = await _footballClubService.GetFootballClubAsync();

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult<FootballClubDTO>> AddFootballClub(FootballClubDTO footballClubDTO)
        {
            await _footballClubService.Add(footballClubDTO);

            return CreatedAtAction(nameof(AddFootballClub), footballClubDTO);

        }

    }
}
