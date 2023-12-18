namespace LibResults;

public sealed record NotFound : IFailure
{
    internal NotFound(string message)
    {
#if NET7_0_OR_GREATER
        ArgumentException.ThrowIfNullOrEmpty(message, nameof(message));
#else
        if(string.IsNullOrWhiteSpace(message))
        {
            throw new ArgumentNullException(nameof(message), message);
        }
#endif
        Message = message;
    }

    private NotFound() { }

    public static readonly NotFound Instance = new();
    public string? Message { get; }
}