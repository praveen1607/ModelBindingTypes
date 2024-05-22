using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelBindingTypes.Models;

namespace ModelBindingTypes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Countries_5Controller : ControllerBase
    {

        [HttpGet("")]
        public IActionResult GetCountry_5([FromQuery] string name)
        {
            return Ok($"Country name : {name}");
        }

        [HttpGet("{name}")]
        public IActionResult GetCountry_6([FromQuery] string name)
        {
            return Ok($"Country name : {name}");
        }

        [HttpPost]
        public IActionResult GetCountry_7([FromQuery]Country country)
        {
            return Ok($"Country name : {country.Name}   Population : {country.Population}  Capital : {country.Capital}");
        }
    }
}
