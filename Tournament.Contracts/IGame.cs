using System;

namespace Tournament.Contracts
{

    /// <summary>
    /// Common interface for scheduled game between tournament participants
    /// </summary>
    /// <typeparam name="TGame"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    /// <typeparam name="TResultPoints"></typeparam>
    /// <typeparam name="TParticipant"></typeparam>
    public interface IGame<out TGame, TResult, out TResultPoints, TParticipant>
        : ICompletable<TGame>, IContextContainer<IStage>, ISettableResultContainer<TGame, TResult>
        where TResult : IGameResult<TResultPoints, TParticipant>
        where TResultPoints : IComparable
        where TParticipant : IParticipant
        where TGame : IGame<TGame, TResult, TResultPoints, TParticipant>
    {

        /// <summary>
        /// Scheduled date
        /// </summary>
        /// <value></value>
        DateTime Date { get; set; }

        /// <summary>
        /// Place for participants. Participants will be default (null for class) if
        /// </summary>
        /// <value></value>
        IPair<IParticipantPlace<TParticipant>> ParticipantPlaces { get; }

    }

}