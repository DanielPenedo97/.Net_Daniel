namespace CarBuilder.HoraMiddleware;
public class HoraMiddleware
{
//1. Crie um middleware que adicione um cabeçalho personalizado a todas as respostas
//do servidor, trazendo a hora e o ip de cada solicitação feita para o servidor.
        private readonly RequestDelegate _next;
        private readonly ILogger<HoraMiddleware> _logger;

        public HoraMiddleware(RequestDelegate next, ILogger<HoraMiddleware> logger)
        {
            _next = next ?? throw new ArgumentNullException(nameof(next));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task Invoke(HttpContext context)
        {
            // Adicione o cabeçalho personalizado aqui
            context.Response.Headers.Add("Data-e-Horario", $"{DateTime.Now} - IP: {context.Connection.RemoteIpAddress}");

            // Chame o próximo middleware na cadeia
            await _next(context);
        }
}

public static class HoraMiddlewareExtensions
{
    public static IApplicationBuilder UseHoraMiddleware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<HoraMiddleware>();
    }
}
