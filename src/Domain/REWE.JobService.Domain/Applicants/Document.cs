using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REWE.JobService.Domain.Applicants
{
    public class Document
    {
        public int Id { init; get; }
        public string DocumentType { init; get; }
        public string DocumentName { init; get; }
    }
}