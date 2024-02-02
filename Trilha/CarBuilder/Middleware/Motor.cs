namespace CarBuilder.MotorMiddleware;
public class MotorMiddleware
{
    private readonly RequestDelegate _next;

    public MotorMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        await context.Response.WriteAsync("Motor built\n");
        await _next(context);
    }
}

public static class MotorMiddlewareExtensions
{
    public static IApplicationBuilder UseMotorMiddleware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<MotorMiddleware>();
    }
}