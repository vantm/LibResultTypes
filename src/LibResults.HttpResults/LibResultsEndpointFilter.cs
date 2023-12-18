namespace LibResults.HttpResults;

public sealed class LibResultsEndpointFilter : IEndpointFilter
{
    public virtual async ValueTask<object?> InvokeAsync(
        EndpointFilterInvocationContext context,
        EndpointFilterDelegate next)
    {
        var result = await next(context);
        return result;
    }
}