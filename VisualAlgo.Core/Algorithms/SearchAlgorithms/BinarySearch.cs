using VisualAlgo.Core.Abstractions;

namespace VisualAlgo.Core.Algorithms.SearchAlgorithms;

public class BinarySearch : SearchAlgorithm
{
    public override int Execute<T>(T[] array, T target) => throw new NotImplementedException();

    private int Search<T>(T[] array, T target) where T : IComparable<T>
    {
        throw new NotImplementedException();
    }
}

// 1.  Stel `links = 0` en `rechts = n-1`.
// 2.  Zolang `links <= rechts`:
// * Bereken `midden = links + (rechts - links) / 2`.
// * Is `lijst[midden] == doel`? Return `midden`.
// * Is `lijst[midden] < doel`? `links = midden + 1`.
// * Anders: `rechts = midden - 1`.
// 3.  *Visualisatie:* Maak het gebied dat 'geëlimineerd' wordt grijs.