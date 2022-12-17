using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System;

namespace REWE.JobService.Api.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        [HttpPost("search")]
        //This endpoint is used to search for job offers
        public async Task<ActionResult> Search()
        {
            await Task.CompletedTask;
            return Ok();
        }
        [HttpGet("export")]
        //This endpoint is used to provide a pre - filtered list of jobs to external partners
        public async Task<ActionResult> Export()
        {
            await Task.CompletedTask;
            return Ok();
        }
        [HttpPost("search/filters")]
        //This endpoint is used to retrieve possible filter values for a given search for jobs
        public async Task<ActionResult> Getfilters()
        {
            await Task.CompletedTask;
            return Ok();
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



