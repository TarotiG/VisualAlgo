using System.Collections.Concurrent;
using VisualAlgo.Core.Abstractions;

namespace VisualAlgo.Core.Algorithms.SortAlgorithms;

public class QuickSort : SortAlgorithm
{
    public override T[] Execute<T>(T[] input)
    {
        if (input == null || input.Length == 0) throw new ArgumentNullException(nameof(input));
        return Sort(input, 0, input.Length - 1);
    }
    

    private T[] Sort<T>(T[] array, int low, int high) where T : IComparable<T>
    {
        T[] result = [..array];
        if (low < high)
        {
            int pivotIndex = Partition(result, low, high);
            
            Sort(result, low, pivotIndex - 1);
            Sort(result, pivotIndex + 1, high);
        }

        return result;
    }

    private int Partition<T>(T[] array, int  low, int high) where T : IComparable<T>
    {
        T pivot = array[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (array[j].CompareTo(pivot) <= 0)
            {
                i++;
                Swap(array, i, j);
            }
        }
        
        Swap(array, i + 1, high);
        return i + 1;
    }
    
    private void Swap<T>(T[] array, int i, int j)
    {
        (array[i], array[j]) = (array[j], array[i]);
    }
}