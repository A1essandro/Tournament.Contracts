namespace Tournament.Contracts
{
    public interface IPair<out T>
    {

        T Item1 { get; }

        T Item2 { get; }

    }
}