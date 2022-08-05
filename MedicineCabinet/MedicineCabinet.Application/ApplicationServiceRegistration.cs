using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace MedicineCabinet.Application;

public static class ApplicationServiceRegistration
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        return services;
    }
}

