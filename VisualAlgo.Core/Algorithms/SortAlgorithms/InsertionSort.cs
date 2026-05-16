using VisualAlgo.Core.Abstractions;

namespace VisualAlgo.Core.Algorithms.SortAlgorithms;

public class InsertionSort : Algorithm
{
    public override T[] Execute<T>(T[] input) => Sort<T>(input);
    
    public override int Execute<T>(T[] array, T target) => throw new NotImplementedException();

    private static T[] Sort<T>(T[] array) where T : IComparable<T>
    {
        if (array == null) throw new ArgumentNullException(nameof(array));

        T[] result = [..array];
        
        int length = result.Length;
        for (int i = 1; i < length; i++)
        {
            T key =  result[i];
            int j = i - 1;

            while (j >= 0 && result[j].CompareTo(key) > 0)
            {
                Shift(result, j);
                j--;
            }
            
            result[j + 1] = key;
        }

        return result;
    }

    private static void Shift<T>(T[] array, int index)
    {
        array[index + 1] = array[index];
    }
}