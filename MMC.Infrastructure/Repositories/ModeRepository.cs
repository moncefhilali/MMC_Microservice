using MMC.Domain.Entities;
using MMC.Infrastructure.Data;
using MMC.Application.IRepositories;

namespace MMC.Infrastructure.Repositories;

public class ModeRepository : Repository<Mode>, IModeRepository
{
    public ModeRepository(IBaseDbContext db) : base(db) { }
}