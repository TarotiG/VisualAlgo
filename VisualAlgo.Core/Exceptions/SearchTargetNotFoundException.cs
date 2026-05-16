namespace VisualAlgo.Core.Exceptions;

public class SearchTargetNotFoundException : Exception
{
    public SearchTargetNotFoundException(string? message) : base(message)
    {
    }
    
    public SearchTargetNotFoundException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}