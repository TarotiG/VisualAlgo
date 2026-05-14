using System.Collections.Concurrent;
using VisualAlgo.Core.Abstractions;

namespace VisualAlgo.Core.Algorithms.SortAlgorithms;

public class QuickSort : Algorithm
{
    public override T[] Execute<T>(T[] input) => Sort(input, 0, input.Length - 1);

    private T[] Sort<T>(T[] array, int low, int high) where T : IComparable<T>
    {
        if (low < high)
        {
            int pivotIndex = Partition(array, low, high);
            
            Sort(array, low, pivotIndex - 1);
            Sort(array, pivotIndex + 1, high);
        }

        return array;
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