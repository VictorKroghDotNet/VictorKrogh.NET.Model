namespace VictorKrogh.NET.Model.ModelBuilder;

public interface IEnumerableModelBuilder<in TIn, TOut> : IModelBuilder<TIn, TOut>
{
    Task<IEnumerable<TOut>> BuildAsync(IEnumerable<TIn> input);
}

