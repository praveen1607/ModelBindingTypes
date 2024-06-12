using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelBindingTypes.Models;

namespace ModelBindingTypes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class Countries_12Controller : ControllerBase
    {
        [HttpGet()]
        public IActionResult GetCountry_16(int id)
        {
            return Ok($"Country {id}");
        }
    }
}
