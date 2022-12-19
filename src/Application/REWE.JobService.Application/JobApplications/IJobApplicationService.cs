using REWE.JobService.Domain.Applicants;
using REWE.JobService.Domain.Applications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REWE.JobService.Application.JobApplications
{
    public interface IJobApplicationService
    {
        Task<JobApplication> CreateApplicationAuth(string token);
        Task<Applicant> GetApplicant(string token, string applicationId, string authCode);
        Task<JobApplication>  CreateApplication(string token, JobApplication application);
    }
}
