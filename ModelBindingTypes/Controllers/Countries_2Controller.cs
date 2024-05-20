using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ModelBindingTypes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [BindProperties]
    public class Countries_2Controller : ControllerBase
    {
        public string Name { get; set; }
        public int? Population { get; set; }
        public string Capital { get; set; }

        [HttpPost]
        public IActionResult GetCountry_2()
        {
            return Ok($"Country name : {Name}   Population : {Population}  Capital : {Capital}");
        }
    }
}
