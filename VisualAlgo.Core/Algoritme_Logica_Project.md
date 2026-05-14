# Algoritme Logica voor C# Visualisatie Project

Dit document bevat de stapsgewijze logica (pseudocode) voor essentiële sorteer-, zoek- en padvindingsalgoritmes. Deze stappenplannen zijn ontworpen om direct vertaald te worden naar C# code met ondersteuning voor visualisatie-pauzes.

---

## 1. Sorteeralgoritmes (Sorting)

### Bubble Sort X
1.  Doorloop de lijst van `i = 0` tot `n-1`.
2.  Binnenste loop van `j = 0` tot `n-i-1`.
3.  **Vergelijk:** Is `lijst[j] > lijst[j+1]`?
4.  **Wissel:** Indien waar, wissel de twee elementen om.
5.  *Visualisatie:* Markeer `j` en `j+1` tijdens vergelijking; animeer de wissel.

### Selection Sort
1.  Doorloop de lijst van `i = 0` tot `n-1`.
2.  Stel `min_index = i`.
3.  Loop door ongesorteerde deel (`j = i+1` tot `n`):
    * **Vergelijk:** Is `lijst[j] < lijst[min_index]`?
    * Zo ja, stel `min_index = j`.
4.  **Wissel:** Wissel `lijst[i]` met `lijst[min_index]`.
5.  *Visualisatie:* Markeer de huidige `min_index` met een specifieke kleur.

### Insertion Sort
1.  Loop van `i = 1` tot `n`.
2.  Stel `sleutel = lijst[i]` en `j = i - 1`.
3.  Zolang `j >= 0` en `lijst[j] > sleutel`:
    * Verschuif `lijst[j]` naar `lijst[j+1]`.
    * Stel `j = j - 1`.
4.  Plaats `sleutel` op positie `j+1`.
5.  *Visualisatie:* Laat zien hoe de 'sleutel' wordt opgetild en elementen opzij schuiven.

### Quick Sort
1.  Kies een `pivot` (bijv. laatste element).
2.  **Partitioneren:**
    * Plaats alle elementen `< pivot` links.
    * Plaats alle elementen `> pivot` rechts.
3.  Pas Quick Sort recursief toe op de linker- en rechterkant.
4.  *Visualisatie:* Kleur de pivot apart en laat de verdeling rondom de pivot zien.

---

## 2. Zoekalgoritmes (Searching)

### Linear Search
1.  Loop van `i = 0` tot `n-1`.
2.  **Vergelijk:** Is `lijst[i] == doel`?
3.  Zo ja, geef `i` terug.
4.  *Visualisatie:* Scan door de lijst en licht elk gecontroleerd element op.

### Binary Search (Gesorteerde data vereist)
1.  Stel `links = 0` en `rechts = n-1`.
2.  Zolang `links <= rechts`:
    * Bereken `midden = links + (rechts - links) / 2`.
    * Is `lijst[midden] == doel`? Return `midden`.
    * Is `lijst[midden] < doel`? `links = midden + 1`.
    * Anders: `rechts = midden - 1`.
3.  *Visualisatie:* Maak het gebied dat 'geëlimineerd' wordt grijs.

---

## 3. Padvindingsalgoritmes (Pathfinding)

### Dijkstra's Algoritme
*Zoekt het kortste pad van een startpunt naar alle andere punten in een graaf.*

1.  Initialiseer een `Afstand` tabel: zet startpunt op 0 en alle andere knopen op oneindig ($\infty$).
2.  Maak een set `NietBezocht` met alle knopen.
3.  Zolang `NietBezocht` niet leeg is:
    * Kies de knoop `U` uit `NietBezocht` met de kleinste afstand.
    * Voor elke buur `V` van `U`:
        * Bereken `tijdelijkeAfstand = Afstand[U] + gewicht(U, V)`.
        * Als `tijdelijkeAfstand < Afstand[V]`:
            * Update `Afstand[V] = tijdelijkeAfstand`.
            * Sla op dat `U` de voorganger is van `V`.
    * Verwijder `U` uit `NietBezocht`.
4.  *Visualisatie:* Kleur de bezochte knopen en laat de afstandswaardes boven de knopen zien.

### A* Search
*Een verbeterde versie van Dijkstra die gebruikmaakt van een heuristiek (schatting) om sneller bij het doel te komen.*

1.  Maak een `OpenList` (te bezoeken) en een `ClosedList` (reeds bezocht).
2.  Voeg startknoop toe aan `OpenList`.
3.  Zolang `OpenList` niet leeg is:
    * Zoek knoop `N` in `OpenList` met de laagste $f(n)$, waarbij:
        * $g(n)$ = Kosten vanaf start tot nu toe.
        * $h(n)$ = Heuristische schatting (bijv. vogelvluchtafstand) tot het doel.
        * $f(n) = g(n) + h(n)$.
    * Als `N` het doel is: stop en reconstrueer pad.
    * Verplaats `N` van `OpenList` naar `ClosedList`.
    * Voor elke buur van `N`:
        * Als buur in `ClosedList`: sla over.
        * Bereken $g$ kosten voor buur.
        * Als buur niet in `OpenList` OF nieuwe $g$ < oude $g$:
            * Update buur: $g, h, f$ en zet `N` als ouder.
            * Voeg buur toe aan `OpenList` indien niet aanwezig.
4.  *Visualisatie:* Gebruik kleuren voor de Open/Closed sets en teken de berekende heuristiek-lijnen.

---

## C# Implementatie tips
* Gebruik `System.Diagnostics.Stopwatch` om de snelheid te meten.
* Gebruik een `PriorityQueue<T, TPriority>` voor Dijkstra en A* (beschikbaar in .NET 6+).
* Implementeer een `StepByStep` modus in je UI om handmatig door de algoritmes te klikken.
