namespace MMC.WEB.Entities;

public class Mode
{
    public int Id { get; set; }
    public string Name { get; set; }

    public ICollection<Session> Sessions { get; set; }
}