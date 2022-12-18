using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REWE.JobService.Infrastructure.Common.ExternalServices.Http
{
    public class AuthTokenDto
    {
        public int refresh_token_expires_in { get; set; }
        public string customer_id { get; set; }
        public string access_token { get; set; }
        public int access_token_expires_in { get; set; }
        public string token_type { get; set; }
    }
}
