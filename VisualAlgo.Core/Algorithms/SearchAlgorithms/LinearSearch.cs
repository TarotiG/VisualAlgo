using VisualAlgo.Core.Abstractions;
using VisualAlgo.Core.Exceptions;

namespace VisualAlgo.Core.Algorithms.SearchAlgorithms;

public class LinearSearch : Algorithm
{
    public override int Execute<T>(T[] array, T target)
    {
        return Search(array, target);
    }
    
    public override T[] Execute<T>(T[] array) => throw new NotImplementedException();

    private int Search<T>(T[] array, T target) where T : IComparable<T>
    {
        if (array == null || array.Length == 0) throw new ArgumentNullException(nameof(array));
        ArgumentNullException.ThrowIfNull(target);

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].CompareTo(target) == 0)
            {
                return i;
            }
        }
    
        throw new SearchTargetNotFoundException($"Target: {target} not found in array");
    }
}