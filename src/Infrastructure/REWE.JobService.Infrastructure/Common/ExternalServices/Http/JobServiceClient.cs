using Microsoft.Extensions.Options;
using REWE.JobService.Domain.Applicants;
using REWE.JobService.Domain.Applications;
using REWE.JobService.Domain.Common;
using REWE.JobService.Domain.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace REWE.JobService.Infrastructure.Common.ExternalServices.Http
{
    public class JobServiceClient
    {
        public HttpClient _client { get; }
        private readonly JobServiceSettings _config;
        public JobServiceClient(HttpClient client, IOptions<JobServiceSettings> config)
        {
            _config = config.Value;
            _client = client;
            _client.BaseAddress = new Uri(_config.Url);
            _client.Timeout = new TimeSpan(0, 0, 120);
            _client.DefaultRequestHeaders.Clear();
        }
        public async Task<JobFilter> GetFilters(string token,string correlationId)
        {
            var _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            _client.DefaultRequestHeaders.Add("Authorization", string.Concat("bearer ", token));
            _client.DefaultRequestHeaders.Add("correlation-id", correlationId);
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            StringContent postContent = new StringContent("{}", Encoding.UTF8, "application/json");
            JobFilter res = null;

            try
            {
                using (var response = await _client.PostAsync("api/jobs/search/filters", postContent))
                {
                    response.EnsureSuccessStatusCode();
                    var stream = await response.Content.ReadAsStreamAsync();
                    res = await JsonSerializer.DeserializeAsync<JobFilter>(stream);
                }
            }
            catch (Exception ex) { }

            return res;
        }
        public async Task<JobSearchResult> SearchJob(string token,JobSearchFilter filter, string correlationId)
        {
            var _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            _client.DefaultRequestHeaders.Add("Authorization", string.Concat("bearer ", token));
            _client.DefaultRequestHeaders.Add("correlation-id", correlationId);
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            StringContent postContent = new StringContent("{}", Encoding.UTF8, "application/json");
            JobSearchResult res = null;

            try
            {
                using (var response = await _client.PostAsync("api/jobs/search", postContent))
                {
                    response.EnsureSuccessStatusCode();
                    var stream = await response.Content.ReadAsStreamAsync();
                    res = await JsonSerializer.DeserializeAsync<JobSearchResult>(stream);
                }
            }
            catch (Exception ex) { }

            return res;
        }
        public async Task<Job> GetJobDetail(string token,string jobId,string jobDescriptionId, string correlationId)
        {
            var _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            _client.DefaultRequestHeaders.Add("Authorization", string.Concat("bearer ", token));
            _client.DefaultRequestHeaders.Add("correlation-id", correlationId);
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            StringContent postContent = new StringContent(JsonSerializer.Serialize(""), Encoding.UTF8, "application/json");
            Job res = null;

            try
            {
                using (var response = await _client.PostAsync($"/api/jobs/{jobDescriptionId}/offers/{jobId}", postContent))
                {
                    response.EnsureSuccessStatusCode();
                    var stream = await response.Content.ReadAsStreamAsync();
                    res = await JsonSerializer.DeserializeAsync<Job>(stream);
                }
            }
            catch (Exception ex) { }

            return res;
        }

        public async Task<JobApplication> CreateApplicationAuth(string token, string correlationId)
        {
            var _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            _client.DefaultRequestHeaders.Add("Authorization", string.Concat("bearer ", token));
            _client.DefaultRequestHeaders.Add("ChallengeType", "recaptcha");
            _client.DefaultRequestHeaders.Add("ChallengeKey", "123"); 
            _client.DefaultRequestHeaders.Add("ChallengeAnswer", "123"); 
            _client.DefaultRequestHeaders.Add("correlation-id", correlationId);
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            StringContent postContent = new StringContent(JsonSerializer.Serialize(""), Encoding.UTF8, "application/json");
            JobApplication res = null;

            try
            {
                using (var response = await _client.PostAsync("/api/job-applications/credentials", postContent))
                {
                    response.EnsureSuccessStatusCode();
                    var stream = await response.Content.ReadAsStreamAsync();
                    res = await JsonSerializer.DeserializeAsync<JobApplication>(stream);
                }
            }
            catch (Exception ex) { }

            return res;
        }
        public async Task<Applicant> GetApplicant(string token,string applicationId,string authCode, string correlationId)
        {
            var _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            _client.DefaultRequestHeaders.Add("Authorization", string.Concat("bearer ", token));
            _client.DefaultRequestHeaders.Add("application-auth-code", authCode); 
            _client.DefaultRequestHeaders.Add("correlation-id", correlationId);
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            Applicant res = null;

            try
            {
                using (var response = await _client.GetAsync($"/api/job-applications/{applicationId}"))
                {
                    response.EnsureSuccessStatusCode();
                    var stream = await response.Content.ReadAsStreamAsync();
                    res = await JsonSerializer.DeserializeAsync<Applicant>(stream);
                }
            }
            catch (Exception ex) { }

            return res;
        }
        public async Task<JobApplication> CreateApplication(string token, JobApplication application, string correlationId)
        {
            var _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            _client.DefaultRequestHeaders.Add("Authorization", string.Concat("bearer ", token));
            _client.DefaultRequestHeaders.Add("application-auth-code", application.AuthCode);
            _client.DefaultRequestHeaders.Add("correlation-id", correlationId);
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            StringContent postContent = new StringContent(JsonSerializer.Serialize(application.Detail), Encoding.UTF8, "application/json");
            JobApplication res = null;

            try
            {
                using (var response = await _client.PostAsync($"/api/job-applications/{application.Id}/submit", postContent))
                {
                    response.EnsureSuccessStatusCode();
                    var stream = await response.Content.ReadAsStreamAsync();
                    res = await JsonSerializer.DeserializeAsync<JobApplication>(stream);
                }
            }
            catch (Exception ex) { }

            return res;
        }

    }
}
