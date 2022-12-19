using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace REWE.JobService.Domain.Applicants
{
    public class Applicant
    {
        [JsonPropertyName("titleCode")]
        public string  TitleCode { get; init; }
        [JsonPropertyName("firstName")]
        public string FirstName { get; init; }
        [JsonPropertyName("lastName")]
        public string LastName { get; init; }
        [JsonPropertyName("gender")]
        public string Gender { get; init; }
        [JsonPropertyName("nationality")]
        public string Nationality { get; init; }
        [JsonPropertyName("telephoneNumber")]
        public string TelephoneNumber { get; init; }
        [JsonPropertyName("email")]
        public string Email { get; init; }
        [JsonPropertyName("birthDate")]

        public DateTime BirthDate { get; init; }
        [JsonPropertyName("countryCode")]
        public string CountryCode { get; init; }
        [JsonPropertyName("zip")]

        public string Zip { get; init; }
        [JsonPropertyName("city")]
        public string City { get; init; }
        [JsonPropertyName("street")]
        public string Street { get; init; }
        [JsonPropertyName("workPermit")]
        public bool WorkPermit { get; init; }
        [JsonPropertyName("driversLincenseClasses")]
        public string DriversLincenseClasses { get; init; }
        [JsonPropertyName("employedBefore")]
        public bool EmployedBefore { get; init; }
        [JsonPropertyName("militaryServiceFinished")]
        public bool MilitaryServiceFinished { get; init; }
        [JsonPropertyName("documents")]
        public List<Document> Documents { get; init;}


    }
}

