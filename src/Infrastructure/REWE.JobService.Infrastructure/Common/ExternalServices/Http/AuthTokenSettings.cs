using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REWE.JobService.Infrastructure.Common.ExternalServices.Http
{
    public class AuthTokenSettings
    {
        public const string SectionName = "AuthTokenSettings";
        public string Url { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
    }
}
