using Microsoft.AspNetCore.Mvc;
using WorldCup.Application.DTOs;
using WorldCup.Application.Interfaces;

namespace WorldCup.WebUI.Controllers
{
    [ApiVersion("1.0")]
    [ApiController]
    [Route("api/[controller]")]
    public class CupsTitlesController : ControllerBase
    {
        private readonly ILogger<CupsTitlesController> _logger;
        private readonly ICupTitleService _cupTitleService;
        public CupsTitlesController(ILogger<CupsTitlesController> logger, 
            ICupTitleService cupTitleService)
        {
            _logger = logger;
            _cupTitleService = cupTitleService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<CupTitleDTO>>> Get()
        {
            var result = await _cupTitleService.GetCupTitles();

            if (result == null)
            {
                Console.WriteLine(result);
                return NoContent();
                
            }

            return Ok(result);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult<CupTitleDTO>> AddCupTitle(CupTitleDTO cupTitleDTO)
        {
            await _cupTitleService.Add(cupTitleDTO);

            return CreatedAtAction(nameof(AddCupTitle), cupTitleDTO);

        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> UpdatePutCupTitle(CupTitleDTO cupTitleDTO)
        {
            await _cupTitleService.Update(cupTitleDTO);
            return NoContent();
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Delete(int id)
        {
            await _cupTitleService.Remove(id);
            return Ok();
        }
    }
}