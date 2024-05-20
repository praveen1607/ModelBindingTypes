using Microsoft.AspNetCore.Mvc;

namespace ModelBindingTypes.Models
{
    public class Country_1
    {
        //[BindProperty]
        public string Name { get; set; }

        [BindProperty]
        //[Required]
        public int? Population { get; set; }

        //[BindProperty]
        public string Capital { get; set; }
    }
}
