namespace Enterprise.Domains;

public class Result<T>
{
    private Result(T? value)
    {
        FlagSuccess = true;
        Value = value;
    }
    
    private Result(ErrorCode errorCode)
    {
        FlagSuccess = false;
        ErrorCode = errorCode;
    }
    
    public bool FlagSuccess { get; }
    public T? Value { get; }
    public ErrorCode ErrorCode { get; }

    public static Result<T?> Success(T? value) => new(value);
    public static Result<T> Failure(ErrorCode errorCode) => new(errorCode);
}