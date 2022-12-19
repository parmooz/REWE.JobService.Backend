using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using REWE.JobService.Domain.Applicants;
using System.Net;
using System;
using REWE.JobService.Api.Contracts;
using REWE.JobService.Application.JobApplications;
using System.Net.WebSockets;

namespace REWE.JobService.Api.Controllers.V1
{
    [Route("/api/job-applications")]
    [ApiController]
    public class ApplicationsController : ControllerBase
    {
        private readonly IJobApplicationService _jobApplicationService;

        public ApplicationsController(IJobApplicationService jobApplicationService) { _jobApplicationService = jobApplicationService; }

        [HttpPost("credentials")]
        //This endpoint creates a new job-application and returns credentials, which are used for any further manipulation of the applicaion

        public async Task<IActionResult> Authenticate([FromBody] ApplicationAuthRequest request)
        {
            var result=await _jobApplicationService.CreateApplicationAuth(request.authCode);
            var res = new ApplicationAuthResponse(result.Id, result.AuthCode, result.ExpirationTimestamp);
           
            return Ok(res);
        }


        [HttpGet("{applicationId}")]
        //fetch application details
        public async Task<IActionResult> Get(string applicationId)
        {
            await Task.CompletedTask;
            return Ok("get");
        }



        [HttpPut("{applicationId}/applicant")]
        //This endpoint sets the applicants details
        public async Task<IActionResult> Update(string applicationId)
        {
            await Task.CompletedTask;
            return Ok("get");
        }

        [HttpPost("{applicationId}/documents")]
        //This endpoints uploads application-documents
        public async Task<IActionResult> UploadDocument(string applicationId)
        {
            await Task.CompletedTask;
            return Ok("UploadDocument");
        }

        [HttpDelete("{applicationId}/documents/{jobDocumentId}")]
        //This endpoints deletes application-documents
        public async Task<IActionResult> Delete(string applicationId, string jobDocumentId)
        {
            await Task.CompletedTask;
            return Ok("Delete");
        }

        [HttpPost("{applicationId}/submit")]
        //This endpoints submits the application
        public async Task<IActionResult> submit(string applicationId)
        {
            await Task.CompletedTask;
            return Ok("submit");
        }




    }
}



