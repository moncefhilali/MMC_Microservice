namespace MMC.Domain.Entities;

public class Sponsor
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string? Description { get; private set; }
    public string? LogoPath { get; private set; }

    public ICollection<SessionSponsor> SessionSponsors { get; private set; }




    public Sponsor(string name, string? description, string? logoPath)
    {
        Id = Guid.NewGuid();
        Name = name;
        Description = description;
        LogoPath = logoPath;
    }
}