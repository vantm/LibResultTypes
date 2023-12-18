using LibResults;

using Microsoft.AspNetCore.Http.HttpResults;

using NotFound = Microsoft.AspNetCore.Http.HttpResults.NotFound;

namespace LibResultTypes.HttpResults.ManualTests;

public static partial class LibResultsMapper
{
    public static Results<Ok<WeatherForecast>, NotFound, ValidationProblem> ToHttpResult(
        this Produces<Completed<WeatherForecast>, LibResults.NotFound, ValidationFailure> results)
    {
        var (completed, notFound, validationFailure) = results;

        if (notFound is not null)
        {
            return TypedResults.NotFound();
        }

        if (validationFailure is not null)
        {
            return TypedResults.ValidationProblem(validationFailure.Errors);
        }

        return TypedResults.Ok(completed!.Value);
    }

    public static async Task<Results<Ok<WeatherForecast>, NotFound, ValidationProblem>> ToHttpResult(
        this Task<Produces<Completed<WeatherForecast>, LibResults.NotFound, ValidationFailure>> resultsTask)
    {
        var results = await resultsTask;
        return results.ToHttpResult();
    }
}
