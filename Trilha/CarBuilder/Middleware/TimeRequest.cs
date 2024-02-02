namespace CarBuilder.TimeRequestMiddleware;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

public class TimeRequestMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<TimeRequestMiddleware> _logger;

    public TimeRequestMiddleware(RequestDelegate next, ILogger<TimeRequestMiddleware> logger)
    {
        _next = next ?? throw new ArgumentNullException(nameof(next));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public async Task Invoke(HttpContext context)
    {
        var stopwatch = Stopwatch.StartNew();

        try
        {
            // Chame o próximo middleware na cadeia
            await _next(context);
        }
        finally
        {
            stopwatch.Stop();

            // Registre o tempo de duração da requisição em microssegundos
            var elapsedMicroseconds = stopwatch.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));
            _logger.LogInformation($"Request duration: {elapsedMicroseconds} µs");
        }
    }
}

public static class TimeRequestMiddlewareExtensions
{
    public static IApplicationBuilder UseTimeRequestMiddleware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<TimeRequestMiddleware>();
    }
}

