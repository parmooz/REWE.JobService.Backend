using REWE.JobService.Application.Common.Interfaces;
using REWE.JobService.Domain.Common;
using REWE.JobService.Infrastructure.Common.ExternalServices.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REWE.JobService.Infrastructure.Jobs
{
    public class JobSearchService : IJobSearchService
    {
        private readonly JobServiceClient _client;

        public JobSearchService(JobServiceClient client) { _client = client; }   
        public async Task<JobSearchResult> SearchJobs(string token, JobSearchFilter filters)
        {
            return await _client.SearchJob(token, filters,"2000");
        }
    }
}
