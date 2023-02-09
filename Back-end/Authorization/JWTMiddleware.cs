using Back_end.Helper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;

namespace Back_end.Authorization
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class JWTMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly AppSettings _appSetting;

        public JWTMiddleware(RequestDelegate next, IOptions<AppSettings> appSetting)
        {
            _next = next;
            _appSetting = appSetting.Value;
        }

        public Task Invoke(HttpContext httpContext)
        {

            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class JWTMiddlewareExtensions
    {
        public static IApplicationBuilder UseJWTMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<JWTMiddleware>();
        }
    }
}
