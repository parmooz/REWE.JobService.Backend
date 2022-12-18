using REWE.JobService.Application.Common.Interfaces;
using REWE.JobService.Application.Identity;
using REWE.JobService.Infrastructure.Common.ExternalServices.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REWE.JobService.Infrastructure.Identity
{
    public class TokenGenerator : ITokenGenerator
    {
        private AuthTokenClient _client;
        public TokenGenerator(AuthTokenClient client) { _client = client; }
        public async Task<IdentityToken> GenerateToken(string username, string password)
        {
            var res = await _client.GetToken(username, password);
            var token = new IdentityToken()
            {
                Token = res.access_token,
                Expire = res.access_token_expires_in,
            };
            return token;
        }
    }
}
