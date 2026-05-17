using System.Diagnostics;

namespace  VisualAlgo.Core.Abstractions;

public abstract class AlgorithmBase : IAlgorithm
{
    public string MeasureSortAlgorithmSpeed<T>(T[] array, Func<T[], T[]> executor) where T : IComparable<T>
    {
        Stopwatch stopwatch = new();
        
        stopwatch.Start();
        executor(array);
        stopwatch.Stop();

        return this.ParseTime(stopwatch.ElapsedMilliseconds);
    }
    
    public string MeasureSearchAlgorithmSpeed<T>(T[] array, T target, Func<T[], T, T> executor) where T : IComparable<T>
    {
        Stopwatch stopwatch = new();
        
        stopwatch.Start();
        executor(array, target);
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
