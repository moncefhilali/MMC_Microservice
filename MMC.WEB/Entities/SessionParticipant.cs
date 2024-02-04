namespace MMC.WEB.Entities;

public class SessionParticipant
{
    public Guid SessionId { get;  set; }
    public Session Session { get;  set; }

    public Guid ParticipantId { get;  set; }
    public Participant Participant { get;  set; }
}