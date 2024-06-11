using CleanAchictecture.Persistence.DatabaseContexts;
using CleanAchictecture.Persistence.Repositories;
using CleanAchitecture.Application.Contracts.Persistence;
using CleanAchitecture.Persistence.Repositories;
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

            services.AddDbContext<PostgresDatabaseContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("OracleDatabaseConnectionString"));
            });


            services.AddTransient<MsSqlDatabaseContext>();
            services.AddTransient<MySqlDatabaseContext>();
            services.AddTransient<OracleDatabaseContext>();
            services.AddTransient<PostgresDatabaseContext>();

            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddTransient<IUserRepository, UserRepository>();

            return services;
        }
    }
}
