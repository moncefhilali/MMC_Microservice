namespace MMC.Domain.Entities;

public class Mode
{
    public int Id { get; private set; }
    public string Name { get; private set; }

    public ICollection<Session> Sessions { get; private set; }




    public Mode(string name) => Name = name;
}