using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelBindingTypes.Models;

namespace ModelBindingTypes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Countries_8Controller : ControllerBase
    {
        [HttpPost("")]
        public IActionResult GetCountry_11([FromQuery] string id, [FromForm] Country country)
        {
            return Ok($"Country id : {id} Country name : {country.Name}   Population : {country.Population}  Capital : {country.Capital}");
        }
    }
}
