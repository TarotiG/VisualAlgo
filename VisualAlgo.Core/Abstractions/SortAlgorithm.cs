namespace VisualAlgo.Core.Abstractions;

public abstract class SortAlgorithm : AlgorithmBase
{
    public abstract T[] Execute<T>(T[] array) where T : IComparable<T>;
}