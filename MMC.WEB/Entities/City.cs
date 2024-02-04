namespace MMC.WEB.Entities;

public class City
{
    public int Id { get; set; }
    public string Name { get; set; }

    public ICollection<Event> Events { get; private set; }
    public ICollection<Participant> Participants { get; private set; }
}