using VisualAlgo.Core.Abstractions;
using VisualAlgo.Core.Exceptions;

namespace VisualAlgo.Core.Algorithms.SearchAlgorithms;

public class BinarySearch : SearchAlgorithm
{
    public override int Execute<T>(T[] array, T target) => throw new NotImplementedException();

    private int Search<T>(T[] array, T target) where T : IComparable<T>
    {
        int left = 0;
        int right = array.Length - 1;

        while (left <= right)
        {
            int middle = left + (right - left) / 2;
            
            if (array[middle].CompareTo(target) == 0) return middle;
            
            if (array[middle].CompareTo(target) < 0) left = middle + 1;
            else right = middle - 1;
        }
        
        throw new SearchTargetNotFoundException($"Target: {target} not found in array");
    }
}

// 1.  Stel `links = 0` en `rechts = n-1`.
// 2.  Zolang `links <= rechts`:
// * Bereken `midden = links + (rechts - links) / 2`.
// * Is `lijst[midden] == doel`? Return `midden`.
// * Is `lijst[midden] < doel`? `links = midden + 1`.
// * Anders: `rechts = midden - 1`.
// 3a.  *Visualisatie:* Maak het gebied dat 'geëlimineerd' wordt grijs.
// 3b.  *Visualisatie:* Leuk om te laten zien hoe sortering de tijdscomplexiteit kan beinvloeden.