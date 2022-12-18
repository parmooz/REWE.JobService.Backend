using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REWE.JobService.Infrastructure.Common.ExternalServices.Http
{
    public class JobServiceClient
    {
        public HttpClient Client { get; }
        private readonly JobServiceSettings _config;
        public JobServiceClient(HttpClient client, IOptions<JobServiceSettings> config)
        {
            _config = config.Value;
            Client = client;
            Client.BaseAddress = new Uri(_config.Url);
            Client.Timeout = new TimeSpan(0, 0, 30);
            Client.DefaultRequestHeaders.Clear();
        }
    }
}
