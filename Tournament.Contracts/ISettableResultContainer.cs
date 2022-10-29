using System;

namespace Tournament.Contracts;

/// <summary>
/// Interface for setting result to entity
/// </summary>
/// <typeparam name="TThis">For better type-binding in specific implementation</typeparam>
/// <typeparam name="TResult"></typeparam>
public interface ISettableResultContainer<out TThis, TResult> : IResultContainer<TResult>
    where TThis : ISettableResultContainer<TThis, TResult>

{

    event Action<TThis> OnResultSet;

    bool HasResult { get; }

    new TResult Result { get; set; }

}
