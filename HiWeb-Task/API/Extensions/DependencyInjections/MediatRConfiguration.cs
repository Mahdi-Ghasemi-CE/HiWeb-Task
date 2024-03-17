namespace HiWeb_Task.API.Extensions.DependencyInjections;

public static class MediatRConfiguration
{
    public static IServiceCollection AddMediatRConfiguration(this IServiceCollection services)
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));
        return services;
    }
}