namespace MMC.Domain.Entities;

public class SessionParticipant
{
    public Guid SessionId { get; private set; }
    public Session Session { get; private set; }

    public Guid ParticipantId { get; private set; }
    public Participant Participant { get; private set; }
}