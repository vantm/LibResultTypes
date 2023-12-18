namespace LibResults;

public sealed record Completed : ISuccess
{
    private Completed() { }
    public static readonly Completed Instance = new();
}

public sealed record Completed<T>(T Value) : ISuccess;