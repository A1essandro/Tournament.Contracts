using System;
using System.Collections.Generic;

namespace Tournament.Contracts;

/// <summary>
/// Common interface for tournament stage
/// </summary>
public interface IStage : ICompletable<IStage>, IStartable<IStage>
{

}

/// <summary>
/// Interface of tournament stage
/// </summary>
/// <typeparam name="TGame">Type of games</typeparam>
/// <typeparam name="TGameResult">Type of games result</typeparam>
/// <typeparam name="TGameResultPoints">Type of points for games</typeparam>
/// <typeparam name="TResult">Type of this stage result</typeparam>
/// <typeparam name="TParticipant">Participants type</typeparam>
public interface IStage<out TGame, TGameResult, TGameResultPoints, out TResult, TParticipant> : IStage, IResultContainer<TResult>
        where TGame : IGame<TGame, TGameResult, TGameResultPoints, TParticipant>
        where TGameResultPoints : IComparable
        where TGameResult : IGameResult<TGameResultPoints, TParticipant>
        where TParticipant : IEquatable<TParticipant>
{

    /// <summary>
    /// Stage that contains this stage
    /// </summary>
    /// <value></value>
    IStage Context { get; }

    /// <summary>
    /// Internal sequential or parallel stages
    /// </summary>
    /// <value></value>
    IEnumerable<IStage<TGame, TGameResult, TGameResultPoints, object, TParticipant>> Stages { get; }

    /// <summary>
    /// Scheduled games
    /// </summary>
    /// <value></value>
    IEnumerable<TGame> Schedule { get; }

    /// <summary>
    /// Participants
    /// </summary>
    /// <value></value>
    IReadOnlyList<IParticipantPlace<TParticipant>> ParticipantPlaces { get; }

}
