using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelBindingTypes.Models;

namespace ModelBindingTypes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Countries_4Controller : ControllerBase
    {
        [HttpGet("{name}/{population}/{capital}")]
        [Authorize]
        public IActionResult GetCountry_4(string name, int population, string capital)
        {
            return Ok($"Country name : {name}   Population : {population}  Capital : {capital}");
        }

        [HttpPost]
        public IActionResult GetCountry_5(Country country)
        {
            return Ok($"Country name : {country.Name}   Population : {country.Population}  Capital : {country.Capital}");
        }
    }
}
