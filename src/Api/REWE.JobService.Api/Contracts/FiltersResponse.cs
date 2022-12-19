using REWE.JobService.Domain.Areas;
using REWE.JobService.Domain.Common;
using REWE.JobService.Domain.Companies;
using REWE.JobService.Domain.JobGroups;
using REWE.JobService.Domain.Jobs;
using System.Text.Json.Serialization;

namespace REWE.JobService.Api.Contracts
{
    public record FiltersResponse
    {
        public List<JobGroup> JobGroups { get; set; }
        public List<AccountingCompany> AccountingCompanies { get; set; }
        public List<EmploymentLevel> EmploymentLevels { get; set; }
        public List<JobType> JobTypes { get; set; }
        public List<string> JobLevels { get; set; }
        public List<Province> Provinces { get; set; }
        public List<District> Districts { get; set; }
        public List<string> Cities { get; set; }
    }
}
