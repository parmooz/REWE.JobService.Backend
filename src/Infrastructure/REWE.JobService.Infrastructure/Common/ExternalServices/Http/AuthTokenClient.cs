using Microsoft.Extensions.Options;
using System.Net.Http.Headers;
using System.Text.Json;

namespace REWE.JobService.Infrastructure.Common.ExternalServices.Http
{
    public class AuthTokenClient
    {
        public HttpClient _client { get; }
        private readonly AuthTokenSettings _config;
        private readonly JsonSerializerOptions _options;
        public AuthTokenClient(HttpClient client, IOptions<AuthTokenSettings> config)
        {
            _config = config.Value;
            _client = client;
            _client.BaseAddress = new Uri(_config.Url);
            _client.Timeout = new TimeSpan(0, 0, 30);
            _client.DefaultRequestHeaders.Clear();
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        }

        public async Task<AuthTokenDto> GetToken(string userName, string password)
        {
            AuthTokenDto token = new AuthTokenDto();
            var encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("UTF-8").GetBytes(userName + ":" + password));

            _client.DefaultRequestHeaders.Add("Authorization", string.Concat("Basic ", encoded));
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var data = new[]
            {
                 new KeyValuePair<string, string>("grant_type", "client_credentials")
            };



            using (var response = await _client.PostAsync("auth/token", new FormUrlEncodedContent(data)))
            {
                response.EnsureSuccessStatusCode();
                var stream = await response.Content.ReadAsStreamAsync();
                token = await JsonSerializer.DeserializeAsync<AuthTokenDto>(stream, _options);
               
            }
            return token;
        }
    }
}

