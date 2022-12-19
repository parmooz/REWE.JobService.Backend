using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace REWE.JobService.Domain.Applications
{
    public class JobApplication
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("authCode")]
        public string AuthCode { get; set; }
        [JsonPropertyName("expirationTimestamp")]
        public string ExpirationTimestamp { get; set; }
        [JsonPropertyName("applicationDetails")]
        public ApplicationDetail Detail { get; set; }
    }
}
