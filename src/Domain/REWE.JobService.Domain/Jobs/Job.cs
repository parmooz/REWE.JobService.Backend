using REWE.JobService.Domain.Areas;
using REWE.JobService.Domain.Common;
using REWE.JobService.Domain.Companies;
using REWE.JobService.Domain.JobGroups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace REWE.JobService.Domain.Jobs
{
    public class Job
    {
        [JsonPropertyName("jobId")]
        public string Id { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("jobNumber")]
        public int Number { get; set; }
        [JsonPropertyName("jobGroups")]
        public List<JobGroup> JobGroups { get; set; }

        [JsonPropertyName("countryCode")]
        public string CountryCode { get; set; }
        [JsonPropertyName("zip")]
        public string ZipCode { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }
        public Province Province { get; set; }
        [JsonPropertyName("provinceId")]
        public string ProvinceId { get; set; }
        [JsonPropertyName("provinceNumber")]
        public int ProvinceNumber { get; set; }
        [JsonPropertyName("provinceName")]
        public string ProvinceName { get; set; }

        public District District { get; set; }
        [JsonPropertyName("districtId")]
        public string DistrictId { get; set; }
        [JsonPropertyName("districtNumber")]
        public int DistrictNumber { get; set; }
        [JsonPropertyName("districtName")]
        public string DistrictName { get; set; }

        public JobGroup Group { get; set; }
        
        [JsonPropertyName("paymentClass")]
        public int PaymentClass { get; set; }
        [JsonPropertyName("startDate")]
        public DateTime StartDate { get; set; }
        [JsonPropertyName("creationDate")]
        public DateTime CreateDate { get; set; }
        //[JsonPropertyName("hours")]
        //public int hours { get; set; }
        //[JsonPropertyName("minHours")]
        //public int Minhours { get; set; }
        //[JsonPropertyName("amountOfJobs")]
        //public int AmountOfJobs { get; set; }
        [JsonPropertyName("stores")]
        public List<Store> Stores { get; set; }
        [JsonPropertyName("links")]
        public List<link> Links { get; set; }
        [JsonPropertyName("synonyms")]
        public List<string> Synonyms { get; set; }
        [JsonPropertyName("jobLevels")]
        public List<string> JobLevels { get; set; }

        [JsonPropertyName("shortDescription")]
        public string ShortDescription { get; set; }

        public EmploymentLevel Level { get; set; }

        [JsonPropertyName("employmentLevelId")]
        public string EmploymentLevelId { get; set; }
        [JsonPropertyName("employmentLevel")]
        public string  EmploymentLevel { get; set; }
        
        [JsonPropertyName("description")]
        public JobDescription Description { get; set; }
        [JsonPropertyName("jobDescriptionId")]
        public string JobDescriptionId { get; set; }

        public JobType Type { get; set; }
        [JsonPropertyName("jobType")]
        public string JobType { get; set; }

        public AccountingCompany Company { get; set; }
        [JsonPropertyName("accountingCompanyId")]
        public string AccountingCompanyId { get; set; }
        [JsonPropertyName("accountingCompany")]
        public string AccountingCompany { get; set; }
        [JsonPropertyName("displayAccountingCompanyId")]
        public string DisplayAccountingCompanyId { get; set; }
        [JsonPropertyName("displayAccountingCompany")]
        public string DisplayAccountingCompany { get; set; }

    }
}
