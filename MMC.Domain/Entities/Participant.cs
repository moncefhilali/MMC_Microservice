namespace MMC.Domain.Entities;

public class Participant
{
    public Guid Id { get; private set; }
    public string Firstname { get; private set; }
    public string Lastname { get; private set; }
    public string Email { get; private set; }
    public string Phone { get; private set; }
    public char Gender { get; private set; }

    public int CityId { get; private set; }
    public City City { get; private set; }

    public Guid UserId { get; private set; }
    public User User { get; private set; }

    public ICollection<SessionParticipant> SessionParticipants { get; private set; }




    public Participant(string firstname, string lastname, string email, string phone, char gender, int cityId, Guid userId)
    {
        Id = Guid.NewGuid();
        Firstname = firstname;
        Lastname = lastname;
        Email = email;
        Phone = phone;
        Gender = gender;
        CityId = cityId;
        UserId = userId;
    }
}