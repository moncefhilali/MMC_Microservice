namespace MMC.WEB.Entities;

public class Partner
{
    public Guid Id { get;  set; }
    public string Name { get;  set; }
    public string? Description { get; set; }
    public string? LogoPath { get; set; }

    public ICollection<EventPartner> EventPartners { get; set; }
}