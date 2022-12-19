using REWE.JobService.Application.Common.Interfaces;
using REWE.JobService.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REWE.JobService.Application.Jobs
{
    public class JobsService :IJobsService
    {
        private readonly IJobFilterService _filterService;
        private readonly IJobSearchService _jobSearchService;

        public JobsService(IJobFilterService filterService,IJobSearchService jobSearchService)
        {
            _filterService = filterService;
            _jobSearchService = jobSearchService;
        }
        public async Task<JobFilter> GetAllJobFilters(string token)
        {
            var res=await _filterService.GetAllJobFilters(token, "1000");
            return res;
        }

        public async Task<JobSearchResult> SearchJobs(string token,JobSearchFilter filters)
        {
            var res=await _jobSearchService.SearchJobs(token, filters);
            return res;
        }
    }
}
