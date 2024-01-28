namespace MMC.Domain.Entities;

public class Theme
{
    public int Id { get; private set; }
    public string Name { get; private set; }

    public ICollection<Event> Events { get; private set; }




    public Theme(string name) => Name = name;
}