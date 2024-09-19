using CS.Media.Infrastructure.Dtos;
using Microsoft.AspNetCore.Http;
using System.Net;

namespace CS.Media.Infrastructure.Exceptions
{
    public class ResponseExceptionHandler
    {
        public Task HandleExceptionAsync(HttpContext context)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            return context.Response.WriteAsync(new ExceptionDto()
            {
                StatusCode = context.Response.StatusCode,
                Message = "We're having some server difficulties. Out team is notified and will try to fix this problem as soon as possible."
            }.ToString());
        }
    }
}
