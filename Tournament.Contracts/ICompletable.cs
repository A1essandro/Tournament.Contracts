using System;

namespace Tournament.Contracts
{

    /// <summary>
    /// Common interface for completable entities
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ICompletable<out T>
        where T : ICompletable<T>
    {

        event Action<T> OnCompleted;

        bool IsCompleted { get; }

    }
}