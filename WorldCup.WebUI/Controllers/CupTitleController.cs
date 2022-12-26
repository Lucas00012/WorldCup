using Microsoft.AspNetCore.Mvc;

namespace WorldCup.WebUI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CupTitleController : ControllerBase
    {
        private readonly ILogger<CupTitleController> _logger;

        public CupTitleController(ILogger<CupTitleController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return (Ok()); 
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