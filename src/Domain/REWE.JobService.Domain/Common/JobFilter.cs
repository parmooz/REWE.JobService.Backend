using REWE.JobService.Domain.Areas;
using REWE.JobService.Domain.Companies;
using REWE.JobService.Domain.JobGroups;
using REWE.JobService.Domain.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace REWE.JobService.Domain.Common
{
    public class JobFilter
    {
        [JsonPropertyName("jobGroups")] 
        public List<JobGroup> JobGroups { get; set; }
        [JsonPropertyName("accountingCompanies")]
        public List<AccountingCompany> AccountingCompanies { get; set; }
        [JsonPropertyName("employmentLevels")]
        public List<EmploymentLevel> EmploymentLevels { get; set; }
        [JsonPropertyName("jobTypes")]
        public List<JobType> JobTypes { get; set; }
        [JsonPropertyName("jobLevels")]
        public List<string> JobLevels { get; set; }
        [JsonPropertyName("provinces")]
        public List<Province> Provinces { get; set; }
        
        [JsonPropertyName("districts")]

        public List<District> Districts { get; set; }
        [JsonPropertyName("cities")]
        public List<string> Cities { get; set; }

        

    }
}
