using MMC.Domain.Entities;
using MMC.Infrastructure.Data;
using MMC.Application.IRepositories;

namespace MMC.Infrastructure.Repositories;

public class RoleRepository : Repository<Role>, IRoleRepository
{ 
    public RoleRepository(IBaseDbContext db) : base(db) { }
}