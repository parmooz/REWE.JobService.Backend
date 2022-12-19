using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace REWE.JobService.Domain.Common
{
    public class Store
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("street")]
        public string Street { get; set; }
        [JsonPropertyName("amountOfJobs")]
        public int AmountOfJob { get; set; }
    }
}
