using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelBindingTypes.Models;

namespace ModelBindingTypes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Countries_1Controller : ControllerBase
    {
        [BindProperty]
        public Country country { get; set; }

        [HttpPost]
        public IActionResult AddCountry_1()
        {
            return Ok($"Country name : {country.Name}   Population : {country.Population}  Capital : {country.Capital}");
        }

        [BindProperty(SupportsGet =true)]
        public Country_1 country_1 { get; set; }
        [HttpGet]
        public IActionResult AddCountry1()
        {
            return Ok($"Country name : {country_1.Name}   Population : {country_1.Population}  Capital : {country_1.Capital}");
        }
    }
}
