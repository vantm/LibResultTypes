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
        async (string city, IWeatherService svc, CancellationToken ct) => 
        {
            return svc.FetchAsync(city, ct);

            var (completed, notFound, validationFailure) = await svc.FetchAsync(city, ct);

            if (notFound is not null)
            {
                return Results.NotFound();
            }

            if (validationFailure is not null)
            {
                return Results.ValidationProblem(validationFailure.Errors);
            }

            return Results.Ok(completed!.Value);
        })
    .WithName("GetWeatherForecast")
    .WithOpenApi();

app.Run();