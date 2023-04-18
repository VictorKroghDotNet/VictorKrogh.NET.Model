namespace VictorKrogh.NET.Model.ModelBuilder;

public interface IEnumerableModelBuilder<in TIn, TOut> : IModelBuilder
{
    Task<IEnumerable<TOut>> BuildAsync(IEnumerable<TIn> input);
}

