namespace VictorKrogh.NET.Model.ModelBuilder;

public abstract class ModelBuilderBase<TIn, TOut> : IModelBuilder<TIn, TOut>
    where TOut : class
{
    public abstract Task<TOut> BuildAsync(TIn input);
}


