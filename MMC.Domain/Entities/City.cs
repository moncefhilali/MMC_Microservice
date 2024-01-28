namespace MMC.Domain.Entities;

public class City
{
    public int Id { get; private set; }
    public string Name { get; private set; }

    public ICollection<Event> Events { get; private set; }
    public ICollection<Participant> Participants { get; private set; }




    public City(string name) => Name = name;
}