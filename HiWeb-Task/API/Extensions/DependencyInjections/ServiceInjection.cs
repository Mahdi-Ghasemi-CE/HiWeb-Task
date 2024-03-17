using HiWeb_Task.Application.Interfaces;
using HiWeb_Task.Infrastructure;

namespace HiWeb_Task.API.Extensions.DependencyInjections;


public static class ServiceInjection
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork>();

        return services;
    }
}