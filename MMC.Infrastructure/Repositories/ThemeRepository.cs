using MMC.Domain.Entities;
using MMC.Infrastructure.Data;
using MMC.Application.IRepositories;

namespace MMC.Infrastructure.Repositories;

public class ThemeRepository : Repository<Theme>, IThemeRepository
{ 
    public ThemeRepository(IBaseDbContext db) : base(db) { }
}