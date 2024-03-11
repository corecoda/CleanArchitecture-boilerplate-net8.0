using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanAchitecture.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            //services.AddDbContext<DatabaseContext>(options =>
            //{
            //    options.UseSqlServer(configuration.GetConnectionString("DatabaseConnectionString"));
            //});

            return services;
        }
    }
}
