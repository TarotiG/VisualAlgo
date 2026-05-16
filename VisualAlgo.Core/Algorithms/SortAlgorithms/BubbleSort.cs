using VisualAlgo.Core.Abstractions;

namespace VisualAlgo.Core.Algorithms.SortAlgorithms;

public class BubbleSort : Algorithm
{
    public override T[] Execute<T>(T[] input)  => Sort<T>(input);
    
    public override int Execute<T>(T[] array, T target) => throw new NotImplementedException();

    private static T[] Sort<T>(T[] array) where T : IComparable<T>
    {
        if (array == null) throw new ArgumentNullException(nameof(array));

        T[] result = [..array];
        
        int length = result.Length;
        for (int i=0; i < length - 1; i++)
        {
            bool swapped = false;
            for (int j = 0; j < length - i - 1; j++)
            {
                if (result[j].CompareTo(result[j + 1]) > 0)
                {
                    Swap(result, j, j + 1);
                    swapped = true;
                }
            }
            if (!swapped) break;
        }
        
        return result;
    }

    private static void Swap<T>(T[] array, int index1, int index2)
    {
        (array[index1], array[index2]) = (array[index2], array[index1]);
    }
}