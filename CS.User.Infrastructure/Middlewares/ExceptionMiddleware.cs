using CS.User.Infrastructure.Exceptions;
using Microsoft.AspNetCore.Http;

namespace CS.User.Infrastructure.Middlewares
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                // TODO: Log
                Console.WriteLine($"\nGUID: {httpContext.Request.Headers["X-Request-Guid"]}\n We encountered an InternalServerError Exception!: {ex.Message}");
                await new ResponseExceptionHandler().HandleExceptionAsync(httpContext);
            }
        }
    }
}
