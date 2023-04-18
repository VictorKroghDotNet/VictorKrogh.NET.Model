namespace VictorKrogh.NET.Model.ModelBuilder;

public abstract class EnumerableModelBuilderBase<TIn, TOut> : ModelBuilderBase<TIn, TOut>, IEnumerableModelBuilder<TIn, TOut>
    where TOut : class
{
    public async Task<IEnumerable<TOut>> BuildAsync(IEnumerable<TIn> input)
    {
        if (input == default)
        {
            return Enumerable.Empty<TOut>();
        }

        return await BuildItemsAsync(input).ToListAsync();
    }

    private async IAsyncEnumerable<TOut> BuildItemsAsync(IEnumerable<TIn> input)
    {
        foreach (var item in input)
        {
            var output = await BuildAsync(item);
            if (output == default)
            {
                continue;
            }

            yield return output;
        }
    }
}
