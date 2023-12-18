using LibResults;

namespace LibResultTypes.HttpResults.ManualTests;

public interface IWeatherService
{
    Task<Produces<Completed<WeatherForecast>, NotFound, ValidationFailure>> FetchAsync(string city, CancellationToken cancellationToken = default);
}