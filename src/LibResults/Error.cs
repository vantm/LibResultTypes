namespace LibResults;

public sealed record Error(string Message) : IFailure;