using Microsoft.Extensions.DependencyInjection;
using REWE.JobService.Application.Identity;
using REWE.JobService.Application.JobApplications;
using REWE.JobService.Application.Jobs;
using REWE.JobService.Application.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace REWE.JobService.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IIdentityService, IdentityService>();
            services.AddScoped<IJobsService,JobsService>();
            services.AddScoped<IJobApplicationService, JobApplicationService>();
            return services;
        }
    }
}
