namespace MMC.Domain.Entities;

public class EventPartner
{
    public Guid EventId { get; private set; }
    public Event Event { get; private set; }

    public Guid PartnerId { get; private set; }
    public Partner Partner { get; private set; }
}