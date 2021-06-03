namespace TournamentConstructor.Contracts
{

    /// <summary>
    /// For entities that can be a draw (i.e. football game result)
    /// </summary>
    public interface ICanBeADraw
    {

        /// <summary>
        /// Is a draw
        /// </summary>
        bool IsDraw { get; }

    }

}