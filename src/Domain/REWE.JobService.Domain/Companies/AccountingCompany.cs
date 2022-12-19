using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace REWE.JobService.Domain.Companies
{
    public class AccountingCompany
    {
        [JsonPropertyName("accountingCompanyId")]
        public string Id { get; init; }
        [JsonPropertyName("name")]
        public string Name { get; init; }

        public int DisplayId { get; init; }
        public string DisplayName { get; init; }
    }
}
