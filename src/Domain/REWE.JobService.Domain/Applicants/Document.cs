using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace REWE.JobService.Domain.Applicants
{
    public class Document
    {
        [JsonPropertyName("documentId")]
        public int Id { init; get; }
        [JsonPropertyName("documentType")]
        public string DocumentType { init; get; }
        [JsonPropertyName("documentName")]
        public string DocumentName { init; get; }
    }
}