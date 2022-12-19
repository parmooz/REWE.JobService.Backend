using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using REWE.JobService.Application.Common.Interfaces;
using REWE.JobService.Infrastructure.Common.ExternalServices.Http;
using REWE.JobService.Infrastructure.Identity;
using REWE.JobService.Infrastructure.JobApplications;
using REWE.JobService.Infrastructure.Jobs;

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
            services.AddScoped<IJobSearchService, JobSearchService>();
            services.AddScoped<IJobFilterService, JobFilterService>(); 
            services.AddScoped<IJobApplicationProvider, JobApplicationProvider>();
            return services;
        }
    }
}
