using REWE.JobService.Application.Common.Interfaces;
using REWE.JobService.Domain.Applicants;
using REWE.JobService.Domain.Applications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace REWE.JobService.Application.JobApplications
{
    public class JobApplicationService : IJobApplicationService
    {
        private readonly IJobApplicationProvider _jobApplicationProvider;

        public JobApplicationService(IJobApplicationProvider jobApplicationProvider) { _jobApplicationProvider = jobApplicationProvider; }
        public async Task<JobApplication> CreateApplicationAuth(string token)
        {
            return await _jobApplicationProvider.CreateApplicationAuth(token, "6000");
        }

        public async Task<JobApplication> CreateApplication(string token, JobApplication application)
        {
            return await _jobApplicationProvider.CreateApplication(token, application, "6000");
        }

        public async Task<Applicant> GetApplicant(string token, string applicationId, string authCode)
        {
            return await _jobApplicationProvider.GetApplicant(token,  applicationId,  authCode, "6000");
        }
    }
}
