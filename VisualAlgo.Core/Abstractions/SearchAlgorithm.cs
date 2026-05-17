namespace VisualAlgo.Core.Abstractions;

public abstract class SearchAlgorithm : AlgorithmBase
{
    public abstract int Execute<T>(T[] array, T target) where T : IComparable<T>;
}