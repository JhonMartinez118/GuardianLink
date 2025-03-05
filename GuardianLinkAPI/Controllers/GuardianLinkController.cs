using Microsoft.AspNetCore.Mvc;


namespace GuardianLinkAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuardianLinkController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { message = "Hello, World!" });
        }

        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            return Ok(new { receivedValue = value });
        }
    }
}
