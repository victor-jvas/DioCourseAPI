using System.Linq;
using DioCourseAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DioCourseAPI.Filters
{
    public class ValidationModelStateCustomized : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                var validFieldViewModel = new ValidFieldViewModelOutput(context.ModelState.SelectMany(pair => pair.Value.Errors)
                    .Select(s => s.ErrorMessage));
                context.Result = new BadRequestObjectResult(validFieldViewModel);
            }
        }
    }
}