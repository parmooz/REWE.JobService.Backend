using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace REWE.JobService.Domain.Jobs
{
    public class JobDescription
    {
        [JsonPropertyName("jobDescriptionId")]
        public string Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("shortDescription")]
        public string ShortDescription { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("functions")]
        public List<string> Functions { get; set; }

        [JsonPropertyName("skills")]
        public List<string> Skills { get; set; }

        [JsonPropertyName("offers")]
        public List<string> Offers { get; set; }
        [JsonPropertyName("functionsTitle")]
        public string FunctionsTitle { get; set; }
        [JsonPropertyName("skillsTitle")]
        public string SkillsTitle { get; set; }
        [JsonPropertyName("offersTitle")]
        public string OffersTitle { get; set; }

        [JsonPropertyName("paymentInfo")]
        public string PaymentInfo { get; set; }
    }


    
}
