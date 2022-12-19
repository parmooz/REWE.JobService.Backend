using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace REWE.JobService.Domain.Common
{
    public class link
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("method")]
        public string Method { get; set; }
        [JsonPropertyName("href")]
        public string href { get; set; }
    }
}
