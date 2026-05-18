using VisualAlgo.Core.Algorithms.SortAlgorithms;

namespace VisualAlgo.Test.Algorithms.SortAlgorithms;

public class QuickSortTests
{
    private int[] Testdata = new[] { 3, 42, 45, 3, 22, 3, 5, 232, 5654, 643, 31, 323, 1, 456, 632, 34, 123,5436,76554,234,435634,87768,242,12,43254,7657,234,5456,31,12,1,465,7657,8768,989,786,786,75,87,345,65,214314543,6241,124235,56446,32,2131,43254657,22132,12543,563424,421312 };
    
    [Fact]
    public void QuickSort_Sorts_Array()
    {
        QuickSort quickSort = new();
        int[] sorted = quickSort.Execute(Testdata);
        
        Assert.False(sorted.SequenceEqual(Testdata));
    }
    
    [Fact]
    public void QuickSort_Sort_ThrowsOnNull()
    {
        string[] data = null;
        QuickSort quickSort = new();
        
        Assert.Throws<ArgumentNullException>(() => quickSort.Execute(data));
    }
}