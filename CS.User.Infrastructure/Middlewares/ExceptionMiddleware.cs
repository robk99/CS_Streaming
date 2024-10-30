using CS.User.Infrastructure.Exceptions;
using Microsoft.AspNetCore.Http;
using Serilog;

namespace CS.User.Infrastructure.Middlewares
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;
        public ExceptionMiddleware(RequestDelegate next, ILogger logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                _logger.Error($"\nGUID: {httpContext.Request.Headers["X-Request-Guid"]}\n We encountered an InternalServerError Exception!: {ex.Message}");
                await new ResponseExceptionHandler().HandleExceptionAsync(httpContext);
            }
        }
    }
}
