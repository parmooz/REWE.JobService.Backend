using REWE.JobService.Domain.Applicants;
using REWE.JobService.Domain.Applications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REWE.JobService.Application.Common.Interfaces
{
    public interface IJobApplicationProvider
    {
        Task<JobApplication> CreateApplicationAuth(string token,string correlationId);
        Task<Applicant> GetApplicant(string token, string applicationId, string authCode, string correlationId);
        Task<JobApplication> CreateApplication(string token, JobApplication application, string correlationId);
    }
}
