namespace MMC.WEB.Entities;

public class Participant
{
    public Guid Id { get;  set; }
    public string Firstname { get;  set; }
    public string Lastname { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public char Gender { get; set; }

    public int CityId { get; set; }
    public City City { get; set; }

    public Guid UserId { get; set; }
    public User User { get; set; }

    public ICollection<SessionParticipant> SessionParticipants { get; set; }
}