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
    public class JobFilterService : IJobFilterService
    {
        private readonly JobServiceClient _client;

        public JobFilterService(JobServiceClient client)
        {
            _client = client;

        }
        public async Task<JobFilter> GetAllJobFilters(string token,string correlationId)
        {
            return await _client.GetFilters(token, correlationId);
        }
    }
}
