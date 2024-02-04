namespace MMC.WEB.Entities;

public class Sponsor
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public string? LogoPath { get; set; }

    public ICollection<SessionSponsor> SessionSponsors { get; set; }
}