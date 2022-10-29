namespace Tournament.Contracts;

/// <summary>
/// Common interface for entities wich have result
/// </summary>
/// <typeparam name="TResult">Type of result</typeparam>
public interface IResultContainer<out TResult>
{

    TResult Result { get; }

}
