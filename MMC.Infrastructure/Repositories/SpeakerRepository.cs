using MMC.Domain.Entities;
using MMC.Infrastructure.Data;
using MMC.Application.IRepositories;

namespace MMC.Infrastructure.Repositories;

public class SpeakerRepository : Repository<Speaker>, ISpeakerRepository
{ 
    public SpeakerRepository(IBaseDbContext db) : base(db) { }
}