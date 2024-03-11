using Microsoft.Extensions.DependencyInjection;

namespace CleanAchitecture.Application
{
    public static class SwaggerServiceRegistration
    {
        public static IServiceCollection AddSwaggerService(this IServiceCollection services)
        {

            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            return services;
        }
    }
}
