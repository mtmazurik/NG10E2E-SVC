using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ng10e2e-svc.Controllers
{
    [Route("[controller]")] //   /admin
    [ApiController]
    public class AdminController : ControllerBase
    {
        // GET:  /ping
        [HttpGet("ping")]
        public IActionResult Get()
        {
            return Ok("200 OK Ping");
        }
    }
}
