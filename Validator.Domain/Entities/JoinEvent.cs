namespace Validator.Domain.Entities;

public class JoinEvent
{
    public int Id { get; private set; }
    public int ParticipantId { get; private set; }
    public int EventId { get; private set; }
    public DateTime ParticipationDate { get; private set; }
    public bool IsApproved { get; private set; }

    public JoinEvent(int participantId, int eventId)
    {
        ParticipantId = participantId;
        EventId = eventId;
        ParticipationDate = DateTime.Now;
        IsApproved = false;
    }

    public void ApproveRequest() => IsApproved = true;
}