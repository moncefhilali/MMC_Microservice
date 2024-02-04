namespace MMC.WEB.Entities;

public class Speaker
{
    public Guid Id { get;  set; }
    public string Firstname { get;  set; }
    public string Lastname { get; set; }
    public string Email { get;  set; }
    public string Phone { get;  set; }
    public char Gender { get;  set; }
    public string PicturePath { get;  set; }
    public bool? MVP { get;  set; }
    public bool? MCT { get;  set; }
    public string Description { get;  set; }
    public string Facebook { get; set; }
    public string Instagram { get; set; }
    public string LinkedIn { get; set; }
    public string TwitterX { get; set; }

    public Guid UserId { get; set; }
    public User User { get; set; }

    public ICollection<SessionSpeaker> SessionSpeakers { get; set; }
}