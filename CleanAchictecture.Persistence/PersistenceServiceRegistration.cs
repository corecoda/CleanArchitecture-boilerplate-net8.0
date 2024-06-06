using CleanAchictecture.Persistence.DatabaseContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanAchitecture.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<MsSqlDatabaseContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("MsSqlDatabaseConnectionString"));
            });

            services.AddDbContext<MySqlDatabaseContext>(options =>
            {
                options.UseMySQL(configuration.GetConnectionString("MySqlDatabaseConnectionString"));
            });

            services.AddDbContext<OracleDatabaseContext>(options =>
            {
                options.UseOracle(configuration.GetConnectionString("OracleDatabaseConnectionString"));
            });

            services.AddDbContext<OracleDatabaseContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("OracleDatabaseConnectionString"));
            });

            return services;
        }
    }
}
