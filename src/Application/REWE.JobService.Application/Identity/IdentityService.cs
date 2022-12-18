using REWE.JobService.Application.Common.Interfaces;
using REWE.JobService.Application.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REWE.JobService.Application.Identity
{
    public class IdentityService : IIdentityService
    {
        public readonly ITokenGenerator _tokenGenerator;
        public IdentityService(ITokenGenerator tokenGenerator) { _tokenGenerator = tokenGenerator; }    
        public async Task<IdentityToken> GetToken(string username, string password)
        {
            var token =await  _tokenGenerator.GenerateToken(username, password);
            return token;
        }
    }
}
