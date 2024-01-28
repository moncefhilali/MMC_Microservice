namespace MMC.Domain.Entities;

public class Speaker
{
    public Guid Id { get; private set; }
    public string Firstname { get; private set; }
    public string Lastname { get; private set; }
    public string Email { get; private set; }
    public string Phone { get; private set; }
    public char Gender { get; private set; }
    public string PicturePath { get; private set; }
    public bool? MVP { get; private set; }
    public bool? MCT { get; private set; }
    public string Description { get; private set; }
    public string Facebook { get; private set; }
    public string Instagram { get; private set; }
    public string LinkedIn { get; private set; }
    public string TwitterX { get; private set; }

    public Guid UserId { get; private set; }
    public User User { get; private set; }

    public ICollection<SessionSpeaker> SessionSpeakers { get; private set; }




    public Speaker(string firstname, string lastname, string email, string phone, char gender, string picturePath, bool? mVP, bool? mCT, string description, string facebook, string instagram, string linkedIn, string twitterX, Guid userId)
    {
        Id = Guid.NewGuid();
        Firstname = firstname;
        Lastname = lastname;
        Email = email;
        Phone = phone;
        Gender = gender;
        PicturePath = picturePath;
        MVP = mVP;
        MCT = mCT;
        Description = description;
        Facebook = facebook;
        Instagram = instagram;
        LinkedIn = linkedIn;
        TwitterX = twitterX;
        UserId = userId;
    }
}