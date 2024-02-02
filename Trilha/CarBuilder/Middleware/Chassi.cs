using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace CarBuilder.ChassiMiddleware;

public class ChassiMiddleware
{
    private readonly RequestDelegate _next;

    public ChassiMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        await context.Response.WriteAsync("Chassi built\n");
        await _next(context);
    }
}

public static class ChassiMiddlewareExtensions
{
    public static IApplicationBuilder UseChassiMiddleware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<ChassiMiddleware>();
    }
}

