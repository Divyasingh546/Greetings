using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace greetingsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreetingsController : ControllerBase
    {
        [HttpGet]
        [Route("/greetings")]
        public IActionResult Greet()
        {
            //will return HTTP status code and Message/data
            return Ok("Hello and Welcome to WebAPI developers world");
        }
        [HttpGet]
        [Route("/greetings/{guestName}")]
        public IActionResult Greet(string guestName)
        {
            if(guestName == "")
            {
                return NoContent();
            }
            else
            {
                return Ok("Hello" + guestName);
            }
        }

        [HttpGet]
        [Route("/List/techlist")]
        public IActionResult TechnologiesList()
        {
            string[] techlist = new string[5];
            techlist[0] = ".Net";
            techlist[1] = "Java";
            techlist[2] = "Angular";
            techlist[3] = "React";
            techlist[4] = "Azure";
            return Ok(techlist);
        }
    }
}
