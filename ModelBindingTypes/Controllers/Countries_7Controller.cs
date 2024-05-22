using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelBindingTypes.Models;

namespace ModelBindingTypes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Countries_7Controller : ControllerBase
    {
        [HttpPost("{Name}")]
        public IActionResult GetCountry_9([FromQuery] string Capital, [FromRoute] string Name)
        {
            return Ok($"Country name : {Name} Capital : {Capital}");
        }

        [HttpPost("{Name}/{population}/{capital}")]
        public IActionResult GetCountry_10([FromQuery] string Capital, [FromRoute] Country country)
        {
            return Ok($"Country name : {country.Name}   Population : {country.Population}  Capital : {country.Capital}");
        }
    }
}
