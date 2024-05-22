using Glimpse.Mvc.AlternateType;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelBindingTypes.Custom_Binder;

namespace ModelBindingTypes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Countries_10Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCountry_14([ModelBinder(typeof(CustomBinder1))] string[] countries)
        {
            return Ok(countries);
        }
    }
}
