namespace LibResults;

public static class Produces
{
    public static Completed Completed() => LibResults.Completed.Instance;
    public static Completed<T> Completed<T>(T value) => new(value);

    public static NotFound NotFound() => LibResults.NotFound.Instance;
    public static NotFound NotFound(string message) => new(message);
    public static Error Error(string message) => new(message);
    public static ValidationFailure ValidationFailed(IDictionary<string, string[]> errors) => new ValidationFailure(errors);
}