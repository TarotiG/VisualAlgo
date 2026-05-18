namespace VisualAlgo.Core.Algorithms.PathfindingAlgorithms;

public class AstarAlgorithm
{
    
}

// ### A* Search
// *Een verbeterde versie van Dijkstra die gebruikmaakt van een heuristiek (schatting) om sneller bij het doel te komen.*
//
//     1.  Maak een `OpenList` (te bezoeken) en een `ClosedList` (reeds bezocht).
// 2.  Voeg startknoop toe aan `OpenList`.
// 3.  Zolang `OpenList` niet leeg is:
// * Zoek knoop `N` in `OpenList` met de laagste $f(n)$, waarbij:
// * $g(n)$ = Kosten vanaf start tot nu toe.
// * $h(n)$ = Heuristische schatting (bijv. vogelvluchtafstand) tot het doel.
// * $f(n) = g(n) + h(n)$.
// * Als `N` het doel is: stop en reconstrueer pad.
// * Verplaats `N` van `OpenList` naar `ClosedList`.
// * Voor elke buur van `N`:
// * Als buur in `ClosedList`: sla over.
// * Bereken $g$ kosten voor buur.
// * Als buur niet in `OpenList` OF nieuwe $g$ < oude $g$:
// * Update buur: $g, h, f$ en zet `N` als ouder.
// * Voeg buur toe aan `OpenList` indien niet aanwezig.
// 4.  *Visualisatie:* Gebruik kleuren voor de Open/Closed sets en teken de berekende heuristiek-lijnen.