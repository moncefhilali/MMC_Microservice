using MMC.Domain.Entities;
using MMC.Infrastructure.Data;
using MMC.Application.IRepositories;

namespace MMC.Infrastructure.Repositories;

public class CityRepository : Repository<City>, ICityRepository
{
    public CityRepository(IBaseDbContext db) : base(db) { }
}