using VisualAlgo.Core.Abstractions;

namespace VisualAlgo.Core.Algorithms.SearchAlgorithms;

public class BinarySearch : Algorithm
{
    public override T[] Execute<T>(T[] array) => throw new NotImplementedException();
    
    public override int Execute<T>(T[] array, T target) => throw new NotImplementedException();
}

// 1.  Stel `links = 0` en `rechts = n-1`.
// 2.  Zolang `links <= rechts`:
// * Bereken `midden = links + (rechts - links) / 2`.
// * Is `lijst[midden] == doel`? Return `midden`.
// * Is `lijst[midden] < doel`? `links = midden + 1`.
// * Anders: `rechts = midden - 1`.
// 3.  *Visualisatie:* Maak het gebied dat 'geëlimineerd' wordt grijs.