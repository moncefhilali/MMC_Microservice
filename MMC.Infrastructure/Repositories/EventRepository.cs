using MMC.Domain.Entities;
using MMC.Infrastructure.Data;
using MMC.Application.IRepositories;

namespace MMC.Infrastructure.Repositories;

public class EventRepository : Repository<Event>, IEventRepository
{
    public EventRepository(IBaseDbContext db) : base(db) { }
}