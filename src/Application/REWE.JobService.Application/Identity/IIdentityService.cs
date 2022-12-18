using REWE.JobService.Application.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REWE.JobService.Application.Users
{
    public  interface IIdentityService
    {
         Task<IdentityToken> GetToken(string username, string password);
       
    }
}
