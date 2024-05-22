using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelBindingTypes.Models;
using System.Xml.Linq;

namespace ModelBindingTypes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Countries_3Controller : ControllerBase
    {

        [HttpGet]
        public IActionResult GetCountry_3(string name, int population, string capital)
        {
            return Ok($"Country name : {name}   Population : {population}  Capital : {capital}");
        }

    }
}
