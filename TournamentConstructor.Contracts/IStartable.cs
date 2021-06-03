using System;

namespace TournamentConstructor.Contracts
{

    /// <summary>
    /// Entity that can be started
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IStartable<out T>
        where T : IStartable<T>
    {

        bool IsStarted { get; }

        event Action<T> OnStarted;

    }
}