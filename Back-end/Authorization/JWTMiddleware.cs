using Back_end.Entities;
using Back_end.Helper;
using Back_end.Models.User;
using Back_end.Respository;
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

        public async Task Invoke(HttpContext context, IUserRespository userRespository, IJwtUtils jwtUtils)
        {
            var token = context.Request.Headers["Authorization"].SingleOrDefault()?.Split(" ").Last();
            if (token != null)
            {

                var userIdExp = jwtUtils.ValidateJwtToken(token);
                if (userIdExp != null)
                {
                    // attach user to context on successful jwt validation
                    var arr = userIdExp.Split(" ");
                    User user = await userRespository.GetUser(Convert.ToString(arr[0]));
                    DateTime exp = Convert.ToDateTime(arr[1]);

                    if (user.IsDisable)
                    {
                        context.Response.StatusCode = 401;
                        return;
                    }

                    //if (user != null && exp != null)
                    if (user != null)
                    {
                        context.Items["UserTokenInfo"] = new MiddlewareInfo
                        {
                            User = user,
                            Exp = exp,
                            Token = token
                        };
                    }

                }
            }
            await _next(context);
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
