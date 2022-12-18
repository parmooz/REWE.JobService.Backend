using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REWE.JobService.Infrastructure.Common.ExternalServices.Http
{
    public class JobServiceSettings
    {
        public const string SectionName = "JobServiceSettings";
        public string Url { get; set; }
    }
}
