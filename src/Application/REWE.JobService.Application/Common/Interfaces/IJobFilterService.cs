using REWE.JobService.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REWE.JobService.Application.Common.Interfaces
{
    public interface IJobFilterService
    {
        Task<JobFilter> GetAllJobFilters(string token, string correlationId);
    }
}
