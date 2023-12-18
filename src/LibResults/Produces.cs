namespace LibResults;

public static class Produces
{
    public static Completed Completed() => LibResults.Completed.Instance;
    public static Completed<T> Completed<T>(T value) => new(value);
    public static Received<T> Received<T>(T value) => new(value);
    public static Created<T> Created<T>(T value) => new(value);

    public static NotFound NotFound() => LibResults.NotFound.Instance;
    public static NotFound NotFound(string message) => new(message);
    public static ValidationFailure ValidationFailed(IDictionary<string, string[]> errors) => new ValidationFailure(errors);
}