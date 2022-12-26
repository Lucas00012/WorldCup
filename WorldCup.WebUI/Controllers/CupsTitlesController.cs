using Microsoft.AspNetCore.Mvc;
using WorldCup.Application.Interfaces;

namespace WorldCup.WebUI.Controllers
{
    [ApiController]
    [Route("[controller]")]
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
        public async Task<ActionResult> GetAll()
        {
            var result = await _cupTitleService.GetCupTitles();
            
            if(result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create()
        {
            return CreatedAtAction(nameof(Create),"");
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