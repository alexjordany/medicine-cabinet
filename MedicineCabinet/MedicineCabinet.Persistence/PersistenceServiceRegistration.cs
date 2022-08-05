using MedicineCabinet.Application.Contracts;
using MedicineCabinet.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace MedicineCabinet.Persistence;

public static class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<MedicineCabinetDbContext>(options =>
        {
            //options.UseSqlServer(configuration.GetConnectionString("MedicineCabinetConnectionString"));
            options.UseInMemoryDatabase("MedicineCabinet");
        });

        services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));
        services.AddScoped<IMedicineRepository, MedicineRepository>();

        return services;
    }
}

