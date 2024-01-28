using MMC.Domain.Entities;
using MMC.Infrastructure.Data;
using MMC.Application.IRepositories;

namespace MMC.Infrastructure.Repositories;

public class SponsorRepository : Repository<Sponsor>, ISponsorRepository
{ 
    public SponsorRepository(IBaseDbContext db) : base(db) { }
}