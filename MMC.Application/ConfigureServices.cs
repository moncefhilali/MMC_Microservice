using Microsoft.Extensions.DependencyInjection;
using MMC.Application.Interfaces;
using MMC.Application.Mapping;
using MMC.Application.Services;
using System.Reflection;

namespace MMC.Application;

public static class ConfigureServices
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        //Auto mapper
        services.AddAutoMapper(typeof(AutoMapperProfile));

        //MediatR
        services.AddMediatR(config =>
        {
            config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
        });

        //Services Injection
        services.AddScoped<IUnitOfService, UnitOfService>();
        return services;
    }
}