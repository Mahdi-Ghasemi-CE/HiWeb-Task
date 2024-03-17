using HiWeb_Task.Application.Utils;

namespace HiWeb_Task.API.Extensions.DependencyInjections;

public static class OptionConfiguration
{
    public static IServiceCollection AddOptionConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
        // Option Configuration
        services.Configure<Options>(configuration.GetSection(nameof(Options)));
        return services;
    }
}