namespace VictorKrogh.NET.Model.ModelBuilder;

public interface IModelBuilder
{
}

public interface IModelBuilder<in TIn, TOut> : IModelBuilder
{
    Task<TOut> BuildAsync(TIn input);
}

