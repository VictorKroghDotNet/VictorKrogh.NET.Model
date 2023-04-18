namespace VictorKrogh.NET.Model.ModelBuilder;

public abstract class ModelBuilderBase<TIn, TOut> : IModelBuilder<TIn, TOut>
    where TOut : class
{
    public abstract Task<TOut> BuildAsync(TIn input);
}

public static class AsyncEnumerableExtensions
{
    public static async Task<List<T>> ToListAsync<T>(this IAsyncEnumerable<T> items, CancellationToken cancellationToken = default)
    {
        var list = new List<T>();
        await foreach (var item in items.WithCancellation(cancellationToken).ConfigureAwait(false))
        {
            list.Add(item);
        }
        return list;
    }
}