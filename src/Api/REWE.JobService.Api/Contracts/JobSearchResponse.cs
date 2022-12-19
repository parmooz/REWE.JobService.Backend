using REWE.JobService.Domain.Jobs;
using System.Text.Json.Serialization;

namespace REWE.JobService.Api.Contracts
{
    public record JobSearchResponse
    {
        public int NumberOfHits { get; set; }

        public int TotalCount { get; set; }
        public List<Job> Jobs { get; set; }
    }
}
