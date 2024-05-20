using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging.Abstractions;
using System.ComponentModel.DataAnnotations;
using ModelBindingTypes.Models;

namespace ModelBindingTypes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {

        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        //[Required]
        public int? Population { get; set; }

        [BindProperty]
        public string Capital { get; set; }

        [HttpPost]
        public IActionResult AddCountry()
        {
            return Ok($"Country name : {Name}   Population : {Population}  Capital : {Capital}");
        }

    }
}
