using MMC.Domain.Entities;
using MMC.Infrastructure.Data;
using MMC.Application.IRepositories;

namespace MMC.Infrastructure.Repositories;

public class SessionRepository : Repository<Session>, ISessionRepository
{ 
    public SessionRepository(IBaseDbContext db) : base(db) { }
}