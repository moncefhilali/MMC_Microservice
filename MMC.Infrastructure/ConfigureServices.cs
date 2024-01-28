using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MMC.Application.IRepositories;
using MMC.Infrastructure.Data;
using MMC.Infrastructure.Repositories;

namespace MMC.Infrastructure;

public static class ConfigureServices
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        //database setup
        string? databaseProvider = configuration["DatabaseProvider"];
        
        if (databaseProvider == "MSSQL")
        {
            string? con = configuration.GetConnectionString("mssql_con");
            services.AddDbContext<IBaseDbContext, MSSQL_DbContext>(options => options.UseSqlServer(con));
        }
        else if (databaseProvider == "MYSQL")
        {
            string? con = configuration.GetConnectionString("mysql_con");
            services.AddDbContext<IBaseDbContext, MYSQL_DbContext>(options => options.UseMySql(con, ServerVersion.Parse("10.4.27-mariadb")));
        }
        else if (databaseProvider == "SQLITE")
        {
            string? con = configuration.GetConnectionString("sqlite_con");
            services.AddDbContext<IBaseDbContext, SQLITE_DbContext>(options => options.UseSqlite(con));
        }


        //dependency injection
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        
        return services;
    }
}