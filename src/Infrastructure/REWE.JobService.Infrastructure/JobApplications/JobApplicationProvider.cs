using REWE.JobService.Application.Common.Interfaces;
using REWE.JobService.Domain.Applicants;
using REWE.JobService.Domain.Applications;
using REWE.JobService.Infrastructure.Common.ExternalServices.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REWE.JobService.Infrastructure.JobApplications
{
    public class JobApplicationProvider : IJobApplicationProvider
    {
        private readonly JobServiceClient _client;

        public JobApplicationProvider(JobServiceClient client)
        {
            _client = client;

        }
        public async Task<JobApplication> CreateApplicationAuth(string token, string correlationId)
        {
            return await _client.CreateApplicationAuth(token, correlationId);
        }

        public async Task<JobApplication> CreateApplication(string token, JobApplication application, string correlationId)
        {
            return await _client.CreateApplication(token, application, correlationId);
        }

        public async Task<Applicant> GetApplicant(string token, string applicationId, string authCode, string correlationId)
        {
            return await _client.GetApplicant(token, applicationId, authCode, correlationId);
        }
    }
}
