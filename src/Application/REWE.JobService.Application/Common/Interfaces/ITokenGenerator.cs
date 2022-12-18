using REWE.JobService.Application.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REWE.JobService.Application.Common.Interfaces
{
    public  interface ITokenGenerator
    {
        Task<IdentityToken> GenerateToken(string username, string password);

    }
}
