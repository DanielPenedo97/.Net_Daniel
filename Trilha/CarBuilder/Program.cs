using CarBuilder.ChassiMiddleware;
using CarBuilder.MotorMiddleware;
using CarBuilder.PinturaMiddleware;
using CarBuilder.PortasMiddleware;
using CarBuilder.InternoMiddleware;
using CarBuilder.HoraMiddleware;
using CarBuilder.TimeRequestMiddleware;
using CarBuilder.CustomMiddleware;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

public void ConfigureServices(IServiceCollection services)
{
    // ... outras configurações

    services.AddLogging();

    // ... outras configurações
}


app.UseTimeRequestMiddleware();
app.UseHoraMiddleware();
app.UseChassiMiddleware();
app.UseMotorMiddleware();
app.UsePortasMiddleware();
app.UsePinturaMiddleware();
app.UsePortasMiddleware();
app.UseInternoMiddleware();

app.UseCustomMiddleware();


app.Run();
