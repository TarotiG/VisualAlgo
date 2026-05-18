using VisualAlgo.Core.Algorithms.SearchAlgorithms;
using VisualAlgo.Core.Algorithms.SortAlgorithms;

public class Program
{
    public static void Main(string[] args)
    {
        // sort
        BubbleSort bubbleSort = new();
        SelectionSort selectionSort = new();
        InsertionSort insertionSort = new();
        QuickSort quickSort = new();
        
        // search
        LinearSearch linearSearch = new();
        BinarySearch binarySearch = new();
        
        // data
        int[] array = new[] { 3, 42, 45, 3, 22, 3, 5, 232, 5654, 643, 31, 323, 1, 456, 632, 34, 123,5436,76554,234,435634,87768,242,12,43254,7657,234,5456,31,12,1,465,7657,8768,989,786,786,75,87,345,65,214314543,6241,124235,56446,32,2131,43254657,22132,12543,563424,421312 };
        
        // execution sort
        int[] bubbleSorted = bubbleSort.Execute(array);
        int[] selectionSorted = selectionSort.Execute(array);
        int[] insertionSorted = insertionSort.Execute(array);
        int[] quickSorted = quickSort.Execute(array);
        
        // execution search
        int target = 75;
        int linearSearchIndex = linearSearch.Execute(array, target);
        int binarySearchIndex = binarySearch.Execute(bubbleSorted, target);
        Console.WriteLine($"Target: {target} found at index: {linearSearchIndex} using linear search algorithm");
        Console.WriteLine($"Target: {target} found at index: {binarySearchIndex} using binary search algorithm");
        Console.WriteLine(linearSearch.GetStepCounter());
        Console.WriteLine(binarySearch.GetStepCounter());
        
        // Algorithms speeds
        Console.WriteLine($"Sort Algorithm speed: {bubbleSort.MeasureSortAlgorithmSpeed(array, bubbleSort.Execute)}");
        Console.WriteLine($"Search Algorithm speed: {linearSearch.MeasureSearchAlgorithmSpeed(array, target, linearSearch.Execute)}");
    }
}
