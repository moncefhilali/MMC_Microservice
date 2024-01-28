namespace MMC.Domain.Entities;

public class SessionSpeaker
{
    public Guid SessionId { get; private set; }
    public Session Session { get; private set; }

    public Guid SpeakerId { get; private set; }
    public Speaker Speaker { get; private set; }
}