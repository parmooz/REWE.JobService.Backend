using System.Text.Json.Serialization;

namespace REWE.JobService.Api.Contracts
{
    public record JobSearchRequest
    {
        public string Token { get; set; }
        public string AccountingCompanyId { get; set; } = "";
        public List<string> AccountingCompanyIds { get; set; }= new List<string>();
        public List<string> JobGroupIds { get; set; }=new List<string>();
        public List<string> SubJobGroupIds { get; set; } = new List<string>();
        public List<string> JobTypeIds { get; set; } = new List<string>();
        public List<string> ProvinceIds { get; set; } = new List<string>();
        public List<string> DistrictIds { get; set; } = new List<string>();
        public string EmploymentLevelId { get; set; } = "";
        public string SearchTerm { get; set; } = "";
        public List<string> JobLevels { get; set; } = new List<string>();
        public string JobDescriptionId { get; set; } = "";
        public string Zip { get; set; } = "";
        public int MinWorkingHours { get; set; } = 0;
        public int MaxWorkingHours { get; set; }= 0;
        public int Offset { get; set; } = 5;
        public int Limit { get; set; } = 5;
        public string SortField { get; set; } = "";
        public string SortDirection { get; set; } = "";
        public bool IncludeInternal { get; set; } = false;
    }
}
