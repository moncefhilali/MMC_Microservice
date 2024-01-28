namespace MMC.Domain.Entities;

public class Event
{
    public Guid Id { get; private set; }
    public string Title { get; private set; }
    public string? Address { get; private set; }
    public string? Description { get; private set; }
    public string? ImagePath { get; private set; }
    public DateTime? StartDate { get; private set; }
    public DateTime? EndDate { get; private set; }

    public int CityId { get; private set; }
    public City City { get; private set; }

    public int ThemeId { get; private set; }
    public Theme Theme { get; private set; }

    public ICollection<Session> Sessions { get; private set; }
    public ICollection<EventPartner> EventPartners { get; private set; }




    public Event(string title, string? address, string? description, string? imagePath, DateTime? startDate, DateTime? endDate, int cityId, int themeId)
    {
        Id = Guid.NewGuid();
        Title = title;
        Address = address;
        Description = description;
        ImagePath = imagePath;
        StartDate = startDate;
        EndDate = endDate;
        CityId = cityId;
        ThemeId = themeId;
    }
}