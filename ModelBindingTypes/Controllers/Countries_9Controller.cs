using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelBindingTypes.Models;

namespace ModelBindingTypes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Countries_9Controller : ControllerBase
    {
        [HttpPost("")]
        public IActionResult GetCountry_12([FromQuery] string id, [FromHeader]string developer, [FromHeader]int EnvId)
        {
            return Ok($"Developer id : {id} developer name : {developer} End id : {EnvId}");
        }

        [HttpGet]
        public IActionResult GetCountry_13([FromQuery] string id, [FromHeader] string developer, [FromHeader] int EnvId)
        {
            return Ok($"Developer id : {id} developer name : {developer} End id : {EnvId}");
        }
    }
}
