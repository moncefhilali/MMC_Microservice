using MMC.Application.IRepositories;
using MMC.Infrastructure.Data;

namespace MMC.Infrastructure.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly IBaseDbContext _db;

    public ICityRepository CityRepository { get; private set; }
    public IEventRepository EventRepository { get; private set; }
    public IModeRepository ModeRepository { get; private set; }
    public IParticipantRepository ParticipantRepository { get; private set; }
    public IPartnerRepository PartnerRepository { get; private set; }
    public IRoleRepository RoleRepository { get; private set; }
    public ISessionRepository SessionRepository { get; private set; }
    public ISpeakerRepository SpeakerRepository { get; private set; }
    public ISponsorRepository SponsorRepository { get; private set; }
    public IThemeRepository ThemeRepository { get; private set; }
    public IUserRepository UserRepository { get; private set; }


    public UnitOfWork(IBaseDbContext db)
    {
        _db = db;
        CityRepository = new CityRepository(_db);
        EventRepository = new EventRepository(_db);
        ModeRepository = new ModeRepository(_db);
        ParticipantRepository = new ParticipantRepository(_db);
        PartnerRepository = new PartnerRepository(_db);
        RoleRepository = new RoleRepository(_db);
        SessionRepository = new SessionRepository(_db);
        SpeakerRepository = new SpeakerRepository(_db);
        SponsorRepository = new SponsorRepository(_db);
        ThemeRepository = new ThemeRepository(_db);
        UserRepository = new UserRepository(_db);
    }


    public async Task<int> CompleteAsync()
        => await _db.SaveChangesAsync();
}
