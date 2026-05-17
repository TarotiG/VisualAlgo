namespace VisualAlgo.Core;

public interface IAlgorithm
{
    public string MeasureSortAlgorithmSpeed<T>(T[] array, Func<T[], T[]> executor) where T : IComparable<T>;
    
    string MeasureSearchAlgorithmSpeed<T>(T[] array, T target, Func<T[], T, T> executor) where T : IComparable<T>;
    
    void VisualizeAlgorithmExecution();
    
    void AnalyzeAlgorithmComplexity();
}