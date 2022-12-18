using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using REWE.JobService.Application.Common.Interfaces;
using REWE.JobService.Infrastructure.Common.ExternalServices.Http;
using REWE.JobService.Infrastructure.Identity;

namespace REWE.JobService.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,IConfiguration configuration)
        {
            services.Configure<JobServiceSettings>(configuration.GetSection(JobServiceSettings.SectionName));
            services.Configure<AuthTokenSettings>(configuration.GetSection(AuthTokenSettings.SectionName));
            services.AddHttpClient<AuthTokenClient>();
            services.AddHttpClient<JobServiceClient>();
            services.AddScoped<ITokenGenerator, TokenGenerator>();
            return services;
        }
    }
}
