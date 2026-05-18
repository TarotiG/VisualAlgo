using VisualAlgo.Core.Algorithms.SearchAlgorithms;
using VisualAlgo.Core.Exceptions;

namespace VisualAlgo.Test.Algorithms.SearchAlgorithms;

public class LinearSearchTests
{
    private int[] Testdata = new[] { 3, 42, 45, 3, 22, 3, 5, 232, 5654, 643, 31, 323, 1, 456, 632, 34, 123,5436,76554,234,435634,87768,242,12,43254,7657,234,5456,31,12,1,465,7657,8768,989,786,786,75,87,345,65,214314543,6241,124235,56446,32,2131,43254657,22132,12543,563424,421312 };

    
    [Fact]
    public void LinearSearch_FindsTarget()
    {
        LinearSearch linearSearch = new();
        int target = 75;

        Assert.True(linearSearch.Execute(Testdata, target) == 37);
    }

    [Fact]
    public void LinearSearch_ThrowsWhenTargetIsNotInArray()
    {
        LinearSearch linearSearch = new();
        int target = int.MaxValue;
        Assert.Throws<SearchTargetNotFoundException>(() => linearSearch.Execute(Testdata, target));
    }

    [Fact]
    public void LinearSearch_ThrowsWhenArrayIsEmptyOrNull()
    {
        LinearSearch linearSearch = new();
        int[] array = null;
        int target = 75;
        
        Assert.Throws<ArgumentNullException>(() => linearSearch.Execute(array, target));
    }
}