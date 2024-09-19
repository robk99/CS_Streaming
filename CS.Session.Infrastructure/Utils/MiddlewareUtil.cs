using CS.Session.Infrastructure.Middlewares;
using Microsoft.AspNetCore.Builder;

namespace CS.Session.Infrastructure.Utils
{
    public static class MiddlewareUtil
    {
        public static IApplicationBuilder UseCustomExceptionHandlingMiddleware(this WebApplication app)
        {
            return app.UseMiddleware<ExceptionMiddleware>();
        }
    }
}
