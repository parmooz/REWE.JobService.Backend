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
    public class JobSearchFilter
    {
       
        [JsonPropertyName("accountingCompanyId")]
        public string AccountingCompanyId { get; set; }
        [JsonPropertyName("accountingCompanyIds")]
        public List<string> AccountingCompanyIds { get; set; }

        [JsonPropertyName("jobGroupIds")]
        public List<string> JobGroupIds { get; set; }
        [JsonPropertyName("subJobGroupIds")]
        public List<string> SubJobGroupIds { get; set; }

        [JsonPropertyName("jobTypeIds")]
        public List<string> JobTypeIds { get; set; }

        [JsonPropertyName("provinceIdList")]
        public List<string> ProvinceIds { get; set; }

        [JsonPropertyName("districtIdList")]
        public List<string> DistrictIds { get; set; }

        [JsonPropertyName("employmentLevelId")]
        public string EmploymentLevelId { get; set; }
        [JsonPropertyName("searchTerm")]
        public string SearchTerm { get; set; }

        [JsonPropertyName("jobLevels")]
        public List<string> JobLevels { get; set; }

        [JsonPropertyName("jobDescriptionId")]
        public string JobDescriptionId { get; set; }

        [JsonPropertyName("zip")]
        public string Zip { get; set; }

        [JsonPropertyName("minWorkingHours")]
        public int MinWorkingHours { get; set; }

        [JsonPropertyName("maxWorkingHours")]
        public int MaxWorkingHours { get; set; }

        //the number of entries to skip when paging
        [JsonPropertyName("offset")]
        public int Offset { get; set; } = 5;

        // the maximum number of entries to return,
        [JsonPropertyName("limit")]
        public int Limit { get; set; } = 5;

        //  the response should be sorted by = ['Relevancy', 'Title', 'City', 'EmploymentLevel', 'AccountingCompany', 'CreationDate']
        [JsonPropertyName("sortField")]
        public string SortField { get; set; } = "CreationDate";

        //  order in which it should be sorted = ['Ascending', 'Descending']
        [JsonPropertyName("SortDirection")]
        public string SortDirection { get; set; } = "Descending";

        //  order in which it should be sorted = ['Ascending', 'Descending']
        [JsonPropertyName("includeInternal")]
        public bool IncludeInternal { get; set; } = false;


    }
}
