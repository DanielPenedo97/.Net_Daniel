namespace CarBuilder.PinturaMiddleware;
public class PinturaMiddleware
{
    private readonly RequestDelegate _next;

    public PinturaMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        await context.Response.WriteAsync("Pintura built\n");
        await _next(context);
    }
}

public static class PinturaMiddlewareExtensions
{
    public static IApplicationBuilder UsePinturaMiddleware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<PinturaMiddleware>();
    }
}
