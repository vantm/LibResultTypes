namespace LibResults;

public sealed record ValidationFailure(IDictionary<string, string[]> Errors) : IFailure;