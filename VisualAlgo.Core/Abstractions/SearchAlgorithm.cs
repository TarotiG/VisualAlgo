namespace VisualAlgo.Core.Abstractions;

public abstract class SearchAlgorithm : AlgorithmBase
{
    protected int StepCounter { get; set; } = 0;

    public abstract int Execute<T>(T[] array, T target) where T : IComparable<T>;

    public string GetStepCounter()
    {
        return $"Steps required to find target using {GetType().Name}: {StepCounter}";
    }
}