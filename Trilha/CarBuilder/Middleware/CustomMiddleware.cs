using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CarBuilder.CustomMiddleware;

public class CustomMiddleware
{
    private readonly RequestDelegate _next;

    private readonly ILogger<CustomMiddleware> _logger;

    public CustomMiddleware(RequestDelegate next, ILogger<CustomMiddleware> logger)
    {
        _next = next ?? throw new ArgumentNullException(nameof(next));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }
    public async Task Invoke(HttpContext context)
    {
        await _next(context);
        await EnviarJsonParaEndpoint(context);
    }

    private async Task EnviarJsonParaEndpoint(HttpContext context)
    {
        // Montar os dados a serem enviados no JSON
        var jsonData = new
        {
            Timestamp = DateTime.Now,
            RequestPath = context.Request.Path,
            RequestMethod = context.Request.Method,
            // Adicione mais informações conforme necessário
        };

        // Serializar o objeto JSON
        var jsonString = JsonConvert.SerializeObject(jsonData);
        var content = new StringContent(jsonString, Encoding.UTF8, "application/json");

        // Configurar o HttpClient
        using (var httpClient = new HttpClient())
        {
            // Definir o endpoint específico
            var endpointUrl = "http://localhost:5113";

            // Enviar a requisição POST para o endpoint
            var response = await httpClient.PostAsync(endpointUrl, content);

            // Verificar a resposta, lidar com erros ou logar conforme necessário
            if (response.IsSuccessStatusCode){
                // Logar ou imprimir no console que a requisição foi bem-sucedida
                _logger.LogInformation("Requisição para o endpoint bem-sucedida");
                Console.WriteLine("Requisição para o endpoint bem-sucedida");
            }

            else
            {
                // Lidar com erro, por exemplo, logar a resposta
                var errorResponse = await response.Content.ReadAsStringAsync();
                // Logar ou tratar de acordo com os requisitos
            }
        }
    }
}

public static class CustomMiddlewareExtensions
{
    public static IApplicationBuilder UseCustomMiddleware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<CustomMiddleware>();
    }
}


