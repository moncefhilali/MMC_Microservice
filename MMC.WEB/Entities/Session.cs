namespace MMC.WEB.Entities;

public class Session
{
    public Guid Id { get;  set; }
    public string Name { get;  set; }
    public int NumPlace { get;  set; }
    public string? Description { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }

    public Guid EventId { get; set; }
    public Event Event { get; set; }

    public int ModeId { get; set; }
    public Mode Mode { get; set; }

    public ICollection<SessionParticipant> SessionParticipants { get; set; }
    public ICollection<SessionSpeaker> SessionSpeakers { get; set; }
    public ICollection<SessionSponsor> SessionSponsors { get; set; }
}