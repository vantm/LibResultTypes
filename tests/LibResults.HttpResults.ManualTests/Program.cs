using LibResultTypes.HttpResults.ManualTests;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddHttpLogging(_ => { });

builder.Services.AddSingleton<IWeatherService, WeatherService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpLogging();

app.UseHttpsRedirection();

app.MapGet("/weatherforecast",
        (string city, IWeatherService svc, CancellationToken ct) => svc.FetchAsync(city, ct).ToHttpResult())
    .WithName("GetWeatherForecast")
    .WithOpenApi();

app.Run();