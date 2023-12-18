namespace LibResults;

public sealed record Created<T>(T Value) : ISuccess;