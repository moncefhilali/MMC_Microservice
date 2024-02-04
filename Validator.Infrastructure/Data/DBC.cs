using Microsoft.EntityFrameworkCore;
using Validator.Domain.Entities;

namespace Validator.Infrastructure.Data;

public class DBC : DbContext
{
	public DBC(DbContextOptions<DBC> options) : base(options) { }




    public DbSet<JoinEvent> JoinEvents { get; set; }
}