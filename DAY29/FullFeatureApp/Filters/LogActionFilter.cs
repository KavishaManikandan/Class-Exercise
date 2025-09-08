
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;

namespace FullFeatureApp.Filters
{
    public class LogActionFilter : IActionFilter
    {
        private readonly ILogger<LogActionFilter> _logger;
        public LogActionFilter(ILogger<LogActionFilter> logger)
        {
            _logger = logger;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            _logger.LogInformation($"Action {context.ActionDescriptor.DisplayName} executing.");
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.Exception != null)
            {
                _logger.LogError(context.Exception, "Exception occurred.");
                context.ExceptionHandled = true;
                context.Result = new ContentResult
                {
                    Content = "Error occurred. Logged by custom filter."
                };
            }
            else
            {
                _logger.LogInformation($"Action {context.ActionDescriptor.DisplayName} executed successfully.");
            }
        }
    }
}
