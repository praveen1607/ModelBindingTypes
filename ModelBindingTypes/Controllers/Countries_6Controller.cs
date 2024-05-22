using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelBindingTypes.Models;

namespace ModelBindingTypes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Countries_6Controller : ControllerBase
    {
        [HttpPost]
        public IActionResult GetCountry_8([FromQuery]string Population,[FromQuery] int id,[FromQuery] Country country)
        {
            return Ok($" Country Id : {id} Country name : {country.Name}   Population : {Population}  Capital : {country.Capital}");
        }
    }
}
