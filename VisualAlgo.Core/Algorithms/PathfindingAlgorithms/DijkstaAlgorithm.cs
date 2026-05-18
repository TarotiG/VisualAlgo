namespace VisualAlgo.Core.Algorithms.PathfindingAlgorithms;

public class DijkstaAlgorithm
{
    
}

// ### Dijkstra's Algoritme
// *Zoekt het kortste pad van een startpunt naar alle andere punten in een graaf.*
//
//     1.  Initialiseer een `Afstand` tabel: zet startpunt op 0 en alle andere knopen op oneindig ($\infty$).
// 2.  Maak een set `NietBezocht` met alle knopen.
// 3.  Zolang `NietBezocht` niet leeg is:
// * Kies de knoop `U` uit `NietBezocht` met de kleinste afstand.
// * Voor elke buur `V` van `U`:
// * Bereken `tijdelijkeAfstand = Afstand[U] + gewicht(U, V)`.
// * Als `tijdelijkeAfstand < Afstand[V]`:
// * Update `Afstand[V] = tijdelijkeAfstand`.
// * Sla op dat `U` de voorganger is van `V`.
// * Verwijder `U` uit `NietBezocht`.
// 4.  *Visualisatie:* Kleur de bezochte knopen en laat de afstandswaardes boven de knopen zien.