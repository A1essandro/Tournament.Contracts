namespace Tournament.Contracts
{

    /// <summary>
    /// Place for participant. This place can be empty if game is scheduled but certain participants are not defined.
    /// I.e. we have predefined final stage but semifinal stage is not completed
    /// </summary>
    /// <typeparam name="TParticipant"></typeparam>
    public interface IParticipantPlace<TParticipant>
        where TParticipant : IParticipant
    {

        TParticipant Participant { get; set; }

    }
}