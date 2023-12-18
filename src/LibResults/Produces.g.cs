namespace LibResults;

public sealed record Produces<T1, T2>(T1? Result, T2? Error2)
    where T1 : ISuccess
    where T2 : IFailure
{
    public static implicit operator Produces<T1, T2>(T1 value)
        => new(value, default);
    public static implicit operator Produces<T1, T2>(T2 error)
        => new(default, error);
}
public sealed record Produces<T1, T2, T3>(T1? Result, T2? Error2, T3? Error3)
    where T1 : ISuccess
    where T2 : IFailure
    where T3 : IFailure
{
    public static implicit operator Produces<T1, T2, T3>(T1 value)
        => new(value, default, default);
    public static implicit operator Produces<T1, T2, T3>(T2 error)
        => new(default, error, default);
    public static implicit operator Produces<T1, T2, T3>(T3 error)
        => new(default, default, error);
}
public sealed record Produces<T1, T2, T3, T4>(T1? Result, T2? Error2, T3? Error3, T4? Error4)
    where T1 : ISuccess
    where T2 : IFailure
    where T3 : IFailure
    where T4 : IFailure
{
    public static implicit operator Produces<T1, T2, T3, T4>(T1 value)
        => new(value, default, default, default);
    public static implicit operator Produces<T1, T2, T3, T4>(T2 error)
        => new(default, error, default, default);
    public static implicit operator Produces<T1, T2, T3, T4>(T3 error)
        => new(default, default, error, default);
    public static implicit operator Produces<T1, T2, T3, T4>(T4 error)
        => new(default, default, default, error);
}
public sealed record Produces<T1, T2, T3, T4, T5>(T1? Result, T2? Error2, T3? Error3, T4? Error4, T5? Error5)
    where T1 : ISuccess
    where T2 : IFailure
    where T3 : IFailure
    where T4 : IFailure
    where T5 : IFailure
{
    public static implicit operator Produces<T1, T2, T3, T4, T5>(T1 value)
        => new(value, default, default, default, default);
    public static implicit operator Produces<T1, T2, T3, T4, T5>(T2 error)
        => new(default, error, default, default, default);
    public static implicit operator Produces<T1, T2, T3, T4, T5>(T3 error)
        => new(default, default, error, default, default);
    public static implicit operator Produces<T1, T2, T3, T4, T5>(T4 error)
        => new(default, default, default, error, default);
    public static implicit operator Produces<T1, T2, T3, T4, T5>(T5 error)
        => new(default, default, default, default, error);
}
public sealed record Produces<T1, T2, T3, T4, T5, T6>(T1? Result, T2? Error2, T3? Error3, T4? Error4, T5? Error5, T6? Error6)
    where T1 : ISuccess
    where T2 : IFailure
    where T3 : IFailure
    where T4 : IFailure
    where T5 : IFailure
    where T6 : IFailure
{
    public static implicit operator Produces<T1, T2, T3, T4, T5, T6>(T1 value)
        => new(value, default, default, default, default, default);
    public static implicit operator Produces<T1, T2, T3, T4, T5, T6>(T2 error)
        => new(default, error, default, default, default, default);
    public static implicit operator Produces<T1, T2, T3, T4, T5, T6>(T3 error)
        => new(default, default, error, default, default, default);
    public static implicit operator Produces<T1, T2, T3, T4, T5, T6>(T4 error)
        => new(default, default, default, error, default, default);
    public static implicit operator Produces<T1, T2, T3, T4, T5, T6>(T5 error)
        => new(default, default, default, default, error, default);
    public static implicit operator Produces<T1, T2, T3, T4, T5, T6>(T6 error)
        => new(default, default, default, default, default, error);
}
public sealed record Produces<T1, T2, T3, T4, T5, T6, T7>(T1? Result, T2? Error2, T3? Error3, T4? Error4, T5? Error5, T6? Error6, T7? Error7)
    where T1 : ISuccess
    where T2 : IFailure
    where T3 : IFailure
    where T4 : IFailure
    where T5 : IFailure
    where T6 : IFailure
    where T7 : IFailure
{
    public static implicit operator Produces<T1, T2, T3, T4, T5, T6, T7>(T1 value)
        => new(value, default, default, default, default, default, default);
    public static implicit operator Produces<T1, T2, T3, T4, T5, T6, T7>(T2 error)
        => new(default, error, default, default, default, default, default);
    public static implicit operator Produces<T1, T2, T3, T4, T5, T6, T7>(T3 error)
        => new(default, default, error, default, default, default, default);
    public static implicit operator Produces<T1, T2, T3, T4, T5, T6, T7>(T4 error)
        => new(default, default, default, error, default, default, default);
    public static implicit operator Produces<T1, T2, T3, T4, T5, T6, T7>(T5 error)
        => new(default, default, default, default, error, default, default);
    public static implicit operator Produces<T1, T2, T3, T4, T5, T6, T7>(T6 error)
        => new(default, default, default, default, default, error, default);
    public static implicit operator Produces<T1, T2, T3, T4, T5, T6, T7>(T7 error)
        => new(default, default, default, default, default, default, error);
}
