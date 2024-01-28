namespace MMC.Domain.Entities;

public class Session
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public int NumPlace { get; private set; }
    public string? Description { get; private set; }
    public DateTime? StartDate { get; private set; }
    public DateTime? EndDate { get; private set; }

    public Guid EventId { get; private set; }
    public Event Event { get; private set; }

    public int ModeId { get; private set; }
    public Mode Mode { get; private set; }

    public ICollection<SessionParticipant> SessionParticipants { get; private set; }
    public ICollection<SessionSpeaker> SessionSpeakers { get; private set; }
    public ICollection<SessionSponsor> SessionSponsors { get; private set; }




    public Session(string name, int numPlace, string? description, DateTime? startDate, DateTime? endDate, Guid eventId, int modeId)
    {
        Id = Guid.NewGuid();
        Name = name;
        NumPlace = numPlace;
        Description = description;
        StartDate = startDate;
        EndDate = endDate;
        EventId = eventId;
        ModeId = modeId;
    }
}