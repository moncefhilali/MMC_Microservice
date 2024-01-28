namespace MMC.Domain.Entities;

public class Partner
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string? Description { get; private set; }
    public string? LogoPath { get; private set; }

    public ICollection<EventPartner> EventPartners { get; private set; }




    public Partner(string name, string? description, string? logoPath)
    {
        Id = Guid.NewGuid();
        Name = name;
        Description = description;
        LogoPath = logoPath;
    }
}