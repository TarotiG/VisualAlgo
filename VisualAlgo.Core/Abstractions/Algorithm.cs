namespace  VisualAlgo.Core.Abstractions;

public abstract class Algorithm
{
    public abstract T[] Execute<T>(T[] array) where T : IComparable<T>;
}
