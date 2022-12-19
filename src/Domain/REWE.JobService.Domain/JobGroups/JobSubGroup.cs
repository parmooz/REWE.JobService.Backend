using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace REWE.JobService.Domain.JobGroups
{
    public class JobSubGroup
    {
        [JsonPropertyName("jobGroupId")]
        public int Id { get; init; }
        [JsonPropertyName("name")]
        public string Name { get; init; }
    }
}
