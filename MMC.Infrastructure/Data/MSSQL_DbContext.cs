using Microsoft.EntityFrameworkCore;
using MMC.Domain.Entities;

namespace MMC.Infrastructure.Data;

public class MSSQL_DbContext : BaseDbContext, IBaseDbContext
{
    public MSSQL_DbContext(DbContextOptions<MSSQL_DbContext> options) : base(options) { }
}