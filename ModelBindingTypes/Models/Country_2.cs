using Microsoft.AspNetCore.Mvc;
using ModelBindingTypes.Custom_Binder;

namespace ModelBindingTypes.Models
{
    [ModelBinder(typeof(CustomBinder2))]
    public class Country_2
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Population { get; set; }
        public string Capital { get; set; }
    }
}
