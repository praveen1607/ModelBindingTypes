using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ModelBindingTypes.Filters;

namespace ModelBindingTypes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Countries_13Controller : ControllerBase
    {
        [HttpGet()]
        [TypeFilter(typeof(Authorization), Arguments = new object[] { "Admin" })]
        public IActionResult GetCountry_16(int id)
        {
            return Ok($"Country {id}");
        }
    }
}
