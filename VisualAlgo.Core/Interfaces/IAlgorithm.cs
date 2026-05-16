namespace VisualAlgo.Core;

public interface IAlgorithm
{
    string MeasureAlgorithmSpeed<T>(T[] array) where T : IComparable<T>;
    
    void VisualizeAlgorithmExecution();
    
    void AnalyzeAlgorithmComplexity();
}