namespace MMC.Application.IRepositories;

public interface IUnitOfWork
{
    ICityRepository CityRepository { get; }
    IEventRepository EventRepository { get; }
    IModeRepository ModeRepository { get; }
    IParticipantRepository ParticipantRepository { get; }
    IPartnerRepository PartnerRepository { get; }
    IRoleRepository RoleRepository { get; }
    ISessionRepository SessionRepository { get; }
    ISpeakerRepository SpeakerRepository { get; }
    ISponsorRepository SponsorRepository { get; }
    IThemeRepository ThemeRepository { get; }
    IUserRepository UserRepository { get; }

    Task<int> CompleteAsync();
}