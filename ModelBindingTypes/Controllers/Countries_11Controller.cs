using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelBindingTypes.Custom_Binder;
using ModelBindingTypes.Models;
using System.Diagnostics.Metrics;

namespace ModelBindingTypes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Countries_11Controller : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult GetCountry_15([ModelBinder(Name = "id1")] Country_2 country)
        {
            return Ok($"Country Id : {country.Id} Country name : {country.Name}   Population : {country.Population}  Capital : {country.Capital}");
        }
    }
}
