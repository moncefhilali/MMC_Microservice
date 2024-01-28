namespace MMC.Domain.Entities;

public class SessionSponsor
{
    public Guid SessionId { get; private set; }
    public Session Session { get; private set; }

    public Guid SponsorId { get; private set; }
    public Sponsor Sponsor { get; private set; }
}