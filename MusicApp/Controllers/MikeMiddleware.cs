using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace MusicApp
{
    public class MikeMiddleware
    {
        private readonly RequestDelegate _next;
        public MikeMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            if (context.Request.Headers.ContainsKey("Authorization"))
            {
                var basicToken = context.Request.Headers["Authorization"].ToString();
                basicToken = basicToken.Replace("Basic", "");
                await _next(context);
            }
            else
            {
                context.Response.StatusCode = 403;
                await context.Response.WriteAsync("HIHE");
            }
        }
    }
    public static class MikeMiddlewareExtensions
    {
        public static IApplicationBuilder UseMikeMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MikeMiddleware>();
        }
    }
}