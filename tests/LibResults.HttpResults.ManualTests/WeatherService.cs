using LibResults;

namespace LibResultTypes.HttpResults.ManualTests;

public sealed class WeatherService : IWeatherService
{
    private static readonly string[] Summaries = ["Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"];

    public async Task<Produces<Completed<WeatherForecast>, NotFound, ValidationFailure>> FetchAsync(
        string city, CancellationToken cancellationToken = default)
    {
        // This is cheat, do not use in the real code.
        await Task.CompletedTask;

        if (string.IsNullOrWhiteSpace(city))
        {
            return Produces.ValidationFailed(Errors.NullCityParameter);
        }

        if (city.Contains(' '))
        {
            return Produces.NotFound();
        }

        var weather = new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Today),
            Random.Shared.Next(-20, 55),
            Summaries[Random.Shared.Next(Summaries.Length)]
        );

        return Produces.Completed(weather);
    }

    private static class Errors
    {
        public static readonly Dictionary<string, string[]> NullCityParameter = new() { { "city", ["This field is required"] } };
    }
}