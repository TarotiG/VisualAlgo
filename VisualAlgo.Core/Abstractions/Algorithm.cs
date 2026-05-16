using System.Diagnostics;

namespace  VisualAlgo.Core.Abstractions;

public abstract class Algorithm : IAlgorithm
{
    public abstract T[] Execute<T>(T[] array) where T : IComparable<T>;
    
    public abstract int Execute<T>(T[] array, T target) where T : IComparable<T>;

    public string MeasureAlgorithmSpeed<T>(T[] array) where T : IComparable<T>
    {
        Stopwatch stopwatch = new();
        
        stopwatch.Start();
        Execute(array);
        stopwatch.Stop();

        return this.ParseTime(stopwatch.ElapsedMilliseconds);
    }
    
    private string ParseTime(long time)
    {
        return $"{time} ms";
    }

    public void VisualizeAlgorithmExecution() => throw new NotImplementedException();
    public void AnalyzeAlgorithmComplexity() => throw new NotImplementedException();
}
