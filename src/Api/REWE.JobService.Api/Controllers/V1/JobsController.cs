using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System;
using REWE.JobService.Application.Jobs;
using REWE.JobService.Api.Contracts;
using REWE.JobService.Domain.Common;

namespace REWE.JobService.Api.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        private readonly IJobsService _jobSerive;

        public JobsController(IJobsService jobSerive) { _jobSerive = jobSerive; }

        [HttpPost("search")]
        //This endpoint is used to search for job offers
        public async Task<ActionResult> Search([FromBody] JobSearchRequest request)
        {
            var jobSearchFilter = new JobSearchFilter()
            {
                AccountingCompanyId = request.AccountingCompanyId,
                AccountingCompanyIds = request.AccountingCompanyIds,
                DistrictIds = request.DistrictIds,
                EmploymentLevelId = request.EmploymentLevelId,
                IncludeInternal = request.IncludeInternal,
                JobDescriptionId = request.JobDescriptionId,
                JobGroupIds = request.JobGroupIds,
                JobLevels = request.JobLevels,
                JobTypeIds = request.JobTypeIds,
                Limit = request.Limit,
                MaxWorkingHours = request.MaxWorkingHours,
                MinWorkingHours = request.MinWorkingHours,
                Offset = request.Offset,
                ProvinceIds = request.ProvinceIds,
                SearchTerm = request.SearchTerm,
                SortDirection = request.SortDirection,
                SortField = request.SortField,
                SubJobGroupIds = request.SubJobGroupIds,
                Zip = request.Zip

            };
            var result = await _jobSerive.SearchJobs(request.Token, jobSearchFilter);
            var response = new JobSearchResponse()
            {
                Jobs= result.Jobs,
                NumberOfHits= result.NumberOfHits,
                TotalCount= result.TotalCount,
            };
            return Ok(response);
        }
      
        [HttpPost("search/filters")]
        //This endpoint is used to retrieve possible filter values for a given search for jobs
        public async Task<ActionResult> Getfilters([FromBody] FiltersRequest request)
        {
            var result=await _jobSerive.GetAllJobFilters(request.token);
            var response=new FiltersResponse()
            {
                AccountingCompanies=result.AccountingCompanies,
                Cities=result.Cities,
                Districts=result.Districts,
                EmploymentLevels = result.EmploymentLevels,
                JobGroups=result.JobGroups,
                JobTypes=result.JobTypes,
                JobLevels=result.JobLevels,
                Provinces = result.Provinces
            };
            return Ok(response);
        }
        [HttpGet("{jobDescriptionId}")]
        //This endpoint is used to retrieve a job description.
        public async Task<ActionResult> GetJobDescription(string jobDescriptionId)
        {
            await Task.CompletedTask;
            return Ok();
        }
        [HttpGet("{jobDescriptionId}/offers/{jobId}")]
        //This endpoint is used to retrieve a job offer with detailed description
        public async Task<ActionResult> Offers(string jobDescriptionId, string jobId)
        {
            await Task.CompletedTask;
            return Ok();
        }
    }
}



