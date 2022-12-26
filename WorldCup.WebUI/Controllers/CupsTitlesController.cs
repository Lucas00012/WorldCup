using Microsoft.AspNetCore.Mvc;
using WorldCup.Application.DTOs;
using WorldCup.Application.Interfaces;

namespace WorldCup.WebUI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Consumes("application/json")]
    [Produces("application/json")]
    public class CupsTitlesController : ControllerBase
    {
        private readonly ILogger<CupsTitlesController> _logger;
        private readonly ICupTitleService _cupTitleService;
        public CupsTitlesController(ILogger<CupsTitlesController> logger, ICupTitleService cupTitleService)
        {
            _logger = logger;
            _cupTitleService = cupTitleService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<CupTitleDTO>>> GetAll()
        {
            var result = await _cupTitleService.GetCupTitles();

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult<CupTitleDTO>> AddCupTitle(CupTitleDTO cupTitleDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            await _cupTitleService.Add(cupTitleDTO);

            return CreatedAtAction(nameof(AddCupTitle), cupTitleDTO);

        }

        [HttpPut]
        public IActionResult Update()
        {
            return NoContent();
        }

        [HttpPatch]
        public IActionResult Updat()
        {
            return NoContent();
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok();
        }
    }
}