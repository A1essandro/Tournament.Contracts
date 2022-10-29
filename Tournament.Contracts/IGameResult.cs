using System;

namespace Tournament.Contracts
{

    /// <summary>
    /// Resulf of a game between two <see cref="TParticipant" />
    /// </summary>
    /// <typeparam name="TPoints"></typeparam>
    /// <typeparam name="TParticipant"></typeparam>
    public interface IGameResult<out TPoints, out TParticipant> : IPointsContainer<TPoints>
        where TPoints : IComparable
        where TParticipant : IEquatable<TParticipant>
    {

        /// <summary>
        /// Winner of the game
        /// </summary>
        /// <value></value>
        TParticipant Winner { get; }

        /// <summary>
        /// Loser of the game
        /// </summary>
        /// <value></value>
        TParticipant Loser { get; }

    }

}