namespace Tournament.Contracts
{

    /// <summary>
    /// Common interface for entities with context (i.e. game in context of stage)
    /// </summary>
    /// <typeparam name="T">Type of context</typeparam>
    public interface IContextContainer<out T>
    {

        T Context { get; }

    }

}