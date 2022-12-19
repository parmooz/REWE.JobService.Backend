using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace REWE.JobService.Domain.Applications
{
    public class ApplicationDetail
    {
        [JsonPropertyName("jobId")]
        public int JobId { get; set; }

        [JsonPropertyName("storeIdList")]
        public List<string> StoreIds { get; set; }

        [JsonPropertyName("desiredSalary")]
        public int DesiredSalary { get; set; }

        [JsonPropertyName("recommendedBy")]
        public int RecommendedBy { get; set; }

        [JsonPropertyName("availableFrom")]
        public DateTime AvailableFrom { get; set; }
        [JsonPropertyName("agreedToDataProcessing")]
        public bool AgreedToDataProcessing { get; set; }

        [JsonPropertyName("agreedToDataRelaying")]
        public bool AgreedToDataRelaying { get; set; }

        [JsonPropertyName("externalSource")]
        public string ExternalSource { get; set; }
    }
}
