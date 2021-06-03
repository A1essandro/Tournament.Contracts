using System;

namespace TournamentConstructor.Contracts
{

    /// <summary>
    /// Interface for entities that contain points (i.e. game result)
    /// </summary>
    /// <typeparam name="TPoints"></typeparam>
    public interface IPointsContainer<out TPoints>
        where TPoints : IComparable
    {

        IPair<TPoints> Points { get; }

    }
}