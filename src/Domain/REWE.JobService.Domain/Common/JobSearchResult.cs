using REWE.JobService.Domain.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace REWE.JobService.Domain.Common
{
    public class JobSearchResult
    {

        [JsonPropertyName("numberOfHits")]
        public int NumberOfHits { get; set; }

        [JsonPropertyName("totalCount")]
        public int TotalCount { get; set; }

        [JsonPropertyName("jobs")]
        public List<Job> Jobs { get; set; }
    }
}
