namespace LibResults;

public sealed record Received<TStatus>(TStatus status) : ISuccess;

public sealed record Received : ISuccess
{
    private Received() { }
    public static readonly Received Instance = new();
}