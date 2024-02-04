namespace MMC.WEB.Entities;

public class SessionSponsor
{
    public Guid SessionId { get;  set; }
    public Session Session { get;  set; }

    public Guid SponsorId { get;  set; }
    public Sponsor Sponsor { get;  set; }
}