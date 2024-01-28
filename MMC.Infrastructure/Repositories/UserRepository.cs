using MMC.Domain.Entities;
using MMC.Infrastructure.Data;
using MMC.Application.IRepositories;

namespace MMC.Infrastructure.Repositories;

public class UserRepository : Repository<User>, IUserRepository
{ 
    public UserRepository(IBaseDbContext db) : base(db) { }
}