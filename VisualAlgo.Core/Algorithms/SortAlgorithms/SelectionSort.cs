using VisualAlgo.Core.Abstractions;

namespace VisualAlgo.Core.Algorithms.SortAlgorithms;

public class SelectionSort : Algorithm
{
    public override T[] Execute<T>(T[] array) => Sort<T>(array);

    private static T[] Sort<T>(T[] array) where T : IComparable<T>
    {
        if (array == null) throw new  ArgumentNullException(nameof(array));
        
        T[] result = [..array];
        
        int length =  result.Length;
        for (int i = 0; i < length; i++)
        {
            int minIndex = i;

            for (int j = i+1; j < length; j++)
            {
                if (result[j].CompareTo(result[minIndex]) < 0)
                {
                    Swap(result, i, j);
                }
            }
        }

        return result;
    }

    private static void Swap<T>(T[] array, int index1, int index2) where T : IComparable<T>
    {
        (array[index1], array[index2]) = (array[index2], array[index1]);
    }
}