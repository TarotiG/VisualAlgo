using VisualAlgo.Core.Algorithms;
using VisualAlgo.Core.Algorithms.SortAlgorithms;

public class Program
{
    public static void Main(string[] args)
    {
        BubbleSort bubbleSort = new();
        SelectionSort selectionSort = new();
        
        // data
        int[] array = new[] { 3, 42, 45, 3, 22, 3, 5, 232, 5654, 643, 31, 323, 1, 456, 632, 34 };
        
        // execution
        int[] bubbleSorted = bubbleSort.Execute(array);
        int[] selectionSorted = selectionSort.Execute(array);
        
        Console.WriteLine("#### Starting loop for Bubble Sort");
        foreach (int i in bubbleSorted)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("####  End of Bubble Sort");
        
        Console.WriteLine("#### Starting loop for Selection Sort");
        foreach (int i in selectionSorted)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("####  End of Selection Sort");
    }
}
