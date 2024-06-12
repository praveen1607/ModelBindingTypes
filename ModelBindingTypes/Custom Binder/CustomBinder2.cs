using Microsoft.AspNetCore.Mvc.ModelBinding;
using ModelBindingTypes.Models;

namespace ModelBindingTypes.Custom_Binder
{
    public class CustomBinder2 : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            var modelName = bindingContext.ModelName;

            var value = bindingContext.ValueProvider.GetValue("id");

            var reader = new StreamReader(bindingContext.HttpContext.Request.Body);

            // var body = val.ReadAtLeastAsync();
            var body =  reader.ReadToEndAsync();

            var res = value.FirstValue;
            
            if(!int.TryParse(res, out int id))
            {
                return Task.CompletedTask;
            }
            
            var model  = new Country_2() { Id = id , Name ="India", Capital="Delhi", Population=11111 };

            bindingContext.Result = ModelBindingResult.Success(model);

            return Task.CompletedTask;
        }
    }
}
