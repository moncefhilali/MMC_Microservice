namespace MMC.WEB.Entities;

public class Event
{
    public Guid Id { get;  set; }
    public string Title { get;  set; }
    public string? Address { get;  set; }
    public string? Description { get;  set; }
    public string? ImagePath { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }

    public int CityId { get; set; }
    public City City { get; set; }

    public int ThemeId { get; set; }
    public Theme Theme { get; set; }

    public ICollection<Session> Sessions { get; set; }
    public ICollection<EventPartner> EventPartners { get; set; }
}