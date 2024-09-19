using CS.Media.Infrastructure.Middlewares;
using Microsoft.AspNetCore.Builder;

namespace CS.Media.Infrastructure.Utils
{
    public static class MiddlewareUtil
    {
        public static IApplicationBuilder UseCustomExceptionHandlingMiddleware(this WebApplication app)
        {
            return app.UseMiddleware<ExceptionMiddleware>();
        }
    }
}
